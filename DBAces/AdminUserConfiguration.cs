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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DBAces
{
    public partial class AdminUserConfiguration : Form
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        int DoctorID;
        string Username, Password, doctorsname, doctorsphoneNumber, email;
        public AdminUserConfiguration()
        {
            InitializeComponent();
        }
        private void AdminUserConfiguration_Load(object sender, EventArgs e)
        {
            doctorIDs.Text = DoctorID.ToString();
        }

        public void SwitchPanel(int s)
        {
            switch (s)
            {
                case 1:
                    UserInformation.Hide();
                    UserBackground.Show();
                    break;
                case 2:
                    UserBackground.Hide();
                    UserInformation.Show();
                    break;
            }
        }
        public void getAttributes(int doctorID, string username, string password, string Doctorname, string DoctorphoneNumber, string Email)
        {
            DoctorID = doctorID;
            Username = username;
            Password = password;
            doctorsname = Doctorname;
            doctorsphoneNumber = DoctorphoneNumber;
            email = Email;
        }

        private void ConfirmationBTN_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text.Length > 0 && PasswordInput.Text.Length > 0)
            {
                changeuserpass();
            }
            else if (UsernameInput.Text.Length > 0 && PasswordInput.Text.Length == 0) {
                ChangeUsernameSQL();
            } else if (UsernameInput.Text.Length == 0 && PasswordInput.Text.Length > 0) {
                ChangePasswordSQL();
            }
        }

        private void ChangePasswordSQL() {
            string sql = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon)) { 
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordInput.Text;
                    cmd.ExecuteNonQuery();
                }
                    con.Close();
                MessageBox.Show("Users Password Changed");
            }
            this.Close();
        }
        private void ChangeUsernameSQL()
        {
            string sql = "UPDATE Users SET Username = @Username WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UsernameInput.Text;
                    cmd.Parameters.Add("@UserID",SqlDbType.Int).Value = DoctorID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Users Username Changed");
            }
            this.Close();
        }


        private void changeuserpass() {
            string sql = "UPDATE Users SET Username = @Username, Password = @Password WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UsernameInput.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordInput.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = DoctorID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Users Username & Password Changed");
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sqlname()
        {
            string sql = "UPDATE Doctors SET FirstName = @FirstName ,LastName = @LastName WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstnameBox.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastnameBox.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = DoctorID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Fullname have Updated");
            }
        }
        private void sqlphone()
        {
            string sql = "UPDATE Doctors SET PhoneNum = @PhoneNum WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@PhoneNum", SqlDbType.NVarChar).Value = FirstnameBox.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = DoctorID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Phone Number have Updated");
            }
        }

        private void sqlemail()
        {
            string sql = "UPDATE Doctors SET Email = @Email WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = FirstnameBox.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = DoctorID;
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

        private void ChangePhoneNumber_Click(object sender, EventArgs e)
        {
            if (PhoneNumberBox.Text.Length == 11)
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
                MessageBox.Show("Please input 11 Numbers");
            }
        }

        private void ChangeEmailBTN_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text.Length == 11)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlemail();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please input 11 Numbers");
            }
        }
    }
}
