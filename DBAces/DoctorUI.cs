using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DBAces
{
    public partial class DoctorUI : Form
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        int UserID;
        String DoctorFirstname, DoctorLastname, UserPhoneNumber, UserEmail;
        String FullName;
        public DoctorUI()
        {
            InitializeComponent();
        }
        public void getValues(int ID)
        {
            UserID = ID;
        }
        private void DoctorUI_Load(object sender, EventArgs e)
        {
            TogetDoctorAttribute();
            toGetSpecialistDoctorValue();
            DoctorID.Text = UserID.ToString();
            DoctorPhoneNumberLabel.Text = UserPhoneNumber;
            DoctorEmailLabel.Text = UserEmail;
            UserDoctorSpecializationLabel.Text = DoctorLastname + ", " + DoctorFirstname;
        }
        private void toLoadPanel(string s)
        {
            switch (s)
            {
                case "Dashboard":
                    Appointment.Hide();
                    HistorySale.Hide();
                    Setting.Hide();
                    Dashboard.Show();
                    break;
                case "Appointments":
                    HistorySale.Hide();
                    Setting.Hide();
                    Dashboard.Hide();
                    Appointment.Show();
                    break;
                case "HistorySale":
                    Appointment.Hide();
                    Setting.Hide();
                    Dashboard.Hide();
                    HistorySale.Show();
                    break;
                case "Setting":
                    Appointment.Hide();
                    HistorySale.Hide();
                    Dashboard.Hide();
                    Setting.Show();
                    break;

            }
        }
        private void toGetSpecialistDoctorValue()
        {
            string sql = "SELECT s.Specialization FROM DoctorSpecialization s JOIN Doctors d ON s.DoctorID = d.DoctorID JOIN Users u ON u.UserID = d.UserID WHERE u.UserID = @UserID;";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DoctorSpecializationLabel.Text = reader["Specialization"].ToString();
                        }
                    }
                }
                con.Close();
            }
        }


        private void TogetDoctorAttribute()
        {
            string sql = "SELECT FirstName,LastName,PhoneNum,Email FROM Doctors WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DoctorFirstname = reader["FirstName"].ToString();
                            DoctorLastname = reader["LastName"].ToString();
                            UserPhoneNumber = reader["PhoneNum"].ToString();
                            UserEmail = reader["Email"].ToString();
                        }
                    }
                }
            }
            FullName = DoctorLastname + ", " + DoctorFirstname;
        }
        private void DoctorID_Click(object sender, EventArgs e)
        {

        }

        private void DashboardPanelBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("Dashboard");
        }

        private void AppointmentBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("Appointments");
        }

        private void HistorySalePanelBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("HistorySale");
        }

        private void SettingPanelBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("Setting");
        }
    }
}
