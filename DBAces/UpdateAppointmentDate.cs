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

    public partial class UpdateAppointmentDate : Form
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        int appointmentID, dtempDoctorID;

        public UpdateAppointmentDate()
        {
            InitializeComponent();
        }

        private void UpdateAppointmentDate_Load(object sender, EventArgs e)
        {
            AppointmentSQL(); LoadAppointment();

        }

        private void LoadAppointment()
        {
            string sql = "SELECT da.DoctorDayTime FROM DoctorAvailability da JOIN Doctors d ON da.DoctorID = d.DoctorID WHERE da.DoctorID = @DoctorID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = dtempDoctorID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<string> timeList = new List<string>(reader["DoctorDayTime"].ToString().Split(new string[] { "," }, StringSplitOptions.None));
                                foreach (string time in timeList)
                                {
                                    DayComboBox.Items.Add(time);
                                }
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show("" + ax);
            }
            /*
       string sql = "SELECT d.DoctorID,a.DoctorDayTime,a.DoctorTime FROM Doctors d JOIN DoctorAvailability a ON d.DoctorID = a.DoctorID WHERE a.DoctorID = @DoctorID;";
       using (SqlConnection con = new SqlConnection(sqlcon)) {
           con.Open();
           using (SqlCommand cmd = new SqlCommand(sql, con)) {
               cmd.Parameters.Add("@DoctorID",SqlDbType.Int).Value = dtempDoctorID;
               using (SqlDataReader read = cmd.ExecuteReader()) {
                   while (read.Read()) {
                       List<string> timeList = new List<string>(read["DoctorTime"].ToString().Split(new string[] { "," }, StringSplitOptions.None));
                       foreach (string time in timeList)
                       {
                           TimeComboBox.Items.Add(time);
                       }
                   }
               }
           }
               con.Close();
       }
       */
        }



        private void AppointmentSQL()
        {
            string sql = "UPDATE Appointments SET AppointmentDate = @AppointmentDate WHERE AppointmentID = @AppointmentID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = appointmentID;
                    cmd.Parameters.Add("@AppointmentDate", SqlDbType.NVarChar).Value = "December 10 2025";
                }
                con.Close();
            }
        }

        public void getAppointmentID(int s, int a)
        {
            appointmentID = s;
            dtempDoctorID = a;
            LabelLoadID();
        }
        private void LabelLoadID() {
            DoctorIDlabel.Text = dtempDoctorID.ToString();
            AppointmentIDlabel.Text = appointmentID.ToString();
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT da.DoctorTime FROM DoctorAvailability da JOIN Doctors d ON da.DoctorID = d.DoctorID WHERE da.DoctorID = @DoctorID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = dtempDoctorID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<string> timeList = new List<string>(reader["DoctorTime"].ToString().Split(new string[] { "," }, StringSplitOptions.None));
                                foreach (string time in timeList)
                                {
                                    DayComboBox.Items.Add(time);
                                }
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show("" + ax);
            }
        }
    }
}
