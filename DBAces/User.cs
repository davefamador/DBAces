using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace DBAces
{
    public partial class User : Form
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";

        static String Appointment_Panel = "Appoinment_Panel";
        static String History_Panel = "History_Panel";
        static String UserSetting_Panel = "UserSetting_Panel";
        static String AddUserBalance = "AddUserBalance_Panel";
        static String HomePanel = "Home";


        string firstName, lastName;
        //List<(string FirstName, string LastName)> doctorList = new List<(string FirstName, string LastName)>();
        List<int> doctorIDS = new List<int>();
        List<Tuple<string, string>> doctorInfo = new List<Tuple<string, string>>();

        // USER VARIABLES

        int UserBalance;
        int patientID = 0;
        static int UsersID = 0;
        string Firstname = "";
        string Lastname = "";
        string patientUsername = "";
        string patientpassword = "";
        DateOnly DateOfBirth;
        string Gender;
        int userBalance;

        // DOCTOR VARIABLE
        string DFirstName, DLastName;
        string dLastFirstName;
        int dTempDoctorID;

        //Appointment
        int AppointmentID;

        int tempDoctorID;

        //COMBO BOX DOCTOR VARIABLE
        string DoctorsFirstName, DoctorsLastName, DoctorsPhoneNumber, DoctorEmail;



        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            toLoadUserDatas();
            ToLoadInformation(); toLoadComboBoxes(); toLoadAppointment(); checkAppointment();
            PatientsIDLabel.Text = UsersID.ToString(); checkUserBalance(); UserInformationBarrier();
            toLoadPatientHistory();
        }
        private void UserInformationBarrier()
        {

        }
        private void toLoadAppointment()
        {

        }

        private void toLoadPatientHistory()
        {
            PatientAppointmentHistory PAppointmentHistory = new PatientAppointmentHistory();
            string sql = "SELECT COUNT(DoctorID) AS a FROM Appointments WHERE PatientID = @PatientID";
            string sql1 = "SELECT COUNT(AppointmentStatus) AS b  FROM Appointments WHERE AppointmentStatus IN ('FINISHED') AND PatientID = @PatientID";
            string sql3 = "SELECT a.AppointmentID,a.AppointmentDate, a.AppointmentStatus, a.Issue, a.Payment, CONCAT(d.FirstName, ' ', d.LastName) AS FULLNAME, d.PhoneNum, d.Email FROM Appointments a JOIN Patients p ON p.PatientID = a.PatientID JOIN Doctors d ON d.DoctorID = a.DoctorID WHERE p.PatientID = @PatientID;\r\n ";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientID;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            label35.Text = read["a"].ToString();
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sql1, con))
                {
                    cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientID.ToString();
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            label36.Text = read["b"].ToString();
                        }
                    }

                }

                //SELECT a.AppointmentDate, a.AppointmentStatus, a.Issue, a.Payment, CONCAT(d.FirstName, ' ', d.LastName) AS FULLNAME, d.PhoneNum, d.Email FROM Appointments a JOIN Patients p ON p.PatientID = a.PatientID JOIN Doctors d ON d.DoctorID = a.DoctorID WHERE p.PatientID = '18';\r\n ";
                using (SqlCommand cmd = new SqlCommand(sql3, con))
                {
                    cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientID;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {

                        while (read.Read())
                        {
                            PAppointmentHistory.toGetAttributes(read["AppointmentDate"].ToString() ?? "NOT SET", read["AppointmentStatus"].ToString() ?? "NOT SET", read["Issue"].ToString() ?? "NOT SET", read["Payment"].ToString() ?? "NOT SET",
                                read["FULLNAME"].ToString() ?? "NOT SET", read["PhoneNum"].ToString() ?? "NOT SET", read["Email"].ToString() ?? "NOT SET", read["AppointmentID"].ToString() ?? "NOT SET");
                            PatientHistory.Controls.Add(PAppointmentHistory);
                            PAppointmentHistory = new PatientAppointmentHistory();
                        }
                    }

                }
                con.Close();
            }


        }


        private void toLoadPanels(String s)
        {
            switch (s)
            {
                case "Appoinment_Panel":
                    AddBalancePanel.Hide();
                    HistoryPanel.Hide();
                    UserHome.Hide();
                    SettingPanel.Hide();
                    Appointment.Show();
                    break;
                case "History_Panel":
                    Appointment.Hide();
                    AddBalancePanel.Hide();
                    UserHome.Hide();
                    SettingPanel.Hide();
                    HistoryPanel.Show();
                    break;
                case "UserSetting_Panel":
                    HistoryPanel.Hide();
                    Appointment.Hide();
                    AddBalancePanel.Hide();
                    UserHome.Hide();
                    ModifyAccount.Hide();
                    UserBackground.Hide();
                    Setting.Show();
                    SettingPanel.Show();
                   
                    break;
                case "AddUserBalance_Panel":
                    HistoryPanel.Hide();
                    Appointment.Hide();
                    UserHome.Hide();
                    AddBalancePanel.Show();
                    break;
                case "HomePanel":
                    HistoryPanel.Hide();
                    SettingPanel.Hide();
                    Appointment.Hide();
                    AddBalancePanel.Hide();
                    UserHome.Show();
                    break;

            }
        }

        public void getDatas(int id)
        {
            UsersID = id;
        }

        private bool toCheckAppointmentSQL()
        {

            string sql = "SELECT CONCAT(d.FirstName, ' ', d.LastName) AS DoctorName, d.PhoneNum AS DoctorPhoneNumber,d.DoctorID, d.Email AS DoctorEmail, a.AppointmentID,a.AppointmentDate, a.AppointmentStatus, a.Issue, a.Payment FROM Appointments a JOIN Doctors d ON a.DoctorID = d.DoctorID JOIN Users uDoc ON d.UserID = uDoc.UserID WHERE a.AppointmentStatus IN ('PENDING', 'RESCHEDULE', 'DIAGNOSE') AND a.PatientID = @PatientID;";

            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //DoctorDoctr

                                AppointmentDoctorNameLabel.Text = reader["DoctorName"].ToString();
                                AppointmentDoctorPhoneNumberLabel.Text = reader["DoctorPhoneNumber"].ToString();
                                AppointmentDoctorEmailLabel.Text = reader["DoctorEmail"].ToString();
                                dTempDoctorID = int.Parse(reader["DoctorID"].ToString() ?? "0");

                                //Appointment
                                AppointmentStatusPatient.Text = reader["AppointmentStatus"].ToString();
                                AppointmentID = int.Parse(reader["AppointmentID"].ToString() ?? "0");
                                DateAppointment.Text = reader["AppointmentDate"].ToString();
                                IssueRBox.Text = reader["Issue"].ToString();
                                AppointmentPayment.Text = reader["Payment"].ToString();
                                label37.Text = AppointmentID.ToString();
                                return true;
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                return false;
            }

            return false;
        }

        private void checkAppointment()
        {
            if (toCheckAppointmentSQL())
            {
                AppointmentPanel.Hide();
                Appointmented.Show();
            }
            else
            {
                Appointmented.Hide();
                AppointmentPanel.Show();
            }

        }


        private void toLoadUserDatas()
        {
            string sql2 = "SELECT Username FROM Users WHERE UserID = @UserID";
            string sql = "SELECT PatientID,FirstName,LastName,DateOfBirth,Gender FROM Patients WHERE UserID = @UserID";
            string sql1 = "SELECT Balance FROM UserBalance Where UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                patientID = reader["PatientID"] == DBNull.Value ? 0 : int.Parse(reader["PatientID"].ToString());
                                Firstname = reader["FirstName"] == DBNull.Value ? "NOT SET" : reader["FirstName"].ToString();
                                Lastname = reader["LastName"] == DBNull.Value ? "NOT SET" : reader["LastName"].ToString();
                                DateOfBirth = reader["DateOfBirth"] == DBNull.Value ? DateOnly.MinValue : DateOnly.FromDateTime((DateTime)reader["DateOfBirth"]);
                                Gender = reader["Gender"] == DBNull.Value ? "NOT SET" : reader["Gender"].ToString();

                            }

                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e);
                }
                using (SqlCommand cmd = new SqlCommand(sql1, con))
                {
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = UsersID;
                        if (reader.Read())
                        {
                            userBalance = int.Parse(reader["Balance"].ToString());
                            UserBalanceLabel.Text = userBalance.ToString();
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sql2, con))
                {
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                    using (SqlDataReader reaeder = cmd.ExecuteReader())
                    {
                        if (reaeder.Read())
                        {
                            patientUsername = reaeder["Username"].ToString();
                            UsersUsername.Text = patientUsername;
                        }
                    }
                }
                con.Close();
            }
            label6.Text = Firstname;
            label4.Text = Lastname;
            label11.Text = DateOfBirth.ToString();
            label10.Text = Gender;
            label27.Text = UsersID.ToString();
        }

        private void ToLoadInformation()
        {
            UserFirstnameLabel.Text = Firstname + ",";
        }
        // [ ADD BALANCE PANEL ] = = = = = = = = == = = [ ENTRY ] = = = = = = = = 

        private bool ConfirmationMesssageBox()
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }

            return false;
        }

        private bool CheckBalanceInput()
        {

            if (PatientDepositInput.Text.Length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool CheckBalanceWithdrawalInput()
        {

            if (PatientWithdrawalInput.Text.Length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool CheckWithdrawalBalanceInput()
        {

            return false;
        }

        private void checkUserBalance()
        {

            string sql = "SELECT BALANCE FROM UserBalance WHERE UserID = @UserID";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userBalance = int.Parse(reader["BALANCE"].ToString());
                            UserBalanceLabel.Text = reader["BALANCE"].ToString();

                        }
                    }
                }
                con.Close();
            }
        }
        private void AddBalanceDepositBTN_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE UserBalance SET BALANCE = @Balance WHERE UserID = @UserID;";
            string sql1 = "INSERT INTO PaymentHistory (UserID,DATE,PaymentType,AMOUNT) VALUES (@UserID,@DATE,@PaymentType,@AMOUNT)";
            if (CheckBalanceInput())
            {
                if (ConfirmationMesssageBox())
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(sqlcon))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                                cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = userBalance + int.Parse(PatientDepositInput.Text);
                                cmd.ExecuteNonQuery();
                            }
                            using (SqlCommand cmd = new SqlCommand(sql1, con))
                            {
                                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                                cmd.Parameters.Add("@DATE", SqlDbType.Date).Value = DateTime.Now;
                                cmd.Parameters.Add("@PaymentType", SqlDbType.NVarChar).Value = "DEPOSIT";
                                cmd.Parameters.Add("@AMOUNT", SqlDbType.Int).Value = int.Parse(PatientDepositInput.Text);
                                cmd.ExecuteNonQuery();

                            }
                            con.Close();
                            checkUserBalance();
                            MessageBox.Show("The Balance is added");

                        }


                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("" + aa);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Must Input Desired Number in the Deposit Box");
            }
        }

        private void AddBalanceWithdrawalBTN_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO PaymentHistory (UserID,DATE,PaymentType,AMOUNT) VALUES (@UserID,@DATE,@PaymentType,@AMOUNT)";
            string sql = "UPDATE UserBalance SET BALANCE = @Balance WHERE UserID = @UserID;";
            if (CheckBalanceWithdrawalInput())
            {
                if (ConfirmationMesssageBox())
                {

                    using (SqlConnection con = new SqlConnection(sqlcon))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                            cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = userBalance - int.Parse(PatientWithdrawalInput.Text);
                            cmd.ExecuteNonQuery();
                        }
                        using (SqlCommand cmd = new SqlCommand(sql1, con))
                        {
                            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                            cmd.Parameters.Add("@DATE", SqlDbType.Date).Value = DateTime.Now;
                            cmd.Parameters.Add("@PaymentType", SqlDbType.NVarChar).Value = "WITHDRAW";
                            cmd.Parameters.Add("@AMOUNT", SqlDbType.Int).Value = int.Parse(PatientWithdrawalInput.Text);
                            cmd.ExecuteNonQuery();

                        }
                        con.Close();
                        checkUserBalance();
                        MessageBox.Show("The Balance is Deducted");

                    }
                }
            }
            else
            {
                MessageBox.Show("You Must Input Desired Number in the Deposit Box");
            }
        }

        private void PatientDepositPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void AddBalanceWithdrawalBTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        // [ USER PANEL ] = = = = = = = = == = = [ END ] = = = = = = = = 




        // [ Appointment PANEL ] = = = = = = = = == = = [ Entry ] = = = = = = = = 

        private void toLoadComboBoxes()
        {
            string sql = "SELECT DISTINCT Specialization FROM DoctorSpecialization;";


            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SelectingSpecialistComboBox.Items.Clear();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SelectingSpecialistComboBox.Items.Add(reader["Specialization"].ToString());

                        }
                    }
                }
                con.Close();
            }
        }

        private void SelectingDoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayComboBox.Items.Clear();
            string[] nameParts = SelectingDoctorComboBox.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            firstName = nameParts[1];
            lastName = nameParts[0];



            string sql1 = $"SELECT d.DoctorID, d.PhoneNum, d.Email, c.Specialization, c.CostPerDoctor FROM Doctors d JOIN DoctorSpecialization c ON d.DoctorID = c.DoctorID WHERE d.LastName = @LastName AND d.FirstName = @FirstName";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql1, con))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tempDoctorID = int.Parse(reader["DoctorID"].ToString());
                            DoctorsPhoneNumberLabel.Text = reader["PhoneNum"].ToString();
                            DoctorsEmailLabel.Text = reader["Email"].ToString();
                            DoctorsCostLabel.Text = reader["CostPerDoctor"].ToString();
                            doctorsIDLabel.Text = tempDoctorID.ToString();
                        }
                        else
                        {
                            MessageBox.Show("NO FOUND DOCTOR");
                        }
                    }
                }
                con.Close();


            }
            string sql = "SELECT da.DoctorDayTime FROM DoctorAvailability da JOIN Doctors d ON da.DoctorID = d.DoctorID WHERE da.DoctorID = @DoctorID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = tempDoctorID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string aa = reader["DoctorDayTime"].ToString();
                                DayComboBox.Items.Add(aa);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show("" + ax);
            }
        }
        private void SelectingSpecialistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DayComboBox.Items.Clear();
            SelectingDoctorComboBox.Items.Clear();
            TimeComboBox.Items.Clear();

            string message = "";
            string sql = "SELECT d.FirstName, d.LastName FROM Doctors d JOIN DoctorSpecialization ds on d.DoctorID = ds.DoctorID WHERE  ds.Specialization = @Specialization; ";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Specialization", SqlDbType.NVarChar).Value = SelectingSpecialistComboBox.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string doctorfullname = reader["LastName"].ToString() + ", " + reader["FirstName"].ToString();
                            doctorInfo.Add(Tuple.Create(reader["FirstName"].ToString(), reader["LastName"].ToString()));
                            SelectingDoctorComboBox.Items.Add(doctorfullname);

                        }
                    }
                }
                con.Close();
            }

        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT da.DoctorTime FROM DoctorAvailability da JOIN Doctors d ON da.DoctorID = d.DoctorID WHERE da.DoctorID = @DoctorID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = tempDoctorID.ToString();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show("" + ax);
            }
        }

        private void DayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT da.DoctorTime FROM DoctorAvailability da JOIN Doctors d ON da.DoctorID = d.DoctorID WHERE da.DoctorID = @DoctorID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = tempDoctorID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<string> timeList = new List<string>(reader["DoctorTime"].ToString().Split(new string[] { "," }, StringSplitOptions.None));
                                foreach (string time in timeList)
                                {
                                    TimeComboBox.Items.Add(time);
                                }
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show("" + ax);
            }

        }
        private void PatientAppointmentSQL()
        {
            string sql = "INSERT INTO Appointments (PatientID, DoctorID,AppointmentDate,AppointmentStatus,Issue,Payment) VALUES (@PatientID,@DoctorID,@AppointmentDate,@AppointmentStatus,@Issue,@Payment );";
            string sql2 = "UPDATE UserBalance SET BALANCE = @Balance WHERE UserID = @UserID;";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientID;
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = tempDoctorID;
                        cmd.Parameters.Add("@AppointmentDate", SqlDbType.Text).Value = DayComboBox.Text + ", " + TimeComboBox.Text;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "PENDING";
                        cmd.Parameters.Add("@Issue", SqlDbType.Text).Value = IsseRichTexBox.Text;
                        cmd.Parameters.Add("@Payment", SqlDbType.Int).Value = int.Parse(DoctorsCostLabel.Text);
                        cmd.ExecuteNonQuery();

                    }
                    using (SqlCommand cmd = new SqlCommand(sql2, con))
                    {
                        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                        cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = userBalance - int.Parse(DoctorsCostLabel.Text);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    checkUserBalance();
                    MessageBox.Show("Your Request have been moved");
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show("" + ax);

            }
        }

        private string toCheckAppointment()
        {
            string tocheck = "";

            if (SelectingSpecialistComboBox.Text.Length <= 0 || SelectingDoctorComboBox.Text.Length <= 0 || DayComboBox.Text.Length <= 0 || TimeComboBox.Text.Length <= 0)
            {
                tocheck += "Please Fill in the requirement";
            }
            if (IsseRichTexBox.Text.Length <= 0)
            {
                tocheck += "\nPlease Tell us what is your concern. ";

            }
            return tocheck;
        }
        private bool toCheckBalanceAppointment()
        {
            if (userBalance > int.Parse(DoctorsCostLabel.Text))
            {
                return true;
            }
            return false;
        }
        private void PatientAppointment_Click(object sender, EventArgs e)
        {
            if (toCheckAppointment().Length <= 0)
            {
                if (toCheckBalanceAppointment())
                {
                    PatientAppointmentSQL();
                    checkAppointment();
                }
                else
                {
                    MessageBox.Show("Your balance is not enough");
                }
            }
            else
            {
                MessageBox.Show("" + toCheckAppointment());
            }
        }
        // [ Appointment PANEL ] = = = = = = = = == = = [ End ] = = = = = = = = 


        private void ChangePasswordSQL()
        {
            string sql = "UPDATE Patients SET Password = @Password WHERE UserID = @UserID";

            if (!String.IsNullOrEmpty(UsernameInput.Text) && !String.IsNullOrEmpty(PasswordInput.Text))
            {
                if (ToFindUserNamesql(UsernameInput.Text))
                {
                    using (SqlConnection con = new SqlConnection(sqlcon))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordInput.Text;
                            cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = UsersID;
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("Users Password Changed");
                        toLoadPanels("UserSetting_Panel");
                    }
                }
                else if (!ToFindUserNamesql(UsernameInput.Text))
                {
                    MessageBox.Show("Please input another username. The username is already taken.");
                }
            }
            else
            {
                MessageBox.Show("Please input another username & Password");
            }
        }

        private bool ToFindUserNamesql(string username)
        {
            string sql = "SELECT Username FROM Users WHERE Username = @Username";

            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return !reader.HasRows;

                        }
                    }
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return false;
        }

        private void ChangeUsernameSQL()
        {
            if (!String.IsNullOrEmpty(UsernameInput.Text) && !String.IsNullOrEmpty(PasswordInput.Text))
            {
                if (ToFindUserNamesql(UsernameInput.Text))
                {
                    string sql = "UPDATE Patients SET Username = @Username WHERE UserID = @UserID";
                    using (SqlConnection con = new SqlConnection(sqlcon))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UsernameInput.Text;
                            cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = UsersID;
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("Users Username Changed");
                        toLoadPanels("UserSetting_Panel");
                    }
                }
                else if (!ToFindUserNamesql(UsernameInput.Text))
                {
                    MessageBox.Show("Please input another username. The username is already taken.");
                }
            }
            else
            {
                MessageBox.Show("Please input another username & Password");
            }

        }




        private void changeuserpass()
        {
            string sql = "UPDATE Users SET Username = @Username, Password = @Password WHERE UserID = @UserID";
            if (!String.IsNullOrEmpty(UsernameInput.Text) && !String.IsNullOrEmpty(PasswordInput.Text))
            {
                if (ToFindUserNamesql(UsernameInput.Text))
                {
                    using (SqlConnection con = new SqlConnection(sqlcon))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UsernameInput.Text;
                            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordInput.Text;
                            cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = UsersID;
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("Users Username & Password Changed");
                        toLoadPanels("UserSetting_Panel");
                    }
                }
                else if (!ToFindUserNamesql(UsernameInput.Text))
                {
                    MessageBox.Show("Please input another username. The username is already taken.");
                }
            }
            else
            {
                MessageBox.Show("Please input another username & Password");
            }
        }


        private void UserSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(History_Panel);
        }

        private void AppointmentBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(Appointment_Panel);
        }

        private void SettingBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(UserSetting_Panel);
        }

        private void HistoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserAddBalanceBTN_Click(object sender, EventArgs e)
        {
            AccountSettingPanel(3);
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(HomePanel);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserHomeLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void DateAppointment_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void cancelAppointmentBTN_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Appointments SET AppointmentStatus = @AppointmentStatus WHERE AppointmentID = @AppointmentID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "CANCELLED";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                checkAppointment();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void PatientWithdrawalInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AccountSettingPanel(int s)
        {
            switch (s)
            {
                case 1:
                    UserBackground.Hide();
                    Setting.Hide();
                    AddBalancePanel.Hide();
                    ModifyAccount.Show();
                    break;
                case 2:
                    ModifyAccount.Hide();
                    Setting.Hide();
                    AddBalancePanel.Hide();
                    UserBackground.Show();
                    break;
                case 3:
                    UserBackground.Hide();
                    Setting.Hide();
                    ModifyAccount.Hide();
                    AddBalancePanel.Show();
                    break;
            }
        }
        private void ModifyAccountBTN_Click(object sender, EventArgs e)
        {
            AccountSettingPanel(1);
        }




        private void ModifyingAccountBTN_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text.Length > 0 && PasswordInput.Text.Length > 0)
            {
                changeuserpass();
                toLoadUserDatas();
            }
            else if (UsernameInput.Text.Length > 0 && PasswordInput.Text.Length == 0)
            {
                ChangeUsernameSQL();
                toLoadUserDatas();
            }
            else if (UsernameInput.Text.Length == 0 && PasswordInput.Text.Length > 0)
            {
                ChangePasswordSQL();
                toLoadUserDatas();
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void ModifyInformation_Click(object sender, EventArgs e)
        {
            AccountSettingPanel(2);
        }

        private void sqlname()
        {
            string sql = "UPDATE Patients SET FirstName = @FirstName ,LastName = @LastName WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstnameBox.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastnameBox.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Fullname have Updated");
            }
        }
        private void sqlphone()
        {
            string sql = "UPDATE Patients SET DateOfBirth = @DateOfBirth WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Phone Number have Updated");
            }
        }

        private void sqlemail()
        {
            string sql = "UPDATE Patients SET Gender = @Gender WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = comboBox1.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Email have Updated");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstnameBox.Text.Length > 2 && LastnameBox.Text.Length > 2)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlname();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please input your name. Thank you");
            }
        }
        private void ChangeEmailBTN_Click(object sender, EventArgs e)
        {
            string ss = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedIndex != -1)  // Check if an item is selected
            {
                sqlemail();
            }
            else
            {
                MessageBox.Show("Please Select Gender. Thank  you");
            }
        }

        private void ChangePhoneNumber_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            if (selectedDate != DateTime.MinValue)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlphone();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {

            }
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifyDateBTN_Click(object sender, EventArgs e)
        {
            UpdateAppointmentDate appointmentDate = new UpdateAppointmentDate();
            appointmentDate.getAppointmentID(AppointmentID, dTempDoctorID);
            appointmentDate.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginConsole login = new LoginConsole();
            login.Show();
        }

        private void PatientsIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
