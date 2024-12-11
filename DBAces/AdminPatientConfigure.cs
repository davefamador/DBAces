using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DBAces
{
    public partial class AdminPatientConfigure : Form
    {
        int patientID;
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        string username, password, patientname, dateOfbirth, gender;
        public AdminPatientConfigure()
        {
            InitializeComponent();
        }

        private void AdminPatientConfigure_Load(object sender, EventArgs e)
        {

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
        public void getAttributes(int PatientID, string Username, string Password, string Doctorname, string DateOfBirth, string Gender)
        {
            patientID = PatientID;
            username = Username;
            password = Password;
            patientname = Doctorname;
            dateOfbirth = DateOfBirth;
            gender = Gender;
        }

        private void sqlemail()
        {
            string sql = "UPDATE Patients SET Gender = @Gender WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = comboBox1.SelectedItem.ToString();
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = patientID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Email have Updated");
            }
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
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = patientID;
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
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = patientID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Phone Number have Updated");
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

        }

        private void BirthdayBTN_Click(object sender, EventArgs e)
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
                MessageBox.Show("Please input 11 Numbers");
            }
        }

        private void ChangeGenderBTN_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedIndex != -1)  // Check if an item is selected
            {
                sqlemail();
            }
            else
            {
                MessageBox.Show("Please Select Gender. Thank  you");
            }
        }
    }
 }
