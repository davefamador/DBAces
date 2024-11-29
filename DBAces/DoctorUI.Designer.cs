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
            label1 = new Label();
            DoctorID = new Label();
            label3 = new Label();
            UserDoctorSpecializationLabel = new Label();
            label2 = new Label();
            DoctorPhoneNumberLabel = new Label();
            label100 = new Label();
            DoctorEmailLabel = new Label();
            label4 = new Label();
            Appointment = new Panel();
            NextCalendarBtn = new Button();
            PrevCalendarBtn = new Button();
            MonthsName = new Label();
            CalendarLayoutPanel = new FlowLayoutPanel();
            Top_Bar = new Panel();
            DashboardPanelBTN = new Button();
            SettingPanelBTN = new Button();
            HistorySalePanelBTN = new Button();
            AppointmentBTN = new Button();
            Setting = new Panel();
            label6 = new Label();
            Dashboard = new Panel();
            DoctorSpecializationLabel = new Label();
            HistorySale = new Panel();
            label5 = new Label();
            Appointment.SuspendLayout();
            Top_Bar.SuspendLayout();
            Setting.SuspendLayout();
            Dashboard.SuspendLayout();
            HistorySale.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR ID";
            // 
            // DoctorID
            // 
            DoctorID.AutoSize = true;
            DoctorID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorID.Location = new Point(196, 14);
            DoctorID.Name = "DoctorID";
            DoctorID.Size = new Size(113, 37);
            DoctorID.TabIndex = 1;
            DoctorID.Text = "123123";
            DoctorID.Click += DoctorID_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 91);
            label3.Name = "label3";
            label3.Size = new Size(189, 37);
            label3.TabIndex = 3;
            label3.Text = "Doctor Name";
            // 
            // UserDoctorSpecializationLabel
            // 
            UserDoctorSpecializationLabel.AutoSize = true;
            UserDoctorSpecializationLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserDoctorSpecializationLabel.Location = new Point(65, 128);
            UserDoctorSpecializationLabel.Name = "UserDoctorSpecializationLabel";
            UserDoctorSpecializationLabel.Size = new Size(132, 37);
            UserDoctorSpecializationLabel.TabIndex = 4;
            UserDoctorSpecializationLabel.Text = "asdasdas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 206);
            label2.Name = "label2";
            label2.Size = new Size(196, 37);
            label2.TabIndex = 5;
            label2.Text = "Specialization";
            // 
            // DoctorPhoneNumberLabel
            // 
            DoctorPhoneNumberLabel.AutoSize = true;
            DoctorPhoneNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorPhoneNumberLabel.Location = new Point(430, 128);
            DoctorPhoneNumberLabel.Name = "DoctorPhoneNumberLabel";
            DoctorPhoneNumberLabel.Size = new Size(132, 37);
            DoctorPhoneNumberLabel.TabIndex = 6;
            DoctorPhoneNumberLabel.Text = "asdasdas";
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label100.Location = new Point(394, 91);
            label100.Name = "label100";
            label100.Size = new Size(210, 37);
            label100.TabIndex = 7;
            label100.Text = "Phone Number";
            // 
            // DoctorEmailLabel
            // 
            DoctorEmailLabel.AutoSize = true;
            DoctorEmailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorEmailLabel.Location = new Point(453, 278);
            DoctorEmailLabel.Name = "DoctorEmailLabel";
            DoctorEmailLabel.Size = new Size(132, 37);
            DoctorEmailLabel.TabIndex = 8;
            DoctorEmailLabel.Text = "asdasdas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(466, 219);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // Appointment
            // 
            Appointment.AutoScroll = true;
            Appointment.BackColor = Color.FromArgb(78, 159, 61);
            Appointment.Controls.Add(NextCalendarBtn);
            Appointment.Controls.Add(PrevCalendarBtn);
            Appointment.Controls.Add(MonthsName);
            Appointment.Controls.Add(CalendarLayoutPanel);
            Appointment.Dock = DockStyle.Fill;
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
            Top_Bar.Controls.Add(DashboardPanelBTN);
            Top_Bar.Controls.Add(SettingPanelBTN);
            Top_Bar.Controls.Add(HistorySalePanelBTN);
            Top_Bar.Controls.Add(AppointmentBTN);
            Top_Bar.Dock = DockStyle.Top;
            Top_Bar.Location = new Point(0, 0);
            Top_Bar.Name = "Top_Bar";
            Top_Bar.Size = new Size(778, 75);
            Top_Bar.TabIndex = 12;
            Top_Bar.Paint += Top_Bar_Paint;
            // 
            // DashboardPanelBTN
            // 
            DashboardPanelBTN.BackColor = Color.Transparent;
            DashboardPanelBTN.FlatAppearance.BorderSize = 0;
            DashboardPanelBTN.FlatStyle = FlatStyle.Flat;
            DashboardPanelBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardPanelBTN.ForeColor = SystemColors.Control;
            DashboardPanelBTN.Location = new Point(27, 22);
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
            SettingPanelBTN.Location = new Point(597, 12);
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
            HistorySalePanelBTN.Location = new Point(338, 22);
            HistorySalePanelBTN.Name = "HistorySalePanelBTN";
            HistorySalePanelBTN.Size = new Size(132, 37);
            HistorySalePanelBTN.TabIndex = 11;
            HistorySalePanelBTN.Text = "History / Sales";
            HistorySalePanelBTN.UseVisualStyleBackColor = false;
            HistorySalePanelBTN.Click += HistorySalePanelBTN_Click;
            // 
            // AppointmentBTN
            // 
            AppointmentBTN.BackColor = Color.Transparent;
            AppointmentBTN.FlatAppearance.BorderSize = 0;
            AppointmentBTN.FlatStyle = FlatStyle.Flat;
            AppointmentBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentBTN.ForeColor = SystemColors.Control;
            AppointmentBTN.Location = new Point(182, 22);
            AppointmentBTN.Name = "AppointmentBTN";
            AppointmentBTN.Size = new Size(132, 37);
            AppointmentBTN.TabIndex = 10;
            AppointmentBTN.Text = "Appointments";
            AppointmentBTN.UseVisualStyleBackColor = false;
            AppointmentBTN.Click += AppointmentBTN_Click;
            // 
            // Setting
            // 
            Setting.Controls.Add(label6);
            Setting.Dock = DockStyle.Fill;
            Setting.Location = new Point(0, 0);
            Setting.Name = "Setting";
            Setting.Size = new Size(778, 631);
            Setting.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(226, 193);
            label6.Name = "label6";
            label6.Size = new Size(192, 65);
            label6.TabIndex = 1;
            label6.Text = "Setting";
            // 
            // Dashboard
            // 
            Dashboard.Controls.Add(DoctorSpecializationLabel);
            Dashboard.Controls.Add(UserDoctorSpecializationLabel);
            Dashboard.Controls.Add(label1);
            Dashboard.Controls.Add(DoctorID);
            Dashboard.Controls.Add(label3);
            Dashboard.Controls.Add(label2);
            Dashboard.Controls.Add(DoctorPhoneNumberLabel);
            Dashboard.Controls.Add(label100);
            Dashboard.Controls.Add(DoctorEmailLabel);
            Dashboard.Controls.Add(label4);
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.Location = new Point(0, 75);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(778, 556);
            Dashboard.TabIndex = 0;
            // 
            // DoctorSpecializationLabel
            // 
            DoctorSpecializationLabel.AutoSize = true;
            DoctorSpecializationLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorSpecializationLabel.Location = new Point(92, 243);
            DoctorSpecializationLabel.Name = "DoctorSpecializationLabel";
            DoctorSpecializationLabel.Size = new Size(292, 37);
            DoctorSpecializationLabel.TabIndex = 10;
            DoctorSpecializationLabel.Text = "Doctor Specialization";
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
            Controls.Add(Appointment);
            Controls.Add(Dashboard);
            Controls.Add(HistorySale);
            Controls.Add(Top_Bar);
            Controls.Add(Setting);
            Name = "DoctorUI";
            Text = "DoctorUI";
            Load += DoctorUI_Load;
            Appointment.ResumeLayout(false);
            Appointment.PerformLayout();
            Top_Bar.ResumeLayout(false);
            Setting.ResumeLayout(false);
            Setting.PerformLayout();
            Dashboard.ResumeLayout(false);
            Dashboard.PerformLayout();
            HistorySale.ResumeLayout(false);
            HistorySale.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label DoctorID;
        private Label label3;
        private Label UserDoctorSpecializationLabel;
        private Label label2;
        private Label DoctorPhoneNumberLabel;
        private Label label100;
        private Label DoctorEmailLabel;
        private Label label4;
        private Panel Appointment;
        private Panel Top_Bar;
        private Panel Setting;
        private Button SettingPanelBTN;
        private Button HistorySalePanelBTN;
        private Button AppointmentBTN;
        private Button DashboardPanelBTN;
        private Panel Dashboard;
        private Label DoctorSpecializationLabel;
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
    }
}