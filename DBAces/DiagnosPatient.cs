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
    public partial class DiagnosPatient : Form
    {
        int doctorid, patientid,AppointmentID;
        DoctorUI doctor;
        string PatientName;
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";

        public DiagnosPatient()
        {
            InitializeComponent();
        }

        //ApppointmentID,doctorID,patientid,patientName
        public void toGetValues(int appointmentID, int doctorID, int patientID, string patientName)
        {
            doctorid = doctorID;
            AppointmentID = appointmentID;
            patientid = patientID;
            PatientName = patientName;
            label3.Text = appointmentID.ToString();
            label4.Text = doctorid.ToString();
        }
        private int getUserID() {
            string sql = "SELECT UserID FROM Doctors WHERE UserID = (SELECT UserID FROM Doctors WHERE DoctorID = @DoctorID)";
            using (SqlConnection con = new SqlConnection(sqlcon)) {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = doctorid;
                    using (SqlDataReader read = cmd.ExecuteReader()) {
                        if (read.Read()) {
                            return int.Parse(read["UserID"].ToString() ?? "0");
                        }
                    }
                }
                con.Close();
            }
            return 0;
        }

        private void InsertSQL()
        {
            string sql = "INSERT INTO MedicalDiagnosis (Appointmentid,DoctorID,PatientID,Conditions,DiagnosisDates,Treatments) VALUES (@Appointmentid,@DoctorID,@PatientID,@Conditions,@DiagnosisDates,@Treatments)";
            string sql2 = "UPDATE Appointments SET AppointmentStatus = @AppointmentStatus WHERE AppointmentID = @AppointmentID";
            string sql3 = @"
       UPDATE db
SET db.TotalAmount = ISNULL(db.TotalAmount, 0) + ISNULL(a.Payment, 0)
FROM DoctorBalance db
JOIN Users u ON u.UserID = db.DoctorID
JOIN Appointments a ON a.AppointmentID = @AppointmentID
WHERE u.UserID = (SELECT UserID FROM Doctors WHERE DoctorID = @DoctorID)
  AND a.DoctorID = @DoctorID;

    ";

            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();

                    // Insert Medical Diagnosis
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@Appointmentid", SqlDbType.Int).Value = AppointmentID;
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = doctorid;
                        cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientid;
                        cmd.Parameters.Add("@Conditions", SqlDbType.NVarChar).Value = ConditionBox.Text;
                        cmd.Parameters.Add("@DiagnosisDates", SqlDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.Add("@Treatments", SqlDbType.NVarChar).Value = TreatmentsBox.Text;
                        cmd.ExecuteNonQuery();
                    }

                    // Update Appointment Status
                    using (SqlCommand cmd = new SqlCommand(sql2, con))
                    {
                        cmd.Parameters.Add("@Appointmentid", SqlDbType.Int).Value = AppointmentID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "FINISHED";
                        cmd.ExecuteNonQuery();
                    }

                    // Update Doctor Balance with Payment from Appointment
                    using (SqlCommand cmd = new SqlCommand(sql3, con))
                    {
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID;
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = doctorid; // Assuming doctorid is correctly assigned
                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                }

                MessageBox.Show("Diagnose Completed");
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
        }


        private void DiagnosPatient_Load(object sender, EventArgs e)
        {
            PatientsName.Text = PatientName;
        }

        private void PatientDiagnos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                InsertSQL();
            }
            else if (result == DialogResult.No)
            {
               
            }
         
        }
    }
}
