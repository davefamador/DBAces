using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBAces
{

    public partial class AdminUI : Form
    {

        // Variables : 

        int MaxErrorMessage = 50;
        String DoctorRole = "Doctor";



        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";

        public AdminUI()
        {
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            toLoadDoctorInformation();
            toLoadPatientInformation();

            DoctorDisplayFlowLayout.Show();
        }

        private void toLoadPanels(String s)
        {
            switch (s)
            {
                case "User":
                    DashboardPanel.Hide();
                    AppointmentPanel.Hide();
                    PaymentHistoryPanel.Hide();
                    AddUserPanel.Hide();
                    UserPanel.Show();
                    break;
                case "Appointment":
                    DashboardPanel.Hide();
                    UserPanel.Hide();
                    PaymentHistoryPanel.Hide();
                    AddUserPanel.Hide();
                    AppointmentPanel.Show();
                    break;
                case "PaymentHistory":
                    DashboardPanel.Hide();
                    AppointmentPanel.Hide();
                    UserPanel.Hide();
                    AddUserPanel.Hide();
                    PaymentHistoryPanel.Show();
                    break;
                case "Dashboard":
                    AppointmentPanel.Hide();
                    PaymentHistoryPanel.Hide();
                    UserPanel.Hide();
                    AddUserPanel.Hide();
                    DashboardPanel.Show();
                    break;
                case "AddDoctor":
                    AppointmentPanel.Hide();
                    PaymentHistoryPanel.Hide();
                    UserPanel.Hide();
                    DashboardPanel.Hide();
                    AddUserPanel.Show();
                    break;
            }
        }


        // [ USER PANEL ] = = = = = = = = == = = [ ENTRY ] = = = = = = = = 
        private void toLoadPatientInformation()
        {
            AdminPatientConfiguration adminPatientConfiguration = new AdminPatientConfiguration();
            string sql1 = @"SELECT u.Username, u.Password, p.PatientID, p.UserID, p.FirstName, p.LastName, p.DateOfBirth, p.Gender FROM Users u JOIN Patients p ON u.UserID = p.UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            adminPatientConfiguration.toGetAttributes(reader["Username"].ToString() ?? string.Empty, reader["Password"].ToString() ?? string.Empty, Convert.ToInt32(reader["UserID"]), reader["FirstName"].ToString() + ", " + reader["LastName"].ToString(), reader["DateOfBirth"].ToString() ?? string.Empty, reader["Gender"].ToString() ?? string.Empty);
                            PatientDisplayFlowLayout.Controls.Add(adminPatientConfiguration);
                            adminPatientConfiguration = new AdminPatientConfiguration();

                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void toLoadDoctorInformation()
        {
            AdminDoctorConfiguration adminconfiguration = new AdminDoctorConfiguration();
            string sql1 = "SELECT u.Username, u.Password, d.UserID, d.FirstName, d.LastName,d.PhoneNum,d.Email FROM Users u JOIN Doctors d ON u.UserID = d.UserID";
            bool checkread = false;
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adminconfiguration.toGetDatasDoctor(reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["UserID"]), reader["FirstName"].ToString() + ", " + reader["LastName"].ToString(), reader["PhoneNum"].ToString(), reader["Email"].ToString());
                            DoctorDisplayFlowLayout.Controls.Add(adminconfiguration);
                            adminconfiguration = new AdminDoctorConfiguration();

                        }

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
        private void toswitch(string s) { 
           switch(s){
                case "Patient":
                    DoctorUserPanel.Hide();
                    UserPatientPanel.Show();
                    break;
                case "Doctor":
                    UserPatientPanel.Hide();
                    DoctorUserPanel.Show();
                    break;
            }

        }
        private void UserPatientBTN_Click(object sender, EventArgs e)
        {
            toswitch("Patient");
        }
        private void UserDoctorBTN_Click(object sender, EventArgs e)
        {
            toswitch("Doctor");
        }

        // [ USER PANEL ] = = = = = = = = == = = [ END ] = = = = = = = = 


        // [ ADD DOCTOR PANEL ] = = = = = = = = == = = [ ENTRY ] = = = = = = = = 
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


        private void ToCreateDoctor()
        {
            string userName = DoctorUserNameTextbox.Text.ToString();
            string passWord = DoctorPasswordTextBox.Text.ToString();
            if (ToFindUserNamesql(userName)) {
                MessageBox.Show("Username has taken");
                return;
            }
            string sql = "INSERT INTO Users (Username, Password, Role) OUTPUT INSERTED.UserID VALUES (@Username, @Password, @Role)";
            string sql1 = "INSERT INTO Doctors (UserID, FirstName, LastName) OUTPUT INSERTED.DoctorID VALUES (@UserID, @FirstName, @LastName)";
            string sql2 = "INSERT INTO DoctorSpecialization (DoctorID, Specialization,CostPerDoctor) VALUES (@DoctorID, @Specialization,@CostPerDoctor)";
            string sql3 = "INSERT INTO DoctorBalance (DoctorID, TotalAmount) VALUES (@UserID, @TotalAmount)";

            int newUserID = 0;
            int newDoctorID = 0;

            using (SqlConnection con = new SqlConnection(sqlcon))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userName;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passWord;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = DoctorRole;
                        newUserID = (int)cmd.ExecuteScalar();
                        MessageBox.Show("" + newUserID);
                    }
                    using (SqlCommand cmd = new SqlCommand(sql1, con))
                    {
                        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = newUserID;
                        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = DoctorFirstNameTextBox.Text;
                        cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = DoctorLastNameTextBox.Text;
                        newDoctorID = (int)cmd.ExecuteScalar();
                        MessageBox.Show("New DoctorID: " + newDoctorID);
                    }


                    using (SqlCommand cmd = new SqlCommand(sql2, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = newDoctorID;
                        cmd.Parameters.Add("@Specialization", SqlDbType.NVarChar).Value = SpecializationTextBox.Text;
                        cmd.Parameters.Add("@CostPerDoctor", SqlDbType.Int).Value = 0;
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(sql3, con))
                    {
                        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = newUserID;
                        cmd.Parameters.Add("@BALANCE", SqlDbType.Int).Value = 0;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Doctor Account is Created");

                }
                catch (Exception aa)
                {
                    MessageBox.Show(" " + aa);
                }
                con.Close();
            }

        }
        private string ErrorMessage()
        {
            string messageresult = "";

            if (DoctorFirstNameTextBox.Text.Length < 3)
            {
                messageresult += "FirstName Must Above 3 Length \n";
            }
            if (DoctorLastNameTextBox.Text.Length < 3)
            {
                messageresult += "LastName Must above 3 Length\n";
            }
            if (DoctorUserNameTextbox.Text.Length < 3)
            {
                messageresult += "Username Must above 3 Length \n";
            }
            if (DoctorPasswordTextBox.Text.Length < 3)
            {
                messageresult += "Password Must above 3 Length\n";
            }
            return messageresult;
        }
        private bool toCheckInputTextbox()
        {
            if (!String.IsNullOrEmpty(DoctorUserNameTextbox.Text) && !String.IsNullOrEmpty(DoctorPasswordTextBox.Text) && !String.IsNullOrEmpty(DoctorFirstNameTextBox.Text) && !String.IsNullOrEmpty(DoctorLastNameTextBox.Text))
            {
                return true;
            }


            return false;
        }

        private void ToRegisterDoctorBTN_Click(object sender, EventArgs e)
        {
            if (toCheckInputTextbox())
            {
                ToCreateDoctor();
            }
            else if (!toCheckInputTextbox())
            {
                MessageBox.Show("You must fill out all the textbox");
            }

        }
        // [ ADD DOCTOR PANEL ] = = = = = = = = == = = [ END ] = = = = = = = = =
        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopBar_UserBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels("User");
        }

        private void AppointmentBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels("Appointment");
        }

        private void TopBar_PaymentHistoryBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels("PaymentHistory");
        }

        private void TopBar_DashboardBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels("Dashboard");
        }

        private void AddDoctorBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels("AddDoctor");
        }

        private void AddUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
