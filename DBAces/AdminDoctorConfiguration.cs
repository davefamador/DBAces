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
using System.Runtime.InteropServices.Marshalling;

namespace DBAces
{
    public partial class AdminDoctorConfiguration : UserControl
    {
        int doctorID;
        string username, password, Doctorname, DoctorphoneNumber, Email;

        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";

        AdminUserConfiguration admin = new AdminUserConfiguration();
        public AdminDoctorConfiguration()
        {
            InitializeComponent();
        }
        private void AdminDoctorConfiguration_Load(object sender, EventArgs e)
        {

        }

        public void SendAttributeAdmin()
        {
            AdminUserConfiguration admin = new AdminUserConfiguration();
            admin.getAttributes(doctorID, username, password, Doctorname, DoctorphoneNumber, Email);
        }
        public void toGetDatasDoctor(string DoctorUsername, string DoctorPassword, int DoctorID, string DoctorName, string DoctorPhoneNumber, string DoctorEmail)
        {
            doctorID = DoctorID;
            username = DoctorUsername;
            password = DoctorPassword;
            Doctorname = DoctorName;
            DoctorphoneNumber = DoctorPhoneNumber;
            Email = DoctorEmail;

            DoctorIDLabel.Text = DoctorID.ToString();
            DoctorUsernameLabel.Text = DoctorUsername;
            DoctorPasswordLabel.Text = DoctorPassword;
            DoctorNameLabel.Text = DoctorName;
            DoctorPhoneNumberLabel.Text = DoctorPhoneNumber;
            DoctorEmailLabel.Text = DoctorEmail;

        }

        private string DoctorSpecialization()
        {
            string special = "";
            string sql = "SELECT Specialization FROM DoctorSpecialization WHERE DoctorID = @DoctorID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = doctorID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader["Specialization"].ToString() ?? string.Empty;
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ADMINDOCTORCONFIGURATION. DOCTORSPECIALIZATION \n \n" + ex);
            }

            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin.Close();
            admin = new AdminUserConfiguration();
            admin.getAttributes(doctorID, username, password, Doctorname, DoctorphoneNumber, Email);
            admin.SwitchPanel(2); // User Account Information
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.Close();
            admin = new AdminUserConfiguration();
            admin.getAttributes(doctorID, username, password, Doctorname, DoctorphoneNumber, Email);
            admin.SwitchPanel(1); // User Background Information
            admin.Show();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                toDeleteUser();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void toDeleteUser()
        {
            string sql = "DELETE FROM Users WHERE UserID = (SELECT UserID FROM Doctors WHERE UserID = @DoctorID)";
            string sql2 = "DELETE FROM DoctorBalance WHERE UserID = (SELECT UserID FROM Doctors WHERE UserID = @DoctorID)";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = doctorID;
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
