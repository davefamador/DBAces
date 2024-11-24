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

        // USER VARIABLES
        static int UsersID = 0;
        string Firstname = "";
        string Lastname = "";
        DateOnly DateOfBirth;
        string Gender;
        int userBalance;

        // DOCTOR VARIABLE
        string DFirstName, DLastName;

        //COMBO BOX DOCTOR VARIABLE
        string DoctorsFirstName, DoctorsLastName, DoctorsPhoneNumber, DoctorEmail;



        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            toLoadUserDatas();
            ToLoadInformation(); toLoadComboBoxes();
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
                    AppointmentPanel.Show();
                    break;
                case "History_Panel":
                    AppointmentPanel.Hide();
                    AddBalancePanel.Hide();
                    UserSetting.Hide();
                    UserHome.Hide();
                    HistoryPanel.Show();
                    break;
                case "UserSetting_Panel":
                    HistoryPanel.Hide();
                    AppointmentPanel.Hide();
                    AddBalancePanel.Hide();
                    UserHome.Hide();
                    UserSetting.Show();
                    break;
                case "AddUserBalance_Panel":
                    HistoryPanel.Hide();
                    AppointmentPanel.Hide();
                    UserSetting.Hide();
                    UserHome.Hide();
                    AddBalancePanel.Show();
                    break;
                case "HomePanel":
                    HistoryPanel.Hide();
                    AppointmentPanel.Hide();
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


        private void toLoadUserDatas()
        {
            string sql = "SELECT UserID,FirstName,LastName,DateOfBirth,Gender FROM Patients WHERE UserID = @UserID";
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
                                Firstname = reader["FirstName"].ToString();
                                Lastname = reader["LastName"].ToString();
                                DateOfBirth = DateOnly.FromDateTime((DateTime)reader["DateOfBirth"]);
                                Gender = reader["Gender"].ToString();
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
                con.Close();
            }
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
        private bool CheckWithdrawalBalanceInput()
        {

            return false;
        }


        private void AddBalanceDepositBTN_Click(object sender, EventArgs e)
        {
            if (CheckBalanceInput())
            {
                if (ConfirmationMesssageBox())
                {

                }
            }
            else
            {
                MessageBox.Show("You Must Input Desired Number in the Deposit Box");
            }
        }

        private void AddBalanceWithdrawalBTN_Click(object sender, EventArgs e)
        {

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
            string fullName = SelectingDoctorComboBox.Text;
            string[] nameParts = fullName.Split(' ');

            string firstName = nameParts[0];
            string lastName = nameParts[1];

            string sql1 = "SELECT d.PhoneNum,d.Email,c.Cost FROM Doctors d JOIN CostPerDoctor c ON d.DoctorID = c.DoctorID WHERE d.FirstName = @FirstName AND d.LastName = @LastName;";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql1, con))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        MessageBox.Show("The Thread is here");
                        if (reader.Read())
                        {
                            DoctorsPhoneNumberLabel.Text = reader["PhoneNum"].ToString();

                            DoctorsEmailLabel.Text = reader["Email"].ToString();

                        }
                        else {
                            MessageBox.Show("NO FOUND DOCTOR");
                        }
                    }
                }
                con.Close();
            }
        }
        private void SelectingSpecialistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectingDoctorComboBox.Items.Clear();
            string sql = "SELECT d.FirstName, d.LastName FROM Doctors d JOIN DoctorSpecialization ds on d.DoctorID = ds.DoctorID WHERE  ds.Specialization = @Specialization; ";
            using (SqlConnection con = new SqlConnection(sqlcon)) {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.Add("@Specialization", SqlDbType.NVarChar).Value = SelectingSpecialistComboBox.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        
                        while (reader.Read()) {
                            string doctorfullname = "Doctor " + reader["FirstName"].ToString()+" "+reader["LastName"].ToString();
                            SelectingDoctorComboBox.Items.Add(doctorfullname);
                        }
                    }
                }
                    con.Close();
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

     
    }
}
