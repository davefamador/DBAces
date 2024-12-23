﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
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

        int userBalance;

        CalendarDisplayCurrentMonth dateventkey = new CalendarDisplayCurrentMonth();
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        int UserID, DoctorID, CostPerDoctors;
        string usersUsername;
        string DoctorFirstname, DoctorLastname, UserPhoneNumber, DSpecialization;
        string UserEmail;
        string FullName;
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
            toLoadPatientDiagnosis();
            DisplayUserInfo();
            checkUserBalance();
            toLoadPatientHistory();
            checkCostPerDoctorFee();
        }

        private void toLoadPatientHistory()
        {
            DoctorHistory doctorHistory = new DoctorHistory();

            string sql3 = "SELECT CONCAT(p.FirstName, ' ', p.LastName) AS FULLNAME, p.Gender, p.DateOfBirth, a.Issue, a.AppointmentStatus,a.AppointmentID FROM Appointments a JOIN Patients p ON p.PatientID = a.PatientID JOIN Doctors d ON d.DoctorID = a.DoctorID WHERE d.DoctorID = @DoctorID;\r\n";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql3, con))
                {
                    cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {

                        while (read.Read())
                        {
                            doctorHistory.getAttributes(read["FULLNAME"].ToString(), read["Gender"].ToString(), read["DateOfBirth"].ToString(), read["Issue"].ToString(), read["AppointmentStatus"].ToString(), int.Parse(read["AppointmentID"].ToString()));
                            doctorHistory.checkButton(read["AppointmentStatus"].ToString() ?? "PENDING");
                            DoctorHistoryFlowPanel.Controls.Add(doctorHistory);
                            doctorHistory = new DoctorHistory();
                        }
                    }

                }


                con.Close();
            }
        }

        private void DisplayUserInfo()
        {
            /*
             DoctorID = reader["DoctorID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DoctorID"]);
                            DoctorFirstname = reader["FirstName"]?.ToString() ?? string.Empty;
                            DoctorLastname = reader["LastName"]?.ToString() ?? string.Empty;
                            UserPhoneNumber = reader["PhoneNum"]?.ToString() ?? string.Empty;
                            UserEmail
            */
            label2.Text = usersUsername;
            userFirstName.Text = DoctorFirstname.ToString();
            userLastname.Text = DoctorLastname.ToString();
            userPhone.Text = UserPhoneNumber.ToString();
            UsersEmailLabel.Text = UserEmail.ToString();
            DoctorSpecialistLabel.Text = DSpecialization;
            AccountUserIDsLabel.Text = UserID.ToString();
            label24.Text = DoctorID.ToString();
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
                    ModifyBackground.Hide();
                    ModifyAccount.Hide();
                    AddBalancePanel.Hide();
                    Setting.Show();
                    SettingPanel.Show();
                    break;

            }
        }

        private void DashboardPanelsLoad(string s)
        {
            switch (s)
            {
                case "Patient":
                    OnAppointmentPanel.Hide();
                    PatientsPanel.Show();
                    break;
                case "OnAppointment":

                    PatientsPanel.Hide();
                    OnAppointmentPanel.Show();
                    break;
            }
        }
        public void toloadPatient()
        {
            toLoadPatientDiagnosis();
        }

        private void toGetDoctorBalance()
        {

        }
        public void toLoadPatientDiagnosis()
        {

            //LoadPatientDiagnosis
            string sql = "SELECT p.PatientID, a.AppointmentID, p.FirstName, p.LastName, p.DateOfBirth, p.Gender, a.Issue FROM Appointments a JOIN Patients p ON p.PatientID = a.PatientID JOIN Doctors d ON d.DoctorID = a.DoctorID WHERE a.DoctorID = @DoctorID AND a.AppointmentStatus = @AppointmentStatus";
            DoctorsPatient Dpatient = new DoctorsPatient();

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
                            Dpatient.toGetDatas(DoctorID, int.Parse(reader["PatientID"]?.ToString() ?? "0"), int.Parse(reader["AppointmentID"]?.ToString() ?? "0"), reader["FirstName"]?.ToString() ?? "NOT SET", reader["LastName"]?.ToString() ?? string.Empty, reader["DateOfBirth"]?.ToString() ?? "NOT SET", reader["Gender"]?.ToString() ?? "NOT SET", reader["Issue"]?.ToString() ?? "NOT SET");
                            Dpatient.toGetValueBTN("DIAGNOSE");
                            LoadPatientDiagnosis.Controls.Add(Dpatient);
                            Dpatient = new DoctorsPatient();

                        }
                    }

                }

                con.Close();
            }
            string sql1 = "SELECT p.PatientID, a.AppointmentID, p.FirstName, p.LastName, p.DateOfBirth, p.Gender, a.Issue FROM Appointments a JOIN Patients p ON p.PatientID = a.PatientID JOIN Doctors d ON d.DoctorID = a.DoctorID WHERE a.DoctorID = @DoctorID AND a.AppointmentStatus = @AppointmentStatus";

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
            string sql1 = "SELECT UserName FROM Users WHERE UserID = @UserID";
            string sql2 = "SELECT Specialization,CostPerDoctor FROM DoctorSpecialization WHERE DoctorID = @DoctorID";

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
                            DoctorFirstname = reader["FirstName"]?.ToString() ?? "NOT SET";
                            DoctorLastname = reader["LastName"]?.ToString() ?? "NOT SET";
                            UserPhoneNumber = reader["PhoneNum"]?.ToString() ?? "NOT SET";
                            UserEmail = reader["Email"]?.ToString() ?? "NOT SET";
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sql1, con))
                {
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            usersUsername = read["UserName"].ToString() ?? "NOT SET";
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sql2, con))
                {
                    cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            DSpecialization = read["Specialization"].ToString() ?? "NOT SET";
                            CostPerDoctors = read["CostPerDoctor"] == DBNull.Value ? 0 : Convert.ToInt32(read["CostPerDoctor"]);
                        }
                    }
                }
            }
            FullName = DoctorLastname + ", " + DoctorFirstname;
        }

        private void checkCostPerDoctorFee()
        {
            string sql = "SELECT CostPerDoctor FROM DoctorSpecialization WHERE DoctorID = @DoctorID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            CostPerDoctors = int.Parse(read["CostPerDoctor"].ToString());
                        }

                    }
                }
                con.Close();
            }
            label23.Text = CostPerDoctors.ToString();
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

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void ModifyBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ToFindUserNamesql(string username)
        {
            string sql = "SELECT Username FROM Users WHERE Username = @Username";

            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return !reader.HasRows;

                        }
                    }
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return false;
        }
        private void AccountSettingPanel(int s)
        {
            switch (s)
            {
                case 1:
                    SettingPanel.Hide();
                    AddBalancePanel.Hide();
                    ModifyAccount.Show();
                    break;
                case 2:
                    SettingPanel.Hide();
                    AddBalancePanel.Hide();
                    ModifyBackground.Show();
                    break;
                case 3:
                    SettingPanel.Hide();
                    ModifyAccount.Hide();
                    AddBalancePanel.Show();
                    break;
            }
        }
        private void ModifyAccountBTN_Click(object sender, EventArgs e)
        {
            AccountSettingPanel(1);
        }


        private void ModifyaccountInfoBTN_Click(object sender, EventArgs e)
        {
            AccountSettingPanel(2);
        }
        private void sqlname()
        {
            if (!String.IsNullOrEmpty(UsernameInput.Text) && !String.IsNullOrEmpty(PasswordInput.Text))
            {
                if (ToFindUserNamesql(UsernameInput.Text))
                {
                    string sql = "UPDATE Doctors SET FirstName = @FirstName ,LastName = @LastName WHERE DoctorID = @DoctorID";
                    try
                    {
                        using (SqlConnection con = new SqlConnection(sqlcon))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstnamebox.Text;
                                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastnamebox.Text;
                                cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                                cmd.ExecuteNonQuery();
                            }
                            con.Close();
                            MessageBox.Show("User's Fullname have Updated");
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
                else if (!ToFindUserNamesql(UsernameInput.Text))
                {
                    MessageBox.Show("Please input another username. The username is already taken.");
                }
            }
            else
            {
                MessageBox.Show("Please input another username & Password");
            }
        }
        private void sqlphone()
        {
            string sql = "UPDATE Doctors SET PhoneNum = @PhoneNum WHERE DoctorID = @DoctorID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@PhoneNum", SqlDbType.NVarChar).Value = PhoneNumberBox.Text;
                    cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Phone Number have Updated");
            }


        }

        private void sqlemail()
        {
            string sql = "UPDATE Doctors SET Email = @Email WHERE DoctorID = @DoctorID";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = EmailBox.Text;
                    cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("User's Email have Updated");
            }
        }
        private void ChangeNameBTN_Click(object sender, EventArgs e)
        {
            if (firstnamebox.Text.Length > 0 && lastnamebox.Text.Length > 0)
            {
                sqlname();
            }
            else
            {
                MessageBox.Show("Didnt not meet the requirments");
            }
        }

        private void ChangeEmailBTN_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text.Length > 0)
            {
                sqlemail();
            }
            else
            {
                MessageBox.Show("Didnt not meet the requirments");
            }
        }

        private void ChangePhoneNumBTN_Click(object sender, EventArgs e)
        {
            if (PhoneNumberBox.Text.Length > 0)
            {
                sqlphone();
            }
            else
            {
                MessageBox.Show("Didnt not meet the requirments");
            }
        }
        private void ChangePasswordSQL()
        {
            string sql = "UPDATE FROM Users SET Password = @Password WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordInput.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Users Password Changed");
            }
        }
        private void ChangeUsernameSQL()
        {
            string sql = "UPDATE Users SET Username = @Username WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UsernameInput.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Users Username Changed");
            }
        }


        private void changeuserpass()
        {
            string sql = "UPDATE Users SET Username = @Username, Password = @Password WHERE UserID = @UserID";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UsernameInput.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordInput.Text;
                    cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = UserID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Users Username & Password Changed");
            }
        }
        private void ModifyingAccountBTN_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text.Length > 0 && PasswordInput.Text.Length > 0)
            {
                changeuserpass();
                DisplayUserInfo();
            }
            else if (UsernameInput.Text.Length > 0 && PasswordInput.Text.Length == 0)
            {
                ChangeUsernameSQL();
                DisplayUserInfo();
            }
            else if (UsernameInput.Text.Length == 0 && PasswordInput.Text.Length > 0)
            {
                ChangePasswordSQL();
                DisplayUserInfo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountSettingPanel(3);
        }
        private bool CheckBalanceInput()
        {

            if (PatientDepositInput.Text.Length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool CheckBalanceWithdrawalInput()
        {

            if (PatientWithdrawalInput.Text.Length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ConfirmationMesssageBox()
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }

            return false;
        }

        private void checkUserBalance()
        {

            string sql = "SELECT TotalAmount FROM DoctorBalance WHERE DoctorID = @DoctorID";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = UserID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userBalance = int.Parse(reader["TotalAmount"].ToString());
                            DoctorBalance.Text = userBalance.ToString();

                        }
                    }
                }
                con.Close();
            }
        }
        private void AddBalanceDepositBTN_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE DoctorBalance SET TotalAmount = @Balance WHERE DoctorID = @DoctorID;";
            string sql1 = "INSERT INTO PaymentHistory (UserID,DATE,PaymentType,AMOUNT) VALUES (@UserID,@DATE,@PaymentType,@AMOUNT)";
            if (CheckBalanceInput())
            {
                if (ConfirmationMesssageBox())
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(sqlcon))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = UserID;
                                cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = userBalance + int.Parse(PatientDepositInput.Text);
                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cmd = new SqlCommand(sql1, con))
                            {
                                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                                cmd.Parameters.Add("@DATE", SqlDbType.Date).Value = DateTime.Now;
                                cmd.Parameters.Add("@PaymentType", SqlDbType.NVarChar).Value = "DEPOSIT";
                                cmd.Parameters.Add("@AMOUNT", SqlDbType.Int).Value = int.Parse(PatientDepositInput.Text);
                                cmd.ExecuteNonQuery();
                            }

                            con.Close();
                            checkUserBalance();
                            MessageBox.Show("The Balance is added");

                        }


                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("" + aa);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Must Input Desired Number in the Deposit Box");
            }
        }


        private void AddBalanceWithdrawalBTN_Click_1(object sender, EventArgs e)
        {
            string sql = "UPDATE DoctorBalance SET TotalAmount = @Balance WHERE DoctorID = @DoctorID;";
            string sql1 = "INSERT INTO PaymentHistory (UserID,DATE,PaymentType,AMOUNT) VALUES (@UserID,@DATE,@PaymentType,@AMOUNT)";
            if (CheckBalanceWithdrawalInput())
            {
                if (ConfirmationMesssageBox())
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(sqlcon))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                                cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = userBalance - int.Parse(PatientWithdrawalInput.Text);
                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cmd = new SqlCommand(sql1, con))
                            {
                                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = DoctorID;
                                cmd.Parameters.Add("@DATE", SqlDbType.Date).Value = DateTime.Now;
                                cmd.Parameters.Add("@PaymentType", SqlDbType.NVarChar).Value = "DEPOSIT";
                                cmd.Parameters.Add("@AMOUNT", SqlDbType.Int).Value = int.Parse(PatientWithdrawalInput.Text);
                                cmd.ExecuteNonQuery();
                            }
                            con.Close();
                            checkUserBalance();
                            MessageBox.Show("The Balance is Deducted");

                        }


                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("" + aa);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Must Input Desired Number in the Deposit Box");
            }
        }

        private void ModifyFeeBTN_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE DoctorSpecialization SET CostPerDoctor = @CostPerDoctor WHERE DoctorID = @DoctorID";
            try
            {
                if (int.Parse(UpdateFeeBox.Text) > 1)
                {
                    using (SqlConnection con = new SqlConnection(sqlcon))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DoctorID;
                            cmd.Parameters.Add("@CostPerDoctor", SqlDbType.Int).Value = int.Parse(UpdateFeeBox.Text);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    checkCostPerDoctorFee();
                    MessageBox.Show("The Fee is Updated");
                }
                else
                {
                    MessageBox.Show("Please set a value to the box. Thank you");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void UpdateFeeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateFeeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void SettingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
