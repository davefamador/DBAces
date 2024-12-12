using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAces
{
    public partial class PatientAppointmentHistory : UserControl
    {
        string appointmentDate, appointmentStatus, AppointmentIssue, Payment, Fullname, PhoneNumber, email;
        string appointmentIDS;
        public PatientAppointmentHistory()
        {
            InitializeComponent();
        }

        private void PatientAppointmentHistory_Load(object sender, EventArgs e)
        {
            toLoadLabels();
        }

        private void toLoadLabels()
        {
            DateTime date = DateTime.Parse(appointmentDate);// Or any DateTime variable
            string formattedDate = date.ToString("MM/dd/yy");

            DateLabel.Text = formattedDate;
            StatusLabel.Text = appointmentStatus;
            IssueBox.Text = AppointmentIssue;
            DoctorLabel.Text = Fullname;
            PaymentLabel.Text = Payment;
            PhoneNumberLabel.Text = PhoneNumber;
            EmailLabel.Text = email;
        }
        //PAppointmentHistory.toGetAttributes(read["AppointmentDate"].ToString() ?? "NOT SET", read["AppointmentStatus"].ToString() ?? "NOT SET",
        //read["Issue"].ToString() ?? "NOT SET", read["Payment"].ToString() ?? "NOT SET",
        // read["FULLNAME"].ToString() ?? "NOT SET", read["PhoneNum"].ToString() ?? "NOT SET", read["Email"].ToString() ?? "NOT SET");
        public void toGetAttributes(string AppointmentDate, string AppointmentStatus, string Issue, string payment, string fullname, string phoneNum, string Email, string appointmentID)
        {
            appointmentDate = AppointmentDate;
            appointmentStatus = AppointmentStatus;
            AppointmentIssue = Issue;
            Payment = payment;
            Fullname = fullname;
            PhoneNumber = phoneNum;
            email = Email;
            appointmentIDS = appointmentID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayPatientDiagnose patientDiagnose = new DisplayPatientDiagnose();
            patientDiagnose.Show();
        }
    }
}



