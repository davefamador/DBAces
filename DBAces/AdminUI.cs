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

namespace DBAces
{

    public partial class AdminUI : Form
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        AdminDoctorConfiguration adminconfiguration = new AdminDoctorConfiguration();
        public AdminUI()
        {
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            toLoadPatientInformation();
        }


        private void toLoadPatientInformation()
        {
            string sql1 = "SELECT u.Username,u.Password,p.UserID,p.FirstName,p.Lastname,p.DateofBirth,p.Gender FROM Users u JOIN Patients ON u.UserID = p.UserID;";
            using (SqlConnection con = new SqlConnection(sqlcon)) { 
                con.Open();
                try
                {
                  SqlCommand cmd = new SqlCommand(sql1,con);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            adminconfiguration.ToGetDatasPatient(reader["Username"].ToString(), reader["Password"].ToString(), int.Parse(reader["UserID"].ToString()), reader["LastName"].ToString() +", " + reader["FirstName"].ToString(), reader["DateOfBirth"].ToString(), reader["Gender"].ToString());
                            //adminconfiguration.
                            PatientDisplayFlowLayout.Controls.Add(adminconfiguration);
                            adminconfiguration = new AdminDoctorConfiguration();
                        }
                    }
                }
                catch (Exception ex) { }
            }
        }
        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
