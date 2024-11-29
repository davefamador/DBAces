using System;
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
        int UserID;
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
            toGetSpecialistDoctorValue();
            DisplayDays();
            
            DoctorID.Text = UserID.ToString();
            DoctorPhoneNumberLabel.Text = UserPhoneNumber;
            DoctorEmailLabel.Text = UserEmail;
            UserDoctorSpecializationLabel.Text = DoctorLastname + ", " + DoctorFirstname;
        }
        private void toLoadPanel(string s)
        {
            switch (s)
            {
                case "Dashboard":
                    Appointment.Hide();
                    ToAddAppointment.Hide();
                    HistorySale.Hide();
                    Setting.Hide();
                    Dashboard.Show();
                    break;
                case "Appointments":
                    HistorySale.Hide();
                    Setting.Hide();
                    ToAddAppointment.Hide();
                    Dashboard.Hide();
                    Appointment.Show();
                    break;
                case "HistorySale":
                    Appointment.Hide();
                    Setting.Hide();
                    ToAddAppointment.Hide();
                    Dashboard.Hide();
                    HistorySale.Show();
                    break;
                case "Setting":
                    Appointment.Hide();
                    HistorySale.Hide();
                    Dashboard.Hide();
                    ToAddAppointment.Hide();
                    Setting.Show();
                    break;

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
                            DoctorSpecializationLabel.Text = reader["Specialization"].ToString();
                        }
                    }
                }
                con.Close();
            }
        }


        private void TogetDoctorAttribute()
        {
            string sql = "SELECT FirstName,LastName,PhoneNum,Email FROM Doctors WHERE UserID = @UserID";
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
                            DoctorFirstname = reader["FirstName"].ToString();
                            DoctorLastname = reader["LastName"].ToString();
                            UserPhoneNumber = reader["PhoneNum"].ToString();
                            UserEmail = reader["Email"].ToString();
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
            MonthsName.Text = monthname + " " + year;
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
            for (int a = 1; a <= daysofweek; a++)
            {
                DisplayRecentMonth calendardisplay = new DisplayRecentMonth();
                CalendarLayoutPanel.Controls.Add(calendardisplay);
            }
            for (int a = 1; a <= days; a++)
            {
                CalendarDisplayCurrentMonth displayCurrentMonth = new CalendarDisplayCurrentMonth();
                displayCurrentMonth.days(a, monthname);
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
            MonthsName.Text = monthname + " " + year;
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
            for (int a = 1; a <= daysofweek; a++)
            {
                DisplayRecentMonth calendardisplay = new DisplayRecentMonth();
                CalendarLayoutPanel.Controls.Add(calendardisplay);
            }
            for (int a = 1; a <= days; a++)
            {
                CalendarDisplayCurrentMonth displayCurrentMonth = new CalendarDisplayCurrentMonth();
                displayCurrentMonth.days(a, monthname);
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
            MonthsName.Text = monthname + " " + year;
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
            for (int a = 1; a <= daysofweek; a++)
            {
                DisplayRecentMonth calendardisplay = new DisplayRecentMonth();
                CalendarLayoutPanel.Controls.Add(calendardisplay);
            }
            for (int a = 1; a <= days; a++)
            {
                CalendarDisplayCurrentMonth displayCurrentMonth = new CalendarDisplayCurrentMonth();
                displayCurrentMonth.days(a, monthname);
                CalendarLayoutPanel.Controls.Add(displayCurrentMonth);
            }

        }


        //NEW DOCTOR APPOINTMENT

        private List<string> timeCheck()
        {
            Dictionary<CheckBox, string> checkBoxMappings = new Dictionary<CheckBox, string>
    {
    

        // Morning
        { checkBox1, "7:00 AM" },
        { checkBox2, "8:00 AM" },
        { checkBox4, "9:00 AM" },
        { checkBox3, "10:00 AM" },
        { checkBox5, "11:00 AM" },
        { checkBox10, "7:30 AM" },
        { checkBox9, "8:30 AM" },
        { checkBox8, "9:30 AM" },
        { checkBox7, "10:30 AM" },
        { checkBox6, "11:30 AM" },


        //Afternoon
        { checkBox20, "1:00 AM" },
        { checkBox19, "2:00 AM" },
        { checkBox18, "3:00 AM" },
        { checkBox17, "4:00 AM" },
        { checkBox16, "5:00 AM" },
        { checkBox15, "1:30 AM" },
        { checkBox14, "2:30 AM" },
        { checkBox13, "3:30 AM" },
        { checkBox12, "4:30 AM" },
        { checkBox11, "5:30 AM" },

        //Afternooon
        { checkBox24, "6:00 AM" },
        { checkBox23, "6:30 AM" },
        { checkBox22, "7:00 AM" },
        { checkBox21, "7:30 PM" },
        { checkBox25, "8:00 PM" },
        { SpecificTime, SpecificTimeTEXTBOX.Text}
            };

            return checkBoxMappings.Where(mapping => mapping.Key.Checked).Select(mapping => mapping.Value).ToList();
        }



        private void SpecificTimeTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SpecificTimeTEXTBOX.Focused)  // Only execute if the textbox is focused
                {
                    if (SpecificTimeTEXTBOX.Text.Length > 0)
                    {
                        SpecificTime.Checked = true;
                    }
                    else
                    {
                        SpecificTime.Checked = false;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void SpecificTimeTEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != ' ' &&
            e.KeyChar != 'A' && e.KeyChar != 'a' &&
            e.KeyChar != 'P' && e.KeyChar != 'p' &&
             e.KeyChar != 'M' && e.KeyChar != 'm' &&
            !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SpecificTimeTEXTBOX_Leave(object sender, EventArgs e)
        {
            string timePattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (AM|PM|am|pm)$";
            if (SpecificTime.Text.Length > 0)
            {

            }else if (!System.Text.RegularExpressions.Regex.IsMatch(SpecificTimeTEXTBOX.Text, timePattern))
            {
                MessageBox.Show("Invalid time format. Please enter time in hh:mm AM/PM format.");
                SpecificTimeTEXTBOX.Focus();
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToAddDoctorAvailableBTN_Click(object sender, EventArgs e)
        {
            DayTime = timeCheck();
            MessageBox.Show(string.Join("\n", DayTime), "Selected Times");
        }

        private void checkBox42_Click(object sender, EventArgs e)
        {

        }

        private void checkBox43_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
