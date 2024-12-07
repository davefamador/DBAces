﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBAces
{
    public partial class DoctorUI : Form
    {



        // TO APPOINTMNET VARIABLES
        DateOnly daymonthyear; // Month,Day,Year
        List<string> DayTime = new List<string>();

        //
        int month, year;
        int static_month, static_year;
        DateTime now = DateTime.Now;

        DateTime startofthemonth;



        CalendarDisplayCurrentMonth dateventkey = new CalendarDisplayCurrentMonth();
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        int UserID, DoctorID;
        String DoctorFirstname, DoctorLastname, UserPhoneNumber, UserEmail;
        String FullName;
        public DoctorUI()
        {
            InitializeComponent();
        }
        public void getValues(int ID)
        {
            UserID = ID;
        }
        private void DoctorUI_Load(object sender, EventArgs e)
        {
            TogetDoctorAttribute();
            // toGetSpecialistDoctorValue();
            DisplayDays();
            toLoadPatientDiagnosis(); DoctorsIDLABEL.Text = DoctorID.ToString();

        }
        private void toLoadPanel(string s)
        {
            switch (s)
            {
                case "Dashboard":
                    Appointment.Hide();
                    HistorySale.Hide();
                    Setting.Hide();
                    Dashboard.Show();
                    break;
                case "Appointments":
                    HistorySale.Hide();
                    Setting.Hide();

                    Dashboard.Hide();
                    Appointment.Show();
                    break;
                case "HistorySale":
                    Appointment.Hide();
                    Setting.Hide();

                    Dashboard.Hide();
                    HistorySale.Show();
                    break;
                case "Setting":
                    Appointment.Hide();
                    HistorySale.Hide();
                    Dashboard.Hide();

                    Setting.Show();
                    break;

            }
        }

        private void DashboardPanelsLoad(string s)
        {
            switch (s)
            {
                case "Patient":
                    OnAppointmentPanel.Hide();
                    DashboardPatient.Show();
                    break;
                case "OnAppointment":
                    DashboardPatient.Hide();
                    OnAppointmentPanel.Show();
                    break;
            }
        }
        public void toloadPatient()
        {
            toLoadPatientDiagnosis();
        }
        public void toLoadPatientDiagnosis()
        {
            
            //LoadPatientDiagnosis
            string sql = "SELECT p.PatientID,a.AppointmentID,p.FirstName,p.LastName,p.DateOfBirth,p.Gender,a.Issue FROM Patients p JOIN Appointments a ON p.PatientID = a.PatientID WHERE a.DoctorID =  @DoctorID AND A.AppointmentStatus = @AppointmentStatus; ";
            DoctorsPatient Dpatient = new DoctorsPatient();
            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "DIAGNOSE";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {                       //UserID = DoctorID
                                Dpatient.toGetDatas(DoctorID, int.Parse(reader["PatientID"]?.ToString() ?? "0"), int.Parse(reader["AppointmentID"]?.ToString() ?? "0"), reader["FirstName"]?.ToString() ?? string.Empty, reader["LastName"]?.ToString() ?? string.Empty, reader["DateOfBirth"]?.ToString() ?? string.Empty, reader["Gender"]?.ToString() ?? string.Empty, reader["Issue"]?.ToString() ?? string.Empty);
                                Dpatient.toGetValueBTN("DIAGNOSE");
                                LoadPatientDiagnosis.Controls.Add(Dpatient);
                                Dpatient = new DoctorsPatient();

                            }
                        }

                    }

                    con.Close();
                }
                string sql1 = "SELECT a.AppointmentID,p. p.FirstName,p.LastName,p.DateOfBirth,p.Gender,a.Issue FROM Patients p JOIN Appointments a ON p.PatientID = a.PatientID WHERE a.DoctorID =  @DoctorID AND A.AppointmentStatus = @AppointmentStatus; ";

                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                        cmd.Parameters.Add("@AppointmentStatus", SqlDbType.NVarChar).Value = "PENDING";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Dpatient.toGetDatas(DoctorID, int.Parse(reader["PatientID"]?.ToString() ?? "0"), int.Parse(reader["AppointmentID"]?.ToString() ?? "0"), reader["FirstName"]?.ToString() ?? string.Empty, reader["LastName"]?.ToString() ?? string.Empty, reader["DateOfBirth"]?.ToString() ?? string.Empty, reader["Gender"]?.ToString() ?? string.Empty, reader["Issue"]?.ToString() ?? string.Empty);
                                Dpatient.toGetValueBTN("PENDING");
                                GetAppointmentDoctor.Controls.Add(Dpatient);
                                Dpatient = new DoctorsPatient();

                            }
                        }

                    }

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void toGetSpecialistDoctorValue()
        {
            string sql = "SELECT s.Specialization FROM DoctorSpecialization s JOIN Doctors d ON s.DoctorID = d.DoctorID JOIN Users u ON u.UserID = d.UserID WHERE u.UserID = @UserID;";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                        }
                    }
                }
                con.Close();
            }
        }


        private void TogetDoctorAttribute()
        {
            string sql = "SELECT DoctorID,FirstName,LastName,PhoneNum,Email FROM Doctors WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DoctorID = reader["DoctorID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DoctorID"]);
                            DoctorFirstname = reader["FirstName"]?.ToString() ?? string.Empty;
                            DoctorLastname = reader["LastName"]?.ToString() ?? string.Empty;
                            UserPhoneNumber = reader["PhoneNum"]?.ToString() ?? string.Empty;
                            UserEmail = reader["Email"]?.ToString() ?? string.Empty;
                        }
                    }
                }
            }
            FullName = DoctorLastname + ", " + DoctorFirstname;
        }
        private void DoctorID_Click(object sender, EventArgs e)
        {

        }

        private void DashboardPanelBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("Dashboard");
        }

        private void AppointmentBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("Appointments");
        }

        private void HistorySalePanelBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("HistorySale");
        }

        private void SettingPanelBTN_Click(object sender, EventArgs e)
        {
            toLoadPanel("Setting");
        }

        private void Top_Bar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;


            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            static_month = month;
            static_year = year;

            startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int daysofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            int currentDay = now.Day;



            for (int a = 1; a <= 7; a++)
            {
                DisplaySatToSun dis = new DisplaySatToSun();
                switch (a)
                {
                    case 1:
                        dis.display("Sunday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 2:
                        dis.display("Monday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 3:
                        dis.display("Tuesday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 4:
                        dis.display("Wednesday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 5:
                        dis.display("Thursday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 6:
                        dis.display("Friday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 7:
                        dis.display("Saturday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 8:

                        break;


                }

            }
            MonthsName.Text = monthname + " " + year;

            for (int a = 1; a <= daysofweek; a++)
            {
                DisplayRecentMonth calendardisplay = new DisplayRecentMonth();
                CalendarLayoutPanel.Controls.Add(calendardisplay);
            }
            for (int a = 1; a <= days; a++)
            {
                CalendarDisplayCurrentMonth displayCurrentMonth = new CalendarDisplayCurrentMonth();
                displayCurrentMonth.days(a, MonthsName.Text.ToString(), DoctorID);
                CalendarLayoutPanel.Controls.Add(displayCurrentMonth);
            }
        }


        private void PrevCalendarBtn_Click(object sender, EventArgs e)
        {
            if (month == DateTime.Now.Month && year == DateTime.Now.Year)
            {
                MessageBox.Show("You cannot go to a previous month than the current month.");

                return;
            }
            DateTime now = DateTime.Now;


            CalendarLayoutPanel.Controls.Clear();
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            if (month == now.Month && year == now.Year)
            {
                DisplayDays();
                return;
            }
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int a = 1; a <= 7; a++)
            {
                DisplaySatToSun dis = new DisplaySatToSun();
                switch (a)
                {
                    case 1:
                        dis.display("Sunday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 2:
                        dis.display("Monday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 3:
                        dis.display("Tuesday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 4:
                        dis.display("Wednesday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 5:
                        dis.display("Thursday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 6:
                        dis.display("Friday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 7:
                        dis.display("Saturday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 8:

                        break;


                }

            }

            MonthsName.Text = monthname + " " + static_year;
            for (int a = 1; a <= daysofweek; a++)
            {
                DisplayRecentMonth calendardisplay = new DisplayRecentMonth();
                CalendarLayoutPanel.Controls.Add(calendardisplay);
            }
            for (int a = 1; a <= days; a++)
            {
                CalendarDisplayCurrentMonth displayCurrentMonth = new CalendarDisplayCurrentMonth();
                displayCurrentMonth.days(a, MonthsName.Text.ToString(), DoctorID);
                CalendarLayoutPanel.Controls.Add(displayCurrentMonth);
            }
        }

        private void NextCalendarBtn_Click(object sender, EventArgs e)
        {
            CalendarLayoutPanel.Controls.Clear();
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }


            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int a = 1; a <= 7; a++)
            {
                DisplaySatToSun dis = new DisplaySatToSun();
                switch (a)
                {
                    case 1:
                        dis.display("Sunday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 2:
                        dis.display("Monday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 3:
                        dis.display("Tuesday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 4:
                        dis.display("Wednesday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 5:
                        dis.display("Thursday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 6:
                        dis.display("Friday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 7:
                        dis.display("Saturday");
                        CalendarLayoutPanel.Controls.Add(dis);
                        break;
                    case 8:
                        break;


                }
                MonthsName.Text = monthname + " " + year;
            }
            for (int a = 1; a <= daysofweek; a++)
            {
                DisplayRecentMonth calendardisplay = new DisplayRecentMonth();
                CalendarLayoutPanel.Controls.Add(calendardisplay);
            }
            for (int a = 1; a <= days; a++)
            {
                CalendarDisplayCurrentMonth displayCurrentMonth = new CalendarDisplayCurrentMonth();
                displayCurrentMonth.days(a, MonthsName.Text.ToString(), DoctorID);
                CalendarLayoutPanel.Controls.Add(displayCurrentMonth);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void OnAppointmentDashboard_Click(object sender, EventArgs e)
        {
            DashboardPanelsLoad("OnAppointment");
        }

        private void DiagnosPatient_Click(object sender, EventArgs e)
        {
            DashboardPanelsLoad("Patient");
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            LoginConsole login = new LoginConsole();

            this.Close();
            login.Show();
        }

        private void LoadPatientDiagnosis_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
