namespace DBAces
{
    partial class AdminUI
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
            TopbarPanel = new Panel();
            AppointmentBTN = new Button();
            TopBar_DashboardBTN = new Button();
            TopBar_UserBTN = new Button();
            UserPanel = new Panel();
            panel1 = new Panel();
            DoctorUserPanel = new Panel();
            label2 = new Label();
            DoctorDisplayFlowLayout = new FlowLayoutPanel();
            UserPatientPanel = new Panel();
            label1 = new Label();
            PatientDisplayFlowLayout = new FlowLayoutPanel();
            TopbarUsers = new Panel();
            AddDoctorBTN = new Button();
            UserDoctorBTN = new Button();
            UserPatientBTN = new Button();
            AppointmentPanel = new Panel();
            AddUserPanel = new Panel();
            ToRegisterDoctorBTN = new Button();
            SpecializationTextBox = new TextBox();
            DoctorSpecializationTextBox = new Label();
            DoctorLastNameTextBox = new TextBox();
            label5 = new Label();
            DoctorFirstNameTextBox = new TextBox();
            label6 = new Label();
            DoctorPasswordTextBox = new TextBox();
            label4 = new Label();
            DoctorUserNameTextbox = new TextBox();
            label3 = new Label();
            Dashboard = new Panel();
            button1 = new Button();
            button2 = new Button();
            TopbarPanel.SuspendLayout();
            UserPanel.SuspendLayout();
            panel1.SuspendLayout();
            DoctorUserPanel.SuspendLayout();
            UserPatientPanel.SuspendLayout();
            TopbarUsers.SuspendLayout();
            AddUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopbarPanel
            // 
            TopbarPanel.BackColor = Color.FromArgb(0, 0, 64);
            TopbarPanel.Controls.Add(button2);
            TopbarPanel.Controls.Add(button1);
            TopbarPanel.Controls.Add(AppointmentBTN);
            TopbarPanel.Controls.Add(TopBar_DashboardBTN);
            TopbarPanel.Controls.Add(TopBar_UserBTN);
            TopbarPanel.Dock = DockStyle.Top;
            TopbarPanel.Location = new Point(0, 0);
            TopbarPanel.Name = "TopbarPanel";
            TopbarPanel.Size = new Size(838, 59);
            TopbarPanel.TabIndex = 0;
            TopbarPanel.Paint += TopbarPanel_Paint;
            // 
            // AppointmentBTN
            // 
            AppointmentBTN.BackColor = Color.Transparent;
            AppointmentBTN.FlatAppearance.BorderSize = 0;
            AppointmentBTN.FlatStyle = FlatStyle.Flat;
            AppointmentBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentBTN.ForeColor = SystemColors.Control;
            AppointmentBTN.Location = new Point(132, 12);
            AppointmentBTN.Name = "AppointmentBTN";
            AppointmentBTN.Size = new Size(142, 37);
            AppointmentBTN.TabIndex = 9;
            AppointmentBTN.Text = "Appointments";
            AppointmentBTN.UseVisualStyleBackColor = false;
            AppointmentBTN.Click += AppointmentBTN_Click;
            // 
            // TopBar_DashboardBTN
            // 
            TopBar_DashboardBTN.BackColor = Color.Transparent;
            TopBar_DashboardBTN.FlatAppearance.BorderSize = 0;
            TopBar_DashboardBTN.FlatStyle = FlatStyle.Flat;
            TopBar_DashboardBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopBar_DashboardBTN.ForeColor = SystemColors.Control;
            TopBar_DashboardBTN.Location = new Point(615, 16);
            TopBar_DashboardBTN.Name = "TopBar_DashboardBTN";
            TopBar_DashboardBTN.Size = new Size(203, 37);
            TopBar_DashboardBTN.TabIndex = 9;
            TopBar_DashboardBTN.Text = "Setting";
            TopBar_DashboardBTN.UseVisualStyleBackColor = false;
            TopBar_DashboardBTN.Click += TopBar_DashboardBTN_Click;
            // 
            // TopBar_UserBTN
            // 
            TopBar_UserBTN.BackColor = Color.Transparent;
            TopBar_UserBTN.FlatAppearance.BorderSize = 0;
            TopBar_UserBTN.FlatStyle = FlatStyle.Flat;
            TopBar_UserBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopBar_UserBTN.ForeColor = SystemColors.Control;
            TopBar_UserBTN.Location = new Point(12, 12);
            TopBar_UserBTN.Name = "TopBar_UserBTN";
            TopBar_UserBTN.Size = new Size(126, 37);
            TopBar_UserBTN.TabIndex = 6;
            TopBar_UserBTN.Text = "Users";
            TopBar_UserBTN.UseVisualStyleBackColor = false;
            TopBar_UserBTN.Click += TopBar_UserBTN_Click;
            // 
            // UserPanel
            // 
            UserPanel.AutoScroll = true;
            UserPanel.Controls.Add(panel1);
            UserPanel.Dock = DockStyle.Fill;
            UserPanel.Location = new Point(0, 59);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(838, 423);
            UserPanel.TabIndex = 0;
            UserPanel.Paint += UserPanel_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(DoctorUserPanel);
            panel1.Controls.Add(UserPatientPanel);
            panel1.Controls.Add(TopbarUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 423);
            panel1.TabIndex = 14;
            // 
            // DoctorUserPanel
            // 
            DoctorUserPanel.BackColor = Color.FromArgb(192, 255, 255);
            DoctorUserPanel.Controls.Add(label2);
            DoctorUserPanel.Controls.Add(DoctorDisplayFlowLayout);
            DoctorUserPanel.Dock = DockStyle.Fill;
            DoctorUserPanel.Location = new Point(0, 61);
            DoctorUserPanel.Name = "DoctorUserPanel";
            DoctorUserPanel.Size = new Size(838, 362);
            DoctorUserPanel.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 19);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 13;
            label2.Text = "Doctor";
            // 
            // DoctorDisplayFlowLayout
            // 
            DoctorDisplayFlowLayout.AutoScroll = true;
            DoctorDisplayFlowLayout.Location = new Point(22, 52);
            DoctorDisplayFlowLayout.Name = "DoctorDisplayFlowLayout";
            DoctorDisplayFlowLayout.Size = new Size(744, 270);
            DoctorDisplayFlowLayout.TabIndex = 1;
            // 
            // UserPatientPanel
            // 
            UserPatientPanel.BackColor = Color.FromArgb(192, 255, 255);
            UserPatientPanel.Controls.Add(label1);
            UserPatientPanel.Controls.Add(PatientDisplayFlowLayout);
            UserPatientPanel.Dock = DockStyle.Fill;
            UserPatientPanel.Location = new Point(0, 61);
            UserPatientPanel.Name = "UserPatientPanel";
            UserPatientPanel.Size = new Size(838, 362);
            UserPatientPanel.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 14;
            label1.Text = "Patient";
            label1.Click += label1_Click;
            // 
            // PatientDisplayFlowLayout
            // 
            PatientDisplayFlowLayout.AutoScroll = true;
            PatientDisplayFlowLayout.Location = new Point(49, 56);
            PatientDisplayFlowLayout.Name = "PatientDisplayFlowLayout";
            PatientDisplayFlowLayout.Size = new Size(744, 270);
            PatientDisplayFlowLayout.TabIndex = 2;
            // 
            // TopbarUsers
            // 
            TopbarUsers.BackColor = Color.SteelBlue;
            TopbarUsers.Controls.Add(AddDoctorBTN);
            TopbarUsers.Controls.Add(UserDoctorBTN);
            TopbarUsers.Controls.Add(UserPatientBTN);
            TopbarUsers.Dock = DockStyle.Top;
            TopbarUsers.Location = new Point(0, 0);
            TopbarUsers.Name = "TopbarUsers";
            TopbarUsers.Size = new Size(838, 61);
            TopbarUsers.TabIndex = 19;
            // 
            // AddDoctorBTN
            // 
            AddDoctorBTN.Location = new Point(672, 16);
            AddDoctorBTN.Name = "AddDoctorBTN";
            AddDoctorBTN.Size = new Size(132, 29);
            AddDoctorBTN.TabIndex = 14;
            AddDoctorBTN.Text = "AddDoctor";
            AddDoctorBTN.UseVisualStyleBackColor = true;
            AddDoctorBTN.Click += AddDoctorBTN_Click;
            // 
            // UserDoctorBTN
            // 
            UserDoctorBTN.Location = new Point(144, 14);
            UserDoctorBTN.Name = "UserDoctorBTN";
            UserDoctorBTN.Size = new Size(89, 32);
            UserDoctorBTN.TabIndex = 20;
            UserDoctorBTN.Text = "Doctor";
            UserDoctorBTN.UseVisualStyleBackColor = true;
            UserDoctorBTN.Click += UserDoctorBTN_Click;
            // 
            // UserPatientBTN
            // 
            UserPatientBTN.Location = new Point(31, 14);
            UserPatientBTN.Name = "UserPatientBTN";
            UserPatientBTN.Size = new Size(89, 32);
            UserPatientBTN.TabIndex = 19;
            UserPatientBTN.Text = "Patient";
            UserPatientBTN.UseVisualStyleBackColor = true;
            UserPatientBTN.Click += UserPatientBTN_Click;
            // 
            // AppointmentPanel
            // 
            AppointmentPanel.Dock = DockStyle.Fill;
            AppointmentPanel.Location = new Point(0, 59);
            AppointmentPanel.Name = "AppointmentPanel";
            AppointmentPanel.Size = new Size(838, 423);
            AppointmentPanel.TabIndex = 0;
            // 
            // AddUserPanel
            // 
            AddUserPanel.BackColor = SystemColors.ActiveCaption;
            AddUserPanel.Controls.Add(ToRegisterDoctorBTN);
            AddUserPanel.Controls.Add(SpecializationTextBox);
            AddUserPanel.Controls.Add(DoctorSpecializationTextBox);
            AddUserPanel.Controls.Add(DoctorLastNameTextBox);
            AddUserPanel.Controls.Add(label5);
            AddUserPanel.Controls.Add(DoctorFirstNameTextBox);
            AddUserPanel.Controls.Add(label6);
            AddUserPanel.Controls.Add(DoctorPasswordTextBox);
            AddUserPanel.Controls.Add(label4);
            AddUserPanel.Controls.Add(DoctorUserNameTextbox);
            AddUserPanel.Controls.Add(label3);
            AddUserPanel.Dock = DockStyle.Fill;
            AddUserPanel.Location = new Point(0, 59);
            AddUserPanel.Name = "AddUserPanel";
            AddUserPanel.Size = new Size(838, 423);
            AddUserPanel.TabIndex = 15;
            AddUserPanel.Paint += AddUserPanel_Paint;
            // 
            // ToRegisterDoctorBTN
            // 
            ToRegisterDoctorBTN.Location = new Point(549, 287);
            ToRegisterDoctorBTN.Name = "ToRegisterDoctorBTN";
            ToRegisterDoctorBTN.Size = new Size(269, 52);
            ToRegisterDoctorBTN.TabIndex = 14;
            ToRegisterDoctorBTN.Text = "REGISTER DOCTOR";
            ToRegisterDoctorBTN.UseVisualStyleBackColor = true;
            ToRegisterDoctorBTN.Click += ToRegisterDoctorBTN_Click;
            // 
            // SpecializationTextBox
            // 
            SpecializationTextBox.Location = new Point(444, 141);
            SpecializationTextBox.Name = "SpecializationTextBox";
            SpecializationTextBox.Size = new Size(182, 23);
            SpecializationTextBox.TabIndex = 9;
            // 
            // DoctorSpecializationTextBox
            // 
            DoctorSpecializationTextBox.AutoSize = true;
            DoctorSpecializationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DoctorSpecializationTextBox.Location = new Point(474, 117);
            DoctorSpecializationTextBox.Name = "DoctorSpecializationTextBox";
            DoctorSpecializationTextBox.Size = new Size(118, 21);
            DoctorSpecializationTextBox.TabIndex = 8;
            DoctorSpecializationTextBox.Text = "Specialization";
            // 
            // DoctorLastNameTextBox
            // 
            DoctorLastNameTextBox.Location = new Point(566, 53);
            DoctorLastNameTextBox.Name = "DoctorLastNameTextBox";
            DoctorLastNameTextBox.Size = new Size(182, 23);
            DoctorLastNameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(579, 29);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 6;
            label5.Text = "Doctor LastName";
            // 
            // DoctorFirstNameTextBox
            // 
            DoctorFirstNameTextBox.Location = new Point(328, 53);
            DoctorFirstNameTextBox.Name = "DoctorFirstNameTextBox";
            DoctorFirstNameTextBox.Size = new Size(182, 23);
            DoctorFirstNameTextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(345, 29);
            label6.Name = "label6";
            label6.Size = new Size(144, 21);
            label6.TabIndex = 4;
            label6.Text = "Doctor FirstName";
            // 
            // DoctorPasswordTextBox
            // 
            DoctorPasswordTextBox.Location = new Point(49, 113);
            DoctorPasswordTextBox.Name = "DoctorPasswordTextBox";
            DoctorPasswordTextBox.Size = new Size(182, 23);
            DoctorPasswordTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(51, 89);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 2;
            label4.Text = "Doctor Password";
            // 
            // DoctorUserNameTextbox
            // 
            DoctorUserNameTextbox.Location = new Point(49, 51);
            DoctorUserNameTextbox.Name = "DoctorUserNameTextbox";
            DoctorUserNameTextbox.Size = new Size(182, 23);
            DoctorUserNameTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(51, 27);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 0;
            label3.Text = "Doctor Username";
            // 
            // Dashboard
            // 
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.Location = new Point(0, 59);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(838, 423);
            Dashboard.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(263, 12);
            button1.Name = "button1";
            button1.Size = new Size(142, 37);
            button1.TabIndex = 10;
            button1.Text = "History";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(385, 12);
            button2.Name = "button2";
            button2.Size = new Size(142, 37);
            button2.TabIndex = 11;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // AdminUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 482);
            Controls.Add(UserPanel);
            Controls.Add(AddUserPanel);
            Controls.Add(AppointmentPanel);
            Controls.Add(Dashboard);
            Controls.Add(TopbarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminUI";
            Text = "AdminUI";
            Load += AdminUI_Load;
            TopbarPanel.ResumeLayout(false);
            UserPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            DoctorUserPanel.ResumeLayout(false);
            DoctorUserPanel.PerformLayout();
            UserPatientPanel.ResumeLayout(false);
            UserPatientPanel.PerformLayout();
            TopbarUsers.ResumeLayout(false);
            AddUserPanel.ResumeLayout(false);
            AddUserPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopbarPanel;
        private Button TopBar_UserBTN;
        private Panel UserPanel;
        private Panel AppointmentPanel;
        private FlowLayoutPanel DoctorDisplayFlowLayout;
        private Label label2;
        private Panel panel1;
        private Button TopBar_DashboardBTN;
        private Button AppointmentBTN;
        private Button AddDoctorBTN;
        private Panel AddUserPanel;
        private TextBox SpecializationTextBox;
        private Label DoctorSpecializationTextBox;
        private TextBox DoctorLastNameTextBox;
        private Label label5;
        private TextBox DoctorFirstNameTextBox;
        private Label label6;
        private TextBox DoctorPasswordTextBox;
        private Label label4;
        private TextBox DoctorUserNameTextbox;
        private Label label3;
        private Button ToRegisterDoctorBTN;
        private Panel TopbarUsers;
        private Panel DoctorUserPanel;
        private Button UserDoctorBTN;
        private Button UserPatientBTN;
        private Panel UserPatientPanel;
        private FlowLayoutPanel PatientDisplayFlowLayout;
        private Label label1;
        private Panel Dashboard;
        private Button button2;
        private Button button1;
    }
}