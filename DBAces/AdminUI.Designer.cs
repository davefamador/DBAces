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
            TopBar_PaymentHistoryBTN = new Button();
            TopBar_UserBTN = new Button();
            UserPanel = new Panel();
            panel1 = new Panel();
            AddDoctorBTN = new Button();
            DoctorDisplayFlowLayout = new FlowLayoutPanel();
            PatientDisplayFlowLayout = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            AppointmentPanel = new Panel();
            PaymentHistoryPanel = new Panel();
            DashboardPanel = new Panel();
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
            TopbarPanel.SuspendLayout();
            UserPanel.SuspendLayout();
            panel1.SuspendLayout();
            AddUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopbarPanel
            // 
            TopbarPanel.BackColor = Color.Navy;
            TopbarPanel.Controls.Add(AppointmentBTN);
            TopbarPanel.Controls.Add(TopBar_DashboardBTN);
            TopbarPanel.Controls.Add(TopBar_PaymentHistoryBTN);
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
            AppointmentBTN.Location = new Point(144, 12);
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
            TopBar_DashboardBTN.Text = "Dashboard";
            TopBar_DashboardBTN.UseVisualStyleBackColor = false;
            TopBar_DashboardBTN.Click += TopBar_DashboardBTN_Click;
            // 
            // TopBar_PaymentHistoryBTN
            // 
            TopBar_PaymentHistoryBTN.BackColor = Color.Transparent;
            TopBar_PaymentHistoryBTN.FlatAppearance.BorderSize = 0;
            TopBar_PaymentHistoryBTN.FlatStyle = FlatStyle.Flat;
            TopBar_PaymentHistoryBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopBar_PaymentHistoryBTN.ForeColor = SystemColors.Control;
            TopBar_PaymentHistoryBTN.Location = new Point(306, 12);
            TopBar_PaymentHistoryBTN.Name = "TopBar_PaymentHistoryBTN";
            TopBar_PaymentHistoryBTN.Size = new Size(203, 37);
            TopBar_PaymentHistoryBTN.TabIndex = 7;
            TopBar_PaymentHistoryBTN.Text = "Payment History";
            TopBar_PaymentHistoryBTN.UseVisualStyleBackColor = false;
            TopBar_PaymentHistoryBTN.Click += TopBar_PaymentHistoryBTN_Click;
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
            panel1.Controls.Add(AddDoctorBTN);
            panel1.Controls.Add(DoctorDisplayFlowLayout);
            panel1.Controls.Add(PatientDisplayFlowLayout);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 504);
            panel1.TabIndex = 14;
            // 
            // AddDoctorBTN
            // 
            AddDoctorBTN.Location = new Point(648, 21);
            AddDoctorBTN.Name = "AddDoctorBTN";
            AddDoctorBTN.Size = new Size(132, 29);
            AddDoctorBTN.TabIndex = 14;
            AddDoctorBTN.Text = "AddDoctor";
            AddDoctorBTN.UseVisualStyleBackColor = true;
            AddDoctorBTN.Click += AddDoctorBTN_Click;
            // 
            // DoctorDisplayFlowLayout
            // 
            DoctorDisplayFlowLayout.AutoScroll = true;
            DoctorDisplayFlowLayout.Location = new Point(36, 56);
            DoctorDisplayFlowLayout.Name = "DoctorDisplayFlowLayout";
            DoctorDisplayFlowLayout.Size = new Size(744, 148);
            DoctorDisplayFlowLayout.TabIndex = 1;
            // 
            // PatientDisplayFlowLayout
            // 
            PatientDisplayFlowLayout.AutoScroll = true;
            PatientDisplayFlowLayout.AutoSize = true;
            PatientDisplayFlowLayout.Location = new Point(36, 262);
            PatientDisplayFlowLayout.MinimumSize = new Size(744, 148);
            PatientDisplayFlowLayout.Name = "PatientDisplayFlowLayout";
            PatientDisplayFlowLayout.Padding = new Padding(5);
            PatientDisplayFlowLayout.Size = new Size(744, 148);
            PatientDisplayFlowLayout.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 229);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 13;
            label2.Text = "Patient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 12;
            label1.Text = "Doctor";
            // 
            // AppointmentPanel
            // 
            AppointmentPanel.Dock = DockStyle.Fill;
            AppointmentPanel.Location = new Point(0, 59);
            AppointmentPanel.Name = "AppointmentPanel";
            AppointmentPanel.Size = new Size(838, 423);
            AppointmentPanel.TabIndex = 0;
            // 
            // PaymentHistoryPanel
            // 
            PaymentHistoryPanel.Dock = DockStyle.Fill;
            PaymentHistoryPanel.Location = new Point(0, 59);
            PaymentHistoryPanel.Name = "PaymentHistoryPanel";
            PaymentHistoryPanel.Size = new Size(838, 423);
            PaymentHistoryPanel.TabIndex = 1;
            // 
            // DashboardPanel
            // 
            DashboardPanel.Dock = DockStyle.Fill;
            DashboardPanel.Location = new Point(0, 59);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(838, 423);
            DashboardPanel.TabIndex = 14;
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
            // AdminUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 482);
            Controls.Add(AddUserPanel);
            Controls.Add(UserPanel);
            Controls.Add(DashboardPanel);
            Controls.Add(AppointmentPanel);
            Controls.Add(PaymentHistoryPanel);
            Controls.Add(TopbarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminUI";
            Text = "AdminUI";
            Load += AdminUI_Load;
            TopbarPanel.ResumeLayout(false);
            UserPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AddUserPanel.ResumeLayout(false);
            AddUserPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopbarPanel;
        private Button TopBar_UserBTN;
        private Panel UserPanel;
        private Button TopBar_PaymentHistoryBTN;
        private Panel AppointmentPanel;
        private Panel PaymentHistoryPanel;
        private Label label1;
        private FlowLayoutPanel PatientDisplayFlowLayout;
        private FlowLayoutPanel DoctorDisplayFlowLayout;
        private Label label2;
        private Panel panel1;
        private Button TopBar_DashboardBTN;
        private Panel DashboardPanel;
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
    }
}