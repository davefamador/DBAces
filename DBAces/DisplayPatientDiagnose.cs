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
    public partial class DisplayPatientDiagnose : Form
    {
        int appointmentID = 0;
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";

        public DisplayPatientDiagnose()
        {
            InitializeComponent();
        }

        private void DisplayPatientDiagnose_Load(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            string sql = "SELECT Conditions, Treatments FROM MedicalDiagnosis WHERE AppointmentID = @AppointmentID";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = appointmentID;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.HasRows)  // Check if the query returns any rows
                        {
                            if (read.Read())  // Read the data
                            {
                                ConditionBox.Text = read["Condition"].ToString();
                                TreatmentsBox.Text = read["Treatments"].ToString();
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle the case here, 
                            // for example, clear the textboxes or set default values
                            ConditionBox.Text = "No conditions found";  // Optional default value
                            TreatmentsBox.Text = "No treatments found";  // Optional default value
                        }
                    }
                }
                con.Close();
            }


        }
        public void getID(int appointment)
        {
            appointmentID = appointment;
        }

        private void PatientDiagnos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
