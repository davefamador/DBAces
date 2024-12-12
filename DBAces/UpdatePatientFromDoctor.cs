using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DBAces
{
    public partial class UpdatePatientFromDoctor : Form
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";

        int AppointmentID;
        public UpdatePatientFromDoctor()
        {
            InitializeComponent();
        }

        private void UpdatePatientFromDoctor_Load(object sender, EventArgs e)
        {
            Query();
        }

        private void Query() {
            string sql = "UPDATE MedicalDiagnosis SET Conditions = @Conditions, Treatments = @Treatments WHERE Appointmentid = @Appointmentid";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = AppointmentID;
                        cmd.Parameters.Add("@Conditions", SqlDbType.NVarChar).Value = ConditionBox.Text;
                        cmd.Parameters.Add("@Treatments", SqlDbType.NVarChar).Value = TreatmentsBox.Text;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void getID(int a) { 
            AppointmentID = a;  
        }
    }
}
