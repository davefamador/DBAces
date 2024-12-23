﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Intrinsics.X86;

namespace DBAces
{
    public partial class DoctorsPatient : UserControl
    {
        string patientsStatus;
        int patientid = 0, doctorID = 0, ApppointmentID;

        DoctorUI doctorUI;
        //Patient Info

        string patientName, Gender, Birthday, Issue;
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        public DoctorsPatient()
        {
            InitializeComponent();
        }

        private void DoctorsPatient_Load(object sender, EventArgs e)
        {

        }
        public void toGetDatas(int doctorid, int patientID, int AppointmentIDs, string firstname, string lastname, string dateofbirth, string gender, string issue)
        {
            try
            {
                ApppointmentID = AppointmentIDs;
                AppointmentIDLabel1.Text = ApppointmentID.ToString();
                doctorID = doctorid;
                patientid = patientID;

                patientName = lastname + ", " + firstname;
                Birthday = dateofbirth;
                Gender = gender;
                Issue = issue;

                PatientName.Text = lastname + ", " + firstname;
                PatientBirthday.Text = dateofbirth;
                PatientGender.Text = gender;
                IssueBox.Text = issue;
            }
            catch (Exception ee) {
                MessageBox.Show("There is a Patient Doesnt have a Background Information record");
            }
            }
        public void toGetValueBTN(string btn)
        {
            patientsStatus = btn;
            button1.Text = btn;
        }


        private void PatientGender_Click(object sender, EventArgs e)
        {

        }
        private void SQL()
        {

            string sql = "UPDATE Appointments SET AppointmentStatus = @AppointmentStatus WHERE AppointmentID = @AppointmentID";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = ApppointmentID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "DIAGNOSE";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The Patient Added to your appointment.");
                    }
                    con.Close();
                }
                doctorUI.toLoadPatientDiagnosis();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DiagnosPatient diagnosPatient = new DiagnosPatient();
            if (patientsStatus == "PENDING")
            {
                SQL();
            }
            else if (patientsStatus == "DIAGNOSE")
            {
                diagnosPatient.toGetValues(ApppointmentID, doctorID, patientid, patientName);
                diagnosPatient.Show();
            }
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Appointments SET AppointmentStatus = @AppointmentStatus WHERE AppointmentID = @AppointmentID";
            string sql2 = "UPDATE ub\r\nSET BALANCE = ISNULL(ub.BALANCE, 0) + a.Payment\r\nFROM DoctorBalance ub\r\nJOIN Users u ON u.UserID = ub.UserID\r\nJOIN Appointments a ON a.PatientID = u.UserID\r\nWHERE a.DoctorID = @DoctorID AND a.AppointmentID = @AppointmentID; ";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = ApppointmentID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "CANCELLED";
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(sql2, con))
                    {
                        cmd.Parameters.Add("@AppointmentID", SqlDbType.Int).Value = ApppointmentID;
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = ApppointmentID;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ee) {
                MessageBox.Show(ee.Message);
            }
            MessageBox.Show("You have cancelled this appointment");
        }
    }
}
