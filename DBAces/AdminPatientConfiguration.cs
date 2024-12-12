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
    public partial class AdminPatientConfiguration : UserControl
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";


        int PatientID;
        string username, password, Doctorname, DoctorphoneNumber, Email;

        AdminPatientConfigure admin = new AdminPatientConfigure();
        public AdminPatientConfiguration()
        {
            InitializeComponent();
        }




        public void toGetAttributes(string DoctorUsername, string DoctorPassword, int PatientID, string PatientName, string DateofBirth, string gender)
        {

            this.PatientID = PatientID;
            username = DoctorUsername;
            password = DoctorPassword;
            Doctorname = PatientName;
            DoctorphoneNumber = DateofBirth;
            Email = gender;

            UserIDLabel.Text = PatientID.ToString();
            PatientUsernameLabel.Text = DoctorUsername;
            PatientPasswordLabel.Text = DoctorPassword;
            PatientNameLabel.Text = PatientName;
            PatientDateOfBirth.Text = DateofBirth;
            PatientGenderLabel.Text = gender;
        }
        private void AdminPatientConfiguration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin.Close();
            admin = new AdminPatientConfigure();
            admin.getAttributes(PatientID, username, password, Doctorname, DoctorphoneNumber, Email);
            admin.SwitchPanel(2); // User Account Information
            admin.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.Close();
            admin = new AdminPatientConfigure();
            admin.getAttributes(PatientID, username, password, Doctorname, DoctorphoneNumber, Email);
            admin.SwitchPanel(1); // User Account Information
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Users WHERE UserID = (SELECT UserID FROM Patients WHERE UserID = @DoctorID)";
            string sql2 = "DELETE FROM DoctorBalance WHERE UserID = (SELECT UserID FROM Doctors WHERE UserID = @DoctorID) ";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = PatientID;
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Number of Rows Affected: " + rowsAffected);
                    }
                  
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
