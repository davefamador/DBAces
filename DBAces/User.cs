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
            PatientsIDLabel.Text = UsersID.ToString(); checkUserBalance();
        }

        private void toLoadAppointment()
        {

        }
        private void toLoadPanels(String s)
        {
            switch (s)
            {
                case "Appoinment_Panel":
                    AddBalancePanel.Hide();
                    HistoryPanel.Hide();
                    UserSetting.Hide();
                    UserHome.Hide();
                    Appointment.Show();
                    break;
                case "History_Panel":
                    Appointment.Hide();
                    AddBalancePanel.Hide();
                    UserSetting.Hide();
                    UserHome.Hide();
                    HistoryPanel.Show();
                    break;
                case "UserSetting_Panel":
                    HistoryPanel.Hide();
                    Appointment.Hide();
                    AddBalancePanel.Hide();
                    UserHome.Hide();
                    UserSetting.Show();
                    break;
                case "AddUserBalance_Panel":
                    HistoryPanel.Hide();
                    Appointment.Hide();
                    UserSetting.Hide();
                    UserHome.Hide();
                    AddBalancePanel.Show();
                    break;
                case "HomePanel":
                    HistoryPanel.Hide();
                    Appointment.Hide();
                    UserSetting.Hide();
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

            string sql = "SELECT a.AppointmentDate,a.AppointmentStatus,a.Issue FROM Appointments a WHERE a.AppointmentStatus IN ('PENDING', 'RESCHEDULE', 'DIAGNOSE') AND PatientID = @PatientID;";

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
                                AppointmentStatusPatient.Text = reader["AppointmentStatus"].ToString();
                                DateAppointment.Text = reader["AppointmentDate"].ToString();
                                IssueRBox.Text = reader["Issue"].ToString();
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
                                Firstname = reader["FirstName"] == DBNull.Value ? "" : reader["FirstName"].ToString();
                                Lastname = reader["LastName"] == DBNull.Value ? "" : reader["LastName"].ToString();
                                DateOfBirth = reader["DateOfBirth"] == DBNull.Value ? DateOnly.MinValue : DateOnly.FromDateTime((DateTime)reader["DateOfBirth"]);
                                Gender = reader["Gender"] == DBNull.Value ? "" : reader["Gender"].ToString();

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
            label27.Text = patientID.ToString();
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
            string sql = "SELECT DISTINCT Specialization,DoctorID FROM DoctorSpecialization;";


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
                    using (SqlCommand cmd = new SqlCommand(sql2,con)) {
                        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UsersID;
                        cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = userBalance - int.Parse(DoctorsCostLabel.Text);
                        cmd.ExecuteNonQuery();
                    }
                        con.Close();
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
        private bool toCheckBalanceAppointment() {
            if (userBalance > int.Parse(DoctorsCostLabel.Text)) {
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
                else {
                    MessageBox.Show("I dont know : \n"+ DoctorsCostLabel + "\n"+ UserBalance);
                }
            }
            else
            {
                MessageBox.Show("" + toCheckAppointment());
            }
        }
        // [ Appointment PANEL ] = = = = = = = = == = = [ End ] = = = = = = = = 
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
            toLoadPanels(AddUserBalance);
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

        }

        private void PatientWithdrawalInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
