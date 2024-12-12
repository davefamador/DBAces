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
            Label FeeLabel;
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
            SettingPanel = new Panel();
            label24 = new Label();
            panel4 = new Panel();
            label21 = new Label();
            UpdateFeeBox = new TextBox();
            label23 = new Label();
            ModifyFeeBTN = new Button();
            label20 = new Label();
            DoctorSpecialistLabel = new Label();
            label22 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            DoctorBalance = new Label();
            label17 = new Label();
            AccountUserIDsLabel = new Label();
            panel2 = new Panel();
            UsersEmailLabel = new Label();
            userPhone = new Label();
            userFirstName = new Label();
            userLastname = new Label();
            label9 = new Label();
            label10 = new Label();
            ModifyaccountInfoBTN = new Button();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            ModifyAccountBTN = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ModifyAccount = new Panel();
            ModifyingAccountBTN = new Button();
            label16 = new Label();
            label15 = new Label();
            PasswordInput = new TextBox();
            UsernameInput = new TextBox();
            ModifyBackground = new Panel();
            lastnamebox = new TextBox();
            firstnamebox = new TextBox();
            PhoneNumberBox = new TextBox();
            EmailBox = new TextBox();
            ChangePhoneNumBTN = new Button();
            ChangeEmailBTN = new Button();
            ChangeNameBTN = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            AddBalancePanel = new Panel();
            AddBalanceWithdrawalBTN = new Button();
            label18 = new Label();
            PatientWithdrawalInput = new TextBox();
            AddBalanceDepositBTN = new Button();
            label19 = new Label();
            PatientDepositInput = new TextBox();
            label6 = new Label();
            Dashboard = new Panel();
            DashboardPatient = new Panel();
            PatientsPanel = new Panel();
            LoadPatientDiagnosis = new FlowLayoutPanel();
            OnAppointmentPanel = new Panel();
            GetAppointmentDoctor = new FlowLayoutPanel();
            DashboardTopBar = new Panel();
            OnAppointmentDashboard = new Button();
            DiagnosPatient = new Button();
            HistorySale = new Panel();
            DoctorHistoryFlowPanel = new FlowLayoutPanel();
            label5 = new Label();
            FeeLabel = new Label();
            Appointment.SuspendLayout();
            Top_Bar.SuspendLayout();
            Setting.SuspendLayout();
            SettingPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ModifyAccount.SuspendLayout();
            ModifyBackground.SuspendLayout();
            AddBalancePanel.SuspendLayout();
            Dashboard.SuspendLayout();
            DashboardPatient.SuspendLayout();
            PatientsPanel.SuspendLayout();
            OnAppointmentPanel.SuspendLayout();
            DashboardTopBar.SuspendLayout();
            HistorySale.SuspendLayout();
            SuspendLayout();
            // 
            // FeeLabel
            // 
            FeeLabel.AutoSize = true;
            FeeLabel.Font = new Font("Segoe UI", 15F);
            FeeLabel.Location = new Point(273, 10);
            FeeLabel.Name = "FeeLabel";
            FeeLabel.Size = new Size(42, 28);
            FeeLabel.TabIndex = 6;
            FeeLabel.Text = "FEE";
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
            LogoutBTN.Location = new Point(0, 0);
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
            Setting.Controls.Add(AddBalancePanel);
            Setting.Controls.Add(SettingPanel);
            Setting.Controls.Add(ModifyAccount);
            Setting.Controls.Add(ModifyBackground);
            Setting.Controls.Add(label6);
            Setting.Dock = DockStyle.Fill;
            Setting.Location = new Point(0, 75);
            Setting.Name = "Setting";
            Setting.Size = new Size(778, 556);
            Setting.TabIndex = 13;
            // 
            // SettingPanel
            // 
            SettingPanel.BackColor = Color.FromArgb(192, 255, 192);
            SettingPanel.Controls.Add(label24);
            SettingPanel.Controls.Add(panel4);
            SettingPanel.Controls.Add(panel3);
            SettingPanel.Controls.Add(AccountUserIDsLabel);
            SettingPanel.Controls.Add(panel2);
            SettingPanel.Controls.Add(panel1);
            SettingPanel.Dock = DockStyle.Fill;
            SettingPanel.Location = new Point(0, 0);
            SettingPanel.Name = "SettingPanel";
            SettingPanel.Size = new Size(778, 556);
            SettingPanel.TabIndex = 0;
            SettingPanel.Paint += SettingPanel_Paint;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(665, 3);
            label24.Name = "label24";
            label24.Size = new Size(86, 30);
            label24.TabIndex = 10;
            label24.Text = "UserIDs";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSeaGreen;
            panel4.Controls.Add(label21);
            panel4.Controls.Add(UpdateFeeBox);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(FeeLabel);
            panel4.Controls.Add(ModifyFeeBTN);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(DoctorSpecialistLabel);
            panel4.Controls.Add(label22);
            panel4.Location = new Point(29, 417);
            panel4.Name = "panel4";
            panel4.Size = new Size(739, 99);
            panel4.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label21.Location = new Point(404, 23);
            label21.Name = "label21";
            label21.Size = new Size(88, 17);
            label21.TabIndex = 9;
            label21.Text = "SET NEW FEE";
            // 
            // UpdateFeeBox
            // 
            UpdateFeeBox.Location = new Point(385, 43);
            UpdateFeeBox.Name = "UpdateFeeBox";
            UpdateFeeBox.Size = new Size(132, 23);
            UpdateFeeBox.TabIndex = 8;
            UpdateFeeBox.TextChanged += UpdateFeeBox_TextChanged;
            UpdateFeeBox.KeyPress += UpdateFeeBox_KeyPress;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 15F);
            label23.Location = new Point(273, 40);
            label23.Name = "label23";
            label23.Size = new Size(42, 28);
            label23.TabIndex = 7;
            label23.Text = "FEE";
            // 
            // ModifyFeeBTN
            // 
            ModifyFeeBTN.BackColor = Color.FromArgb(192, 255, 192);
            ModifyFeeBTN.Location = new Point(527, 36);
            ModifyFeeBTN.Name = "ModifyFeeBTN";
            ModifyFeeBTN.Size = new Size(94, 30);
            ModifyFeeBTN.TabIndex = 5;
            ModifyFeeBTN.Text = "UPDATE FEE";
            ModifyFeeBTN.UseVisualStyleBackColor = false;
            ModifyFeeBTN.Click += ModifyFeeBTN_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(14, 10);
            label20.Name = "label20";
            label20.Size = new Size(101, 30);
            label20.TabIndex = 4;
            label20.Text = "Specialist";
            // 
            // DoctorSpecialistLabel
            // 
            DoctorSpecialistLabel.AutoSize = true;
            DoctorSpecialistLabel.Font = new Font("Segoe UI", 15F);
            DoctorSpecialistLabel.Location = new Point(62, 40);
            DoctorSpecialistLabel.Name = "DoctorSpecialistLabel";
            DoctorSpecialistLabel.Size = new Size(140, 28);
            DoctorSpecialistLabel.TabIndex = 2;
            DoctorSpecialistLabel.Text = "SpecialistLabel";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(14, 113);
            label22.Name = "label22";
            label22.Size = new Size(59, 21);
            label22.TabIndex = 3;
            label22.Text = "*******";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(DoctorBalance);
            panel3.Controls.Add(label17);
            panel3.Location = new Point(65, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 109);
            panel3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(318, 22);
            button1.Name = "button1";
            button1.Size = new Size(123, 56);
            button1.TabIndex = 6;
            button1.Text = "BALANCE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DoctorBalance
            // 
            DoctorBalance.AutoSize = true;
            DoctorBalance.Font = new Font("Segoe UI", 12F);
            DoctorBalance.Location = new Point(131, 38);
            DoctorBalance.Name = "DoctorBalance";
            DoctorBalance.Size = new Size(114, 21);
            DoctorBalance.TabIndex = 6;
            DoctorBalance.Text = "Doctor Balance";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(21, 31);
            label17.Name = "label17";
            label17.Size = new Size(86, 30);
            label17.TabIndex = 5;
            label17.Text = "Balance";
            // 
            // AccountUserIDsLabel
            // 
            AccountUserIDsLabel.AutoSize = true;
            AccountUserIDsLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountUserIDsLabel.Location = new Point(21, 3);
            AccountUserIDsLabel.Name = "AccountUserIDsLabel";
            AccountUserIDsLabel.Size = new Size(86, 30);
            AccountUserIDsLabel.TabIndex = 7;
            AccountUserIDsLabel.Text = "UserIDs";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(UsersEmailLabel);
            panel2.Controls.Add(userPhone);
            panel2.Controls.Add(userFirstName);
            panel2.Controls.Add(userLastname);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(ModifyaccountInfoBTN);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(352, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 252);
            panel2.TabIndex = 6;
            // 
            // UsersEmailLabel
            // 
            UsersEmailLabel.AutoSize = true;
            UsersEmailLabel.Font = new Font("Segoe UI", 12F);
            UsersEmailLabel.Location = new Point(118, 213);
            UsersEmailLabel.Name = "UsersEmailLabel";
            UsersEmailLabel.Size = new Size(89, 21);
            UsersEmailLabel.TabIndex = 11;
            UsersEmailLabel.Text = "PhoneNum";
            // 
            // userPhone
            // 
            userPhone.AutoSize = true;
            userPhone.Font = new Font("Segoe UI", 12F);
            userPhone.Location = new Point(117, 165);
            userPhone.Name = "userPhone";
            userPhone.Size = new Size(89, 21);
            userPhone.TabIndex = 10;
            userPhone.Text = "PhoneNum";
            // 
            // userFirstName
            // 
            userFirstName.AutoSize = true;
            userFirstName.Font = new Font("Segoe UI", 12F);
            userFirstName.Location = new Point(115, 65);
            userFirstName.Name = "userFirstName";
            userFirstName.Size = new Size(79, 21);
            userFirstName.TabIndex = 8;
            userFirstName.Text = "Firstname";
            // 
            // userLastname
            // 
            userLastname.AutoSize = true;
            userLastname.Font = new Font("Segoe UI", 12F);
            userLastname.Location = new Point(117, 113);
            userLastname.Name = "userLastname";
            userLastname.Size = new Size(77, 21);
            userLastname.TabIndex = 9;
            userLastname.Text = "Lastname";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(8, 165);
            label9.Name = "label9";
            label9.Size = new Size(100, 21);
            label9.TabIndex = 6;
            label9.Text = "PhoneNum : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(10, 213);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 7;
            label10.Text = "Email : ";
            label10.Click += label10_Click;
            // 
            // ModifyaccountInfoBTN
            // 
            ModifyaccountInfoBTN.BackColor = Color.FromArgb(192, 255, 192);
            ModifyaccountInfoBTN.Location = new Point(250, 75);
            ModifyaccountInfoBTN.Name = "ModifyaccountInfoBTN";
            ModifyaccountInfoBTN.Size = new Size(94, 101);
            ModifyaccountInfoBTN.TabIndex = 5;
            ModifyaccountInfoBTN.Text = "Modify";
            ModifyaccountInfoBTN.UseVisualStyleBackColor = false;
            ModifyaccountInfoBTN.Click += ModifyaccountInfoBTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 11);
            label4.Name = "label4";
            label4.Size = new Size(249, 30);
            label4.TabIndex = 4;
            label4.Text = "Background Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(6, 65);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 2;
            label7.Text = "Firstname : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(8, 113);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 3;
            label8.Text = "Lastname :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(ModifyAccountBTN);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(54, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 217);
            panel1.TabIndex = 4;
            // 
            // ModifyAccountBTN
            // 
            ModifyAccountBTN.BackColor = Color.FromArgb(192, 255, 192);
            ModifyAccountBTN.Location = new Point(141, 55);
            ModifyAccountBTN.Name = "ModifyAccountBTN";
            ModifyAccountBTN.Size = new Size(94, 101);
            ModifyAccountBTN.TabIndex = 5;
            ModifyAccountBTN.Text = "Modify";
            ModifyAccountBTN.UseVisualStyleBackColor = false;
            ModifyAccountBTN.Click += ModifyAccountBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 11);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 4;
            label3.Text = "Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 113);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 3;
            label1.Text = "*******";
            // 
            // ModifyAccount
            // 
            ModifyAccount.BackColor = Color.FromArgb(192, 255, 192);
            ModifyAccount.Controls.Add(ModifyingAccountBTN);
            ModifyAccount.Controls.Add(label16);
            ModifyAccount.Controls.Add(label15);
            ModifyAccount.Controls.Add(PasswordInput);
            ModifyAccount.Controls.Add(UsernameInput);
            ModifyAccount.Dock = DockStyle.Fill;
            ModifyAccount.Location = new Point(0, 0);
            ModifyAccount.Name = "ModifyAccount";
            ModifyAccount.Size = new Size(778, 556);
            ModifyAccount.TabIndex = 5;
            // 
            // ModifyingAccountBTN
            // 
            ModifyingAccountBTN.Location = new Point(114, 254);
            ModifyingAccountBTN.Name = "ModifyingAccountBTN";
            ModifyingAccountBTN.Size = new Size(507, 97);
            ModifyingAccountBTN.TabIndex = 32;
            ModifyingAccountBTN.Text = "Modify";
            ModifyingAccountBTN.UseVisualStyleBackColor = true;
            ModifyingAccountBTN.Click += ModifyingAccountBTN_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(54, 144);
            label16.Name = "label16";
            label16.Size = new Size(163, 45);
            label16.TabIndex = 31;
            label16.Text = "Password";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label15.Location = new Point(49, 53);
            label15.Name = "label15";
            label15.Size = new Size(169, 45);
            label15.TabIndex = 30;
            label15.Text = "Username";
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Segoe UI", 17F);
            PasswordInput.Location = new Point(258, 150);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(324, 38);
            PasswordInput.TabIndex = 29;
            // 
            // UsernameInput
            // 
            UsernameInput.Font = new Font("Segoe UI", 17F);
            UsernameInput.Location = new Point(263, 60);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(387, 38);
            UsernameInput.TabIndex = 28;
            // 
            // ModifyBackground
            // 
            ModifyBackground.BackColor = Color.FromArgb(192, 255, 192);
            ModifyBackground.Controls.Add(lastnamebox);
            ModifyBackground.Controls.Add(firstnamebox);
            ModifyBackground.Controls.Add(PhoneNumberBox);
            ModifyBackground.Controls.Add(EmailBox);
            ModifyBackground.Controls.Add(ChangePhoneNumBTN);
            ModifyBackground.Controls.Add(ChangeEmailBTN);
            ModifyBackground.Controls.Add(ChangeNameBTN);
            ModifyBackground.Controls.Add(label14);
            ModifyBackground.Controls.Add(label13);
            ModifyBackground.Controls.Add(label12);
            ModifyBackground.Controls.Add(label11);
            ModifyBackground.Dock = DockStyle.Fill;
            ModifyBackground.Location = new Point(0, 0);
            ModifyBackground.Name = "ModifyBackground";
            ModifyBackground.Size = new Size(778, 556);
            ModifyBackground.TabIndex = 7;
            ModifyBackground.Paint += ModifyBackground_Paint;
            // 
            // lastnamebox
            // 
            lastnamebox.Location = new Point(529, 53);
            lastnamebox.Name = "lastnamebox";
            lastnamebox.Size = new Size(158, 23);
            lastnamebox.TabIndex = 27;
            // 
            // firstnamebox
            // 
            firstnamebox.Location = new Point(152, 56);
            firstnamebox.Name = "firstnamebox";
            firstnamebox.Size = new Size(158, 23);
            firstnamebox.TabIndex = 26;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(152, 328);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(158, 23);
            PhoneNumberBox.TabIndex = 25;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(152, 243);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(158, 23);
            EmailBox.TabIndex = 24;
            // 
            // ChangePhoneNumBTN
            // 
            ChangePhoneNumBTN.Location = new Point(338, 319);
            ChangePhoneNumBTN.Name = "ChangePhoneNumBTN";
            ChangePhoneNumBTN.Size = new Size(106, 46);
            ChangePhoneNumBTN.TabIndex = 19;
            ChangePhoneNumBTN.Text = "Change Phone Number";
            ChangePhoneNumBTN.UseVisualStyleBackColor = true;
            ChangePhoneNumBTN.Click += ChangePhoneNumBTN_Click;
            // 
            // ChangeEmailBTN
            // 
            ChangeEmailBTN.Location = new Point(338, 230);
            ChangeEmailBTN.Name = "ChangeEmailBTN";
            ChangeEmailBTN.Size = new Size(106, 46);
            ChangeEmailBTN.TabIndex = 17;
            ChangeEmailBTN.Text = "Change Email";
            ChangeEmailBTN.UseVisualStyleBackColor = true;
            ChangeEmailBTN.Click += ChangeEmailBTN_Click;
            // 
            // ChangeNameBTN
            // 
            ChangeNameBTN.Location = new Point(134, 124);
            ChangeNameBTN.Name = "ChangeNameBTN";
            ChangeNameBTN.Size = new Size(516, 49);
            ChangeNameBTN.TabIndex = 16;
            ChangeNameBTN.Text = "Change Name";
            ChangeNameBTN.UseVisualStyleBackColor = true;
            ChangeNameBTN.Click += ChangeNameBTN_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(433, 56);
            label14.Name = "label14";
            label14.Size = new Size(77, 21);
            label14.TabIndex = 15;
            label14.Text = "Lastname";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(49, 54);
            label13.Name = "label13";
            label13.Size = new Size(79, 21);
            label13.TabIndex = 14;
            label13.Text = "Firstname";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(47, 330);
            label12.Name = "label12";
            label12.Size = new Size(89, 21);
            label12.TabIndex = 13;
            label12.Text = "PhoneNum";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(65, 245);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 12;
            label11.Text = "Email";
            // 
            // AddBalancePanel
            // 
            AddBalancePanel.BackColor = Color.FromArgb(192, 255, 192);
            AddBalancePanel.Controls.Add(AddBalanceWithdrawalBTN);
            AddBalancePanel.Controls.Add(label18);
            AddBalancePanel.Controls.Add(PatientWithdrawalInput);
            AddBalancePanel.Controls.Add(AddBalanceDepositBTN);
            AddBalancePanel.Controls.Add(label19);
            AddBalancePanel.Controls.Add(PatientDepositInput);
            AddBalancePanel.Dock = DockStyle.Fill;
            AddBalancePanel.Location = new Point(0, 0);
            AddBalancePanel.Name = "AddBalancePanel";
            AddBalancePanel.Size = new Size(778, 556);
            AddBalancePanel.TabIndex = 12;
            // 
            // AddBalanceWithdrawalBTN
            // 
            AddBalanceWithdrawalBTN.Location = new Point(574, 276);
            AddBalanceWithdrawalBTN.Name = "AddBalanceWithdrawalBTN";
            AddBalanceWithdrawalBTN.Size = new Size(176, 63);
            AddBalanceWithdrawalBTN.TabIndex = 6;
            AddBalanceWithdrawalBTN.Text = "Confirm Withdrawal";
            AddBalanceWithdrawalBTN.UseVisualStyleBackColor = true;
            AddBalanceWithdrawalBTN.Click += AddBalanceWithdrawalBTN_Click_1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(45, 241);
            label18.Name = "label18";
            label18.Size = new Size(186, 37);
            label18.TabIndex = 5;
            label18.Text = "WIDTHRWAL";
            // 
            // PatientWithdrawalInput
            // 
            PatientWithdrawalInput.BackColor = Color.White;
            PatientWithdrawalInput.BorderStyle = BorderStyle.FixedSingle;
            PatientWithdrawalInput.Font = new Font("Segoe UI", 14F);
            PatientWithdrawalInput.ForeColor = Color.Black;
            PatientWithdrawalInput.Location = new Point(73, 290);
            PatientWithdrawalInput.Name = "PatientWithdrawalInput";
            PatientWithdrawalInput.Size = new Size(318, 32);
            PatientWithdrawalInput.TabIndex = 4;
            // 
            // AddBalanceDepositBTN
            // 
            AddBalanceDepositBTN.Location = new Point(575, 115);
            AddBalanceDepositBTN.Name = "AddBalanceDepositBTN";
            AddBalanceDepositBTN.Size = new Size(176, 63);
            AddBalanceDepositBTN.TabIndex = 2;
            AddBalanceDepositBTN.Text = "Confirm Deposit";
            AddBalanceDepositBTN.UseVisualStyleBackColor = true;
            AddBalanceDepositBTN.Click += AddBalanceDepositBTN_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(45, 95);
            label19.Name = "label19";
            label19.Size = new Size(128, 37);
            label19.TabIndex = 1;
            label19.Text = "DEPOSIT";
            // 
            // PatientDepositInput
            // 
            PatientDepositInput.BackColor = Color.White;
            PatientDepositInput.BorderStyle = BorderStyle.FixedSingle;
            PatientDepositInput.Font = new Font("Segoe UI", 14F);
            PatientDepositInput.ForeColor = Color.Black;
            PatientDepositInput.Location = new Point(73, 135);
            PatientDepositInput.Name = "PatientDepositInput";
            PatientDepositInput.Size = new Size(318, 32);
            PatientDepositInput.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 25);
            label6.Name = "label6";
            label6.Size = new Size(192, 65);
            label6.TabIndex = 1;
            label6.Text = "Setting";
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(192, 255, 192);
            Dashboard.Controls.Add(DashboardPatient);
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.Location = new Point(0, 75);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(778, 556);
            Dashboard.TabIndex = 0;
            // 
            // DashboardPatient
            // 
            DashboardPatient.Controls.Add(PatientsPanel);
            DashboardPatient.Controls.Add(OnAppointmentPanel);
            DashboardPatient.Controls.Add(DashboardTopBar);
            DashboardPatient.Dock = DockStyle.Fill;
            DashboardPatient.Location = new Point(0, 0);
            DashboardPatient.Name = "DashboardPatient";
            DashboardPatient.Size = new Size(778, 556);
            DashboardPatient.TabIndex = 0;
            // 
            // PatientsPanel
            // 
            PatientsPanel.Controls.Add(LoadPatientDiagnosis);
            PatientsPanel.Dock = DockStyle.Fill;
            PatientsPanel.Location = new Point(0, 75);
            PatientsPanel.Name = "PatientsPanel";
            PatientsPanel.Size = new Size(778, 481);
            PatientsPanel.TabIndex = 2;
            // 
            // LoadPatientDiagnosis
            // 
            LoadPatientDiagnosis.AutoScroll = true;
            LoadPatientDiagnosis.Location = new Point(17, 33);
            LoadPatientDiagnosis.Name = "LoadPatientDiagnosis";
            LoadPatientDiagnosis.Size = new Size(734, 437);
            LoadPatientDiagnosis.TabIndex = 0;
            LoadPatientDiagnosis.Paint += LoadPatientDiagnosis_Paint;
            // 
            // OnAppointmentPanel
            // 
            OnAppointmentPanel.Controls.Add(GetAppointmentDoctor);
            OnAppointmentPanel.Dock = DockStyle.Fill;
            OnAppointmentPanel.Location = new Point(0, 75);
            OnAppointmentPanel.Name = "OnAppointmentPanel";
            OnAppointmentPanel.Size = new Size(778, 481);
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
            // HistorySale
            // 
            HistorySale.BackColor = Color.FromArgb(192, 255, 192);
            HistorySale.Controls.Add(DoctorHistoryFlowPanel);
            HistorySale.Controls.Add(label5);
            HistorySale.Dock = DockStyle.Fill;
            HistorySale.Location = new Point(0, 75);
            HistorySale.Name = "HistorySale";
            HistorySale.Size = new Size(778, 556);
            HistorySale.TabIndex = 11;
            // 
            // DoctorHistoryFlowPanel
            // 
            DoctorHistoryFlowPanel.AutoScroll = true;
            DoctorHistoryFlowPanel.Location = new Point(21, 78);
            DoctorHistoryFlowPanel.Name = "DoctorHistoryFlowPanel";
            DoctorHistoryFlowPanel.Size = new Size(730, 420);
            DoctorHistoryFlowPanel.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(104, 14);
            label5.Name = "label5";
            label5.Size = new Size(555, 65);
            label5.TabIndex = 0;
            label5.Text = "History APPOINTMENT";
            // 
            // DoctorUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 631);
            Controls.Add(Setting);
            Controls.Add(Dashboard);
            Controls.Add(HistorySale);
            Controls.Add(Appointment);
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
            SettingPanel.ResumeLayout(false);
            SettingPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ModifyAccount.ResumeLayout(false);
            ModifyAccount.PerformLayout();
            ModifyBackground.ResumeLayout(false);
            ModifyBackground.PerformLayout();
            AddBalancePanel.ResumeLayout(false);
            AddBalancePanel.PerformLayout();
            Dashboard.ResumeLayout(false);
            DashboardPatient.ResumeLayout(false);
            PatientsPanel.ResumeLayout(false);
            OnAppointmentPanel.ResumeLayout(false);
            DashboardTopBar.ResumeLayout(false);
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
        private FlowLayoutPanel GetAppointmentDoctor;
        private Button OnAppointmentDashboard;
        private Panel DashboardTopBar;
        private Panel OnAppointmentPanel;
        private Button LogoutBTN;
        private Panel SettingPanel;
        private Panel panel2;
        private Label userPhone;
        private Label userFirstName;
        private Label userLastname;
        private Label label9;
        private Label label10;
        private Button ModifyaccountInfoBTN;
        private Label label4;
        private Label label7;
        private Label label8;
        private Panel ModifyAccount;
        private Panel ModifyBackground;
        private TextBox textBox4;
        private TextBox lastnamebox;
        private TextBox firstnamebox;
        private TextBox PhoneNumberBox;
        private Button ChangePhoneNumBTN;
        private Button ChangeEmailBTN;
        private Button ChangeNameBTN;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox EmailBox;
        private Label UsersEmailLabel;
        private Label label16;
        private Label label15;
        private TextBox PasswordInput;
        private TextBox UsernameInput;
        private Button ModifyingAccountBTN;
        private Panel panel1;
        private Button ModifyAccountBTN;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label AccountUserIDsLabel;
        private Panel panel3;
        private Label DoctorBalance;
        private Label label17;
        private Button button1;
        private Panel AddBalancePanel;
        private Button AddBalanceWithdrawalBTN;
        private Label label18;
        private TextBox PatientWithdrawalInput;
        private Button AddBalanceDepositBTN;
        private Label label19;
        private TextBox PatientDepositInput;
        private Panel PatientsPanel;
        private Panel panel4;
        private Label FeeLabel;
        private Button ModifyFeeBTN;
        private Label label20;
        private Label DoctorSpecialistLabel;
        private Label label22;
        private Label label23;
        private Label label21;
        private TextBox UpdateFeeBox;
        private FlowLayoutPanel DoctorHistoryFlowPanel;
        private Label label24;
    }
}