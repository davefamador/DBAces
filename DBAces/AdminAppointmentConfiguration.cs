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
    public partial class AdminAppointmentConfiguration : Form
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        int appointmentID;
        string patientName, DoctorNames;
        public AdminAppointmentConfiguration()
        {
            InitializeComponent();
        }

        private void AdminAppointmentConfiguration_Load(object sender, EventArgs e)
        {
            Query();

        }

        public void getAttributues(int x)
        {
            appointmentID = x;
        }
        private void Query()
        {
            string sql = "SELECT CONCAT(p.LastName, ' ',p.FirstName ) AS PatientName,CONCAT(d.LastName, ' ',d.FirstName ) AS DoctorName, a.Issue\r\n\tFROM Appointments a\r\nJOIN Patients p ON a.PatientID = p.PatientID\r\nJOIN Doctors d ON d.DoctorID = a.DoctorID\r\nWHERE a.AppointmentID = @AppointmentID  ";
            using (SqlConnection con = new SqlConnection(sqlcon)) { 
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql,con)) { 
                    cmd.Parameters.Add("@AppointmentID",SqlDbType.Int).Value = appointmentID;
                    using (SqlDataReader read = cmd.ExecuteReader()) {
                        if (read.Read()) {
                            patientName = read["PatientName"].ToString() ?? "NOT SET";
                            DoctorNames = read["DoctorName"].ToString() ?? "NOT SET";

                            PatientName.Text = patientName;
                            DoctorName.Text = DoctorNames;
                            label7.Text = read["Issue"].ToString() ?? "NOT SET";
                        }
                    }
                }
                    con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE MedicalDiagnosis SET Conditions = @Conditions WHERE Appointmentid = @Appointmentid";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Appointmentid", SqlDbType.Int).Value = appointmentID;
                    cmd.Parameters.Add("@Conditions", SqlDbType.NVarChar).Value = ConditionRBox.Text;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Condition is Modified");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE MedicalDiagnosis SET Treatments = @Treatments WHERE Appointmentid = @Appointmentid";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Appointmentid", SqlDbType.Int).Value = appointmentID;
                    cmd.Parameters.Add("@Treatments", SqlDbType.NVarChar).Value = TreatmentsRBox.Text;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Treatment is Modified");
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0) {
                string sql = "UPDATE Appointments SET AppointmentStatus = @AppointmentStatus WHERE Appointmentid = @Appointmentid";
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@Appointmentid", SqlDbType.Int).Value = appointmentID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = comboBox1.Text;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    MessageBox.Show("Treatment is Modified");
                }
            } else {
                MessageBox.Show("Please Pick a Status for this Appointment. Thank you");
            }
        }
    }
}
