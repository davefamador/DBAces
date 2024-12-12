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
    public partial class DoctorHistory : UserControl
    {
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        int DoctorID, appointmentID;
        string fullname, gender, birthday, issue, status;
        public DoctorHistory()
        {
            InitializeComponent();
        }

        private void DoctorHistory_Load(object sender, EventArgs e)
        {
            QUERY();
            toLoadPanels();
        }

        public void checkButton(string s) {
            switch (s) {
                case "PENDING":
                    button1.Hide();
                    break;
                case "CANCELLED":
                    button1.Hide();
                    break;
                case "Diagnosed":
                    button1.Show();
                    break;
                case "FINISHED":
                    button1.Show();
                    break;
            }
              
        }
        private void toLoadPanels()
        {
            PatientLabel.Text = fullname;
            GenderLabel.Text = gender;
            BirthdayLabel.Text = birthday;
            StatusLabel.Text = status;
            IssueBox.Text = issue;
        }

        //read["FULLNAME"].ToString(), read["Gender"].ToString(), read["DateOfBirth"].ToString(), read["Issue"].ToString(), read["AppointmentStatus"].ToString(), read["AppointmentID"].ToString());
        public void getAttributes(string Fullname, string Gender, string Birthday, string issues, string Status, int id)
        {
            fullname = Fullname;
            gender = Gender;
            birthday = Birthday;
            issue = issues;
            status = Status;
            appointmentID = id;
        }
        public void GetID(int ID)
        {
            DoctorID = ID;
        }
        private void QUERY()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePatientFromDoctor updatepatient = new UpdatePatientFromDoctor();
            updatepatient.getID(appointmentID);
            updatepatient.Show();
        }
    }
}
