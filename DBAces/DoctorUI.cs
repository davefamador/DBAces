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
        String DoctorFirstname, DoctorLastname, UserSpecialization, UserPhoneNumber, UserEmail;
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
            DoctorID.Text = UserID.ToString();
            DoctorNameLabel.Text = FullName;
            UserDoctorSpecializationLabel.Text = UserSpecialization;
            DoctorPhoneNumberLabel.Text = UserPhoneNumber;
            DoctorEmailLabel.Text = UserEmail;
        }

        private void TogetDoctorAttribute() {
            string sql = "SELECT FirstName,LastName,Specialization,PhoneNum,Email FROM Doctors WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon)) { 
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.AddWithValue("@UserID",UserID);
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            DoctorFirstname = reader["FirstName"].ToString();
                            DoctorLastname = reader["LastName"].ToString();
                            UserSpecialization  = reader["Specialization"].ToString();
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
    }
}
