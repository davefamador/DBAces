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
        }

        private void toDiagnosSQL()
        {
            string sql = "INSERT INTO MedicalDiagnosis (Appointmentid, DoctorID, PatientID, Conditions,DiagnosisDates,Treatments) VALUES (Appointmentid, DoctorID, PatientID, Conditions,DiagnosisDates,Treatments); ";


        }

        private void InsertSQL() {
            string sql = "INSERT INTO MedicalDiagnosis (Appointmentid,DoctorID,PatientID,Conditions,DiagnosisDates,Treatments) VALUES (@Appointmentid,@DoctorID,@PatientID,@Conditions,@DiagnosisDates,@Treatments)";

            string sql2 = "UPDATE Appointments SET AppointmentStatus = @AppointmentStatus WHERE AppointmentID = @AppointmentID";
            try {
                using (SqlConnection con = new SqlConnection(sqlcon)) { 
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con)) { 
                        cmd.Parameters.Add("@Appointmentid", SqlDbType.Int).Value = AppointmentID;
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = doctorid;
                        cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientid;
                        cmd.Parameters.Add("@Conditions", SqlDbType.NVarChar).Value = ConditionBox.Text;
                        cmd.Parameters.Add("@DiagnosisDates", SqlDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.Add("@Treatments", SqlDbType.NVarChar).Value = TreatmentsBox.Text;
                        cmd.ExecuteNonQuery();
                    }
          

                    using (SqlCommand cmd = new SqlCommand(sql2, con)) {
                        cmd.Parameters.Add("@Appointmentid",SqlDbType.Int).Value = AppointmentID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "FINISHED";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }

                MessageBox.Show("Diagnose Completed");
                this.Close();
                doctor.toLoadPatientDiagnosis();
            } catch (Exception a) {
                MessageBox.Show(""+a);
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
