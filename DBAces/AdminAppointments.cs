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
    public partial class AdminAppointments : UserControl
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        string date, Status, Issues, Payments, Fullname, AppointmentID;
        public AdminAppointments()
        {
            InitializeComponent();
        }

        private void AdminAppointments_Load(object sender, EventArgs e)
        {
            
            toloadLabel();

        }
        private void toloadLabel()
        {
            name.Text = Fullname;
            StatusLabel.Text = Status;
            IssueBox.Text = Issues;
            PaymentLabel.Text = Payments;
            DateLabel.Text = date;
            label2.Text = AppointmentID.ToString();
        }
        //a.AppointmentDate,a.AppointmentStatus,a.Issue
        public void getAttributes(string appointmentDate, string status, string issue, string payment, string fullname, int appointmentID)
        {
            date = appointmentDate;
            Status = status;
            Issues = issue;
            Payments = payment;
            Fullname = fullname;
            AppointmentID = appointmentID.ToString();
        }

        private void ModifyBTN_Click(object sender, EventArgs e)
        {
            AdminAppointmentConfiguration adminappointment = new AdminAppointmentConfiguration();
            adminappointment.getAttributues(int.Parse(AppointmentID));
            adminappointment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";
            using (SqlConnection con = new SqlConnection(sqlcon)) { 
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.Add("@AppointmentID",SqlDbType.Int).Value = AppointmentID;
                    cmd.ExecuteNonQuery();
                }
                    con.Close();
                MessageBox.Show("The Appointment is Deleted");
            }
        }
    }
}
