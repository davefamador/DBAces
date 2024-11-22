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

namespace DBAces
{

    public partial class AdminUI : Form
    {

        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";

        public AdminUI()
        {
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            toLoadPatientInformation();
            toLoadDoctorInformation();
        }


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

                            adminPatientConfiguration.toGetAttributes(reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["UserID"]), reader["FirstName"].ToString() + ", " + reader["LastName"].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(reader["DateOfBirth"])), reader["Gender"].ToString());
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
            string sql1 = @"SELECT u.Username, u.Password, d.UserID, d.FirstName, d.LastName,d.Specialization,d.PhoneNum,d.Email FROM Users u JOIN Doctors d ON u.UserID = d.UserID";
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
                            MessageBox.Show("Thread Reached Here");
                            adminconfiguration.toGetDatasDoctor(reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["UserID"]), reader["FirstName"].ToString() + ", " + reader["LastName"].ToString(), reader["Specialization"].ToString(), reader["PhoneNum"].ToString(), reader["Email"].ToString());
                            DoctorDisplayFlowLayout.Controls.Add(adminconfiguration);
                            adminconfiguration = new AdminDoctorConfiguration();
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
