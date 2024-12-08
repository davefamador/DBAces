namespace DBAces
{
    partial class DoctorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorUI));
            Appointment = new Panel();
            NextCalendarBtn = new Button();
            PrevCalendarBtn = new Button();
            MonthsName = new Label();
            CalendarLayoutPanel = new FlowLayoutPanel();
            Top_Bar = new Panel();
            LogoutBTN = new Button();
            DashboardPanelBTN = new Button();
            SettingPanelBTN = new Button();
            HistorySalePanelBTN = new Button();
            AppointmentBTN = new Button();
            Setting = new Panel();
            DoctorsIDLABEL = new Label();
            label6 = new Label();
            Dashboard = new Panel();
            DashboardPatient = new Panel();
            LoadPatientDiagnosis = new FlowLayoutPanel();
            DashboardTopBar = new Panel();
            OnAppointmentDashboard = new Button();
            DiagnosPatient = new Button();
            OnAppointmentPanel = new Panel();
            GetAppointmentDoctor = new FlowLayoutPanel();
            HistorySale = new Panel();
            label5 = new Label();
            Appointment.SuspendLayout();
            Top_Bar.SuspendLayout();
            Setting.SuspendLayout();
            Dashboard.SuspendLayout();
            DashboardPatient.SuspendLayout();
            DashboardTopBar.SuspendLayout();
            OnAppointmentPanel.SuspendLayout();
            HistorySale.SuspendLayout();
            SuspendLayout();
            // 
            // Appointment
            // 
            Appointment.AutoScroll = true;
            Appointment.BackColor = Color.FromArgb(78, 159, 61);
            Appointment.Controls.Add(NextCalendarBtn);
            Appointment.Controls.Add(PrevCalendarBtn);
            Appointment.Controls.Add(MonthsName);
            Appointment.Controls.Add(CalendarLayoutPanel);
            Appointment.Location = new Point(0, 75);
            Appointment.Name = "Appointment";
            Appointment.Size = new Size(778, 556);
            Appointment.TabIndex = 11;
            // 
            // NextCalendarBtn
            // 
            NextCalendarBtn.Location = new Point(665, 16);
            NextCalendarBtn.Name = "NextCalendarBtn";
            NextCalendarBtn.Size = new Size(75, 23);
            NextCalendarBtn.TabIndex = 3;
            NextCalendarBtn.Text = "Next";
            NextCalendarBtn.UseVisualStyleBackColor = true;
            NextCalendarBtn.Click += NextCalendarBtn_Click;
            // 
            // PrevCalendarBtn
            // 
            PrevCalendarBtn.Location = new Point(12, 16);
            PrevCalendarBtn.Name = "PrevCalendarBtn";
            PrevCalendarBtn.Size = new Size(75, 23);
            PrevCalendarBtn.TabIndex = 2;
            PrevCalendarBtn.Text = "Prev";
            PrevCalendarBtn.UseVisualStyleBackColor = true;
            PrevCalendarBtn.Click += PrevCalendarBtn_Click;
            // 
            // MonthsName
            // 
            MonthsName.AutoSize = true;
            MonthsName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MonthsName.ForeColor = SystemColors.Control;
            MonthsName.Location = new Point(302, 18);
            MonthsName.Name = "MonthsName";
            MonthsName.Size = new Size(158, 21);
            MonthsName.TabIndex = 1;
            MonthsName.Text = "New Appointments";
            // 
            // CalendarLayoutPanel
            // 
            CalendarLayoutPanel.BackColor = Color.FromArgb(192, 255, 192);
            CalendarLayoutPanel.Location = new Point(12, 42);
            CalendarLayoutPanel.Name = "CalendarLayoutPanel";
            CalendarLayoutPanel.Size = new Size(754, 502);
            CalendarLayoutPanel.TabIndex = 0;
            // 
            // Top_Bar
            // 
            Top_Bar.BackColor = Color.FromArgb(30, 81, 40);
            Top_Bar.Controls.Add(LogoutBTN);
            Top_Bar.Controls.Add(DashboardPanelBTN);
            Top_Bar.Controls.Add(SettingPanelBTN);
            Top_Bar.Controls.Add(HistorySalePanelBTN);
            Top_Bar.Dock = DockStyle.Top;
            Top_Bar.Location = new Point(0, 0);
            Top_Bar.Name = "Top_Bar";
            Top_Bar.Size = new Size(778, 75);
            Top_Bar.TabIndex = 12;
            Top_Bar.Paint += Top_Bar_Paint;
            // 
            // LogoutBTN
            // 
            LogoutBTN.BackColor = Color.Transparent;
            LogoutBTN.BackgroundImage = (Image)resources.GetObject("LogoutBTN.BackgroundImage");
            LogoutBTN.BackgroundImageLayout = ImageLayout.Stretch;
            LogoutBTN.FlatAppearance.BorderSize = 0;
            LogoutBTN.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            LogoutBTN.ForeColor = Color.Black;
            LogoutBTN.Location = new Point(739, 3);
            LogoutBTN.Name = "LogoutBTN";
            LogoutBTN.Size = new Size(36, 30);
            LogoutBTN.TabIndex = 14;
            LogoutBTN.UseVisualStyleBackColor = false;
            LogoutBTN.Click += LogoutBTN_Click;
            // 
            // DashboardPanelBTN
            // 
            DashboardPanelBTN.BackColor = Color.Transparent;
            DashboardPanelBTN.FlatAppearance.BorderSize = 0;
            DashboardPanelBTN.FlatStyle = FlatStyle.Flat;
            DashboardPanelBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardPanelBTN.ForeColor = SystemColors.Control;
            DashboardPanelBTN.Location = new Point(29, 22);
            DashboardPanelBTN.Name = "DashboardPanelBTN";
            DashboardPanelBTN.Size = new Size(132, 37);
            DashboardPanelBTN.TabIndex = 13;
            DashboardPanelBTN.Text = "Dashboard";
            DashboardPanelBTN.UseVisualStyleBackColor = false;
            DashboardPanelBTN.Click += DashboardPanelBTN_Click;
            // 
            // SettingPanelBTN
            // 
            SettingPanelBTN.BackColor = Color.Transparent;
            SettingPanelBTN.FlatAppearance.BorderSize = 0;
            SettingPanelBTN.FlatStyle = FlatStyle.Flat;
            SettingPanelBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingPanelBTN.ForeColor = SystemColors.Control;
            SettingPanelBTN.Location = new Point(623, 12);
            SettingPanelBTN.Name = "SettingPanelBTN";
            SettingPanelBTN.Size = new Size(143, 47);
            SettingPanelBTN.TabIndex = 12;
            SettingPanelBTN.Text = "Settings";
            SettingPanelBTN.UseVisualStyleBackColor = false;
            SettingPanelBTN.Click += SettingPanelBTN_Click;
            // 
            // HistorySalePanelBTN
            // 
            HistorySalePanelBTN.BackColor = Color.Transparent;
            HistorySalePanelBTN.FlatAppearance.BorderSize = 0;
            HistorySalePanelBTN.FlatStyle = FlatStyle.Flat;
            HistorySalePanelBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HistorySalePanelBTN.ForeColor = SystemColors.Control;
            HistorySalePanelBTN.Location = new Point(206, 22);
            HistorySalePanelBTN.Name = "HistorySalePanelBTN";
            HistorySalePanelBTN.Size = new Size(132, 37);
            HistorySalePanelBTN.TabIndex = 11;
            HistorySalePanelBTN.Text = "History / Sales";
            HistorySalePanelBTN.UseVisualStyleBackColor = false;
            HistorySalePanelBTN.Click += HistorySalePanelBTN_Click;
            // 
            // AppointmentBTN
            // 
            AppointmentBTN.BackColor = Color.FromArgb(0, 64, 0);
            AppointmentBTN.FlatAppearance.BorderSize = 0;
            AppointmentBTN.FlatStyle = FlatStyle.Flat;
            AppointmentBTN.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            AppointmentBTN.ForeColor = Color.White;
            AppointmentBTN.Location = new Point(29, 18);
            AppointmentBTN.Name = "AppointmentBTN";
            AppointmentBTN.Size = new Size(97, 40);
            AppointmentBTN.TabIndex = 10;
            AppointmentBTN.Text = "New Appointment";
            AppointmentBTN.UseVisualStyleBackColor = false;
            AppointmentBTN.Click += AppointmentBTN_Click;
            // 
            // Setting
            // 
            Setting.Controls.Add(DoctorsIDLABEL);
            Setting.Controls.Add(label6);
            Setting.Dock = DockStyle.Fill;
            Setting.Location = new Point(0, 75);
            Setting.Name = "Setting";
            Setting.Size = new Size(778, 556);
            Setting.TabIndex = 13;
            // 
            // DoctorsIDLABEL
            // 
            DoctorsIDLABEL.AutoSize = true;
            DoctorsIDLABEL.Location = new Point(281, 275);
            DoctorsIDLABEL.Name = "DoctorsIDLABEL";
            DoctorsIDLABEL.Size = new Size(38, 15);
            DoctorsIDLABEL.TabIndex = 2;
            DoctorsIDLABEL.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(166, 16);
            label6.Name = "label6";
            label6.Size = new Size(192, 65);
            label6.TabIndex = 1;
            label6.Text = "Setting";
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(192, 255, 192);
            Dashboard.Controls.Add(DashboardPatient);
            Dashboard.Controls.Add(DashboardTopBar);
            Dashboard.Controls.Add(OnAppointmentPanel);
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.Location = new Point(0, 75);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(778, 556);
            Dashboard.TabIndex = 0;
            // 
            // DashboardPatient
            // 
            DashboardPatient.Controls.Add(LoadPatientDiagnosis);
            DashboardPatient.Dock = DockStyle.Fill;
            DashboardPatient.Location = new Point(0, 75);
            DashboardPatient.Name = "DashboardPatient";
            DashboardPatient.Size = new Size(778, 481);
            DashboardPatient.TabIndex = 0;
            // 
            // LoadPatientDiagnosis
            // 
            LoadPatientDiagnosis.AutoScroll = true;
            LoadPatientDiagnosis.Location = new Point(17, 18);
            LoadPatientDiagnosis.Name = "LoadPatientDiagnosis";
            LoadPatientDiagnosis.Size = new Size(734, 437);
            LoadPatientDiagnosis.TabIndex = 0;
            LoadPatientDiagnosis.Paint += LoadPatientDiagnosis_Paint;
            // 
            // DashboardTopBar
            // 
            DashboardTopBar.Controls.Add(OnAppointmentDashboard);
            DashboardTopBar.Controls.Add(DiagnosPatient);
            DashboardTopBar.Controls.Add(AppointmentBTN);
            DashboardTopBar.Dock = DockStyle.Top;
            DashboardTopBar.Location = new Point(0, 0);
            DashboardTopBar.Name = "DashboardTopBar";
            DashboardTopBar.Size = new Size(778, 75);
            DashboardTopBar.TabIndex = 12;
            // 
            // OnAppointmentDashboard
            // 
            OnAppointmentDashboard.BackColor = Color.FromArgb(0, 64, 0);
            OnAppointmentDashboard.FlatStyle = FlatStyle.Flat;
            OnAppointmentDashboard.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            OnAppointmentDashboard.ForeColor = Color.White;
            OnAppointmentDashboard.Location = new Point(132, 18);
            OnAppointmentDashboard.Name = "OnAppointmentDashboard";
            OnAppointmentDashboard.Size = new Size(85, 42);
            OnAppointmentDashboard.TabIndex = 11;
            OnAppointmentDashboard.Text = "On Appointment";
            OnAppointmentDashboard.UseVisualStyleBackColor = false;
            OnAppointmentDashboard.Click += OnAppointmentDashboard_Click;
            // 
            // DiagnosPatient
            // 
            DiagnosPatient.BackColor = Color.FromArgb(0, 64, 0);
            DiagnosPatient.FlatStyle = FlatStyle.Flat;
            DiagnosPatient.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            DiagnosPatient.ForeColor = Color.White;
            DiagnosPatient.Location = new Point(226, 16);
            DiagnosPatient.Name = "DiagnosPatient";
            DiagnosPatient.Size = new Size(94, 42);
            DiagnosPatient.TabIndex = 2;
            DiagnosPatient.Text = "Patient";
            DiagnosPatient.UseVisualStyleBackColor = false;
            DiagnosPatient.Click += DiagnosPatient_Click;
            // 
            // OnAppointmentPanel
            // 
            OnAppointmentPanel.Controls.Add(GetAppointmentDoctor);
            OnAppointmentPanel.Dock = DockStyle.Fill;
            OnAppointmentPanel.Location = new Point(0, 0);
            OnAppointmentPanel.Name = "OnAppointmentPanel";
            OnAppointmentPanel.Size = new Size(778, 556);
            OnAppointmentPanel.TabIndex = 1;
            // 
            // GetAppointmentDoctor
            // 
            GetAppointmentDoctor.AutoScroll = true;
            GetAppointmentDoctor.Location = new Point(17, 18);
            GetAppointmentDoctor.Name = "GetAppointmentDoctor";
            GetAppointmentDoctor.Size = new Size(734, 437);
            GetAppointmentDoctor.TabIndex = 0;
            // 
            // HistorySale
            // 
            HistorySale.Controls.Add(label5);
            HistorySale.Dock = DockStyle.Fill;
            HistorySale.Location = new Point(0, 75);
            HistorySale.Name = "HistorySale";
            HistorySale.Size = new Size(778, 556);
            HistorySale.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(258, 128);
            label5.Name = "label5";
            label5.Size = new Size(301, 65);
            label5.TabIndex = 0;
            label5.Text = "History Sale";
            // 
            // DoctorUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 631);
            Controls.Add(Dashboard);
            Controls.Add(Appointment);
            Controls.Add(Setting);
            Controls.Add(HistorySale);
            Controls.Add(Top_Bar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DoctorUI";
            Text = "DoctorUI";
            Load += DoctorUI_Load;
            Appointment.ResumeLayout(false);
            Appointment.PerformLayout();
            Top_Bar.ResumeLayout(false);
            Setting.ResumeLayout(false);
            Setting.PerformLayout();
            Dashboard.ResumeLayout(false);
            DashboardPatient.ResumeLayout(false);
            DashboardTopBar.ResumeLayout(false);
            OnAppointmentPanel.ResumeLayout(false);
            HistorySale.ResumeLayout(false);
            HistorySale.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Appointment;
        private Panel Top_Bar;
        private Panel Setting;
        private Button SettingPanelBTN;
        private Button HistorySalePanelBTN;
        private Button AppointmentBTN;
        private Button DashboardPanelBTN;
        private Panel Dashboard;
        private Panel HistorySale;
        private Label label6;
        private Label label5;
        private FlowLayoutPanel CalendarLayoutPanel;
        private Label MonthsName;
        private Button PrevCalendarBtn;
        private Button NextCalendarBtn;
        private RadioButton radioButton32;
        private RadioButton radioButton33;
        private RadioButton radioButton34;
        private RadioButton radioButton35;
        private RadioButton radioButton21;
        private RadioButton radioButton36;
        private RadioButton radioButton37;
        private RadioButton radioButton38;
        private RadioButton radioButton40;
        private RadioButton radioButton41;
        private RadioButton radioButton22;
        private RadioButton radioButton23;
        private RadioButton radioButton24;
        private RadioButton radioButton25;
        private RadioButton radioButton26;
        private RadioButton radioButton27;
        private RadioButton radioButton28;
        private RadioButton radioButton29;
        private RadioButton radioButton30;
        private RadioButton radioButton31;
        private RadioButton radioButton1;
        private RadioButton radioButton44;
        private RadioButton radioButton45;
        private RadioButton radioButton46;
        private RadioButton radioButton47;
        private RadioButton radioButton43;
        private RadioButton radioButton42;
        private RadioButton SpecificTimeRadioBtn;
        private FlowLayoutPanel LoadPatientDiagnosis;
        private Panel DashboardPatient;
        private Button DiagnosPatient;
        private Panel panel1;
        private FlowLayoutPanel GetAppointmentDoctor;
        private Label label1;
        private Button OnAppointmentDashboard;
        private Panel DashboardTopBar;
        private Panel OnAppointmentPanel;
        private Button LogoutBTN;
        private Label DoctorsIDLABEL;
    }
}