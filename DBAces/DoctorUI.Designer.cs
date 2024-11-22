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
            DoctorNameLabel = new Label();
            label3 = new Label();
            UserDoctorSpecializationLabel = new Label();
            label2 = new Label();
            DoctorPhoneNumberLabel = new Label();
            label100 = new Label();
            DoctorEmailLabel = new Label();
            label4 = new Label();
            TopBar = new Panel();
            Appointment = new Panel();
            History_Sale = new Panel();
            button2 = new Button();
            button1 = new Button();
            AppointmentBTN = new Button();
            Setting = new Panel();
            History_Sale.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 89);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR ID";
            // 
            // DoctorID
            // 
            DoctorID.AutoSize = true;
            DoctorID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorID.Location = new Point(247, 89);
            DoctorID.Name = "DoctorID";
            DoctorID.Size = new Size(113, 37);
            DoctorID.TabIndex = 1;
            DoctorID.Text = "123123";
            DoctorID.Click += DoctorID_Click;
            // 
            // DoctorNameLabel
            // 
            DoctorNameLabel.AutoSize = true;
            DoctorNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorNameLabel.Location = new Point(172, 232);
            DoctorNameLabel.Name = "DoctorNameLabel";
            DoctorNameLabel.Size = new Size(132, 37);
            DoctorNameLabel.TabIndex = 2;
            DoctorNameLabel.Text = "asdasdas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 195);
            label3.Name = "label3";
            label3.Size = new Size(189, 37);
            label3.TabIndex = 3;
            label3.Text = "Doctor Name";
            // 
            // UserDoctorSpecializationLabel
            // 
            UserDoctorSpecializationLabel.AutoSize = true;
            UserDoctorSpecializationLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserDoctorSpecializationLabel.Location = new Point(172, 315);
            UserDoctorSpecializationLabel.Name = "UserDoctorSpecializationLabel";
            UserDoctorSpecializationLabel.Size = new Size(132, 37);
            UserDoctorSpecializationLabel.TabIndex = 4;
            UserDoctorSpecializationLabel.Text = "asdasdas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 278);
            label2.Name = "label2";
            label2.Size = new Size(196, 37);
            label2.TabIndex = 5;
            label2.Text = "Specialization";
            // 
            // DoctorPhoneNumberLabel
            // 
            DoctorPhoneNumberLabel.AutoSize = true;
            DoctorPhoneNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorPhoneNumberLabel.Location = new Point(552, 243);
            DoctorPhoneNumberLabel.Name = "DoctorPhoneNumberLabel";
            DoctorPhoneNumberLabel.Size = new Size(132, 37);
            DoctorPhoneNumberLabel.TabIndex = 6;
            DoctorPhoneNumberLabel.Text = "asdasdas";
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label100.Location = new Point(445, 206);
            label100.Name = "label100";
            label100.Size = new Size(210, 37);
            label100.TabIndex = 7;
            label100.Text = "Phone Number";
            // 
            // DoctorEmailLabel
            // 
            DoctorEmailLabel.AutoSize = true;
            DoctorEmailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorEmailLabel.Location = new Point(541, 331);
            DoctorEmailLabel.Name = "DoctorEmailLabel";
            DoctorEmailLabel.Size = new Size(132, 37);
            DoctorEmailLabel.TabIndex = 8;
            DoctorEmailLabel.Text = "asdasdas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(475, 294);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // TopBar
            // 
            TopBar.Dock = DockStyle.Fill;
            TopBar.Location = new Point(0, 75);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(752, 375);
            TopBar.TabIndex = 10;
            // 
            // Appointment
            // 
            Appointment.Dock = DockStyle.Fill;
            Appointment.Location = new Point(0, 75);
            Appointment.Name = "Appointment";
            Appointment.Size = new Size(752, 375);
            Appointment.TabIndex = 11;
            // 
            // History_Sale
            // 
            History_Sale.BackColor = Color.Brown;
            History_Sale.Controls.Add(button2);
            History_Sale.Controls.Add(button1);
            History_Sale.Controls.Add(AppointmentBTN);
            History_Sale.Dock = DockStyle.Top;
            History_Sale.Location = new Point(0, 0);
            History_Sale.Name = "History_Sale";
            History_Sale.Size = new Size(752, 75);
            History_Sale.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(597, 12);
            button2.Name = "button2";
            button2.Size = new Size(143, 47);
            button2.TabIndex = 12;
            button2.Text = "Settings";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(191, 22);
            button1.Name = "button1";
            button1.Size = new Size(132, 37);
            button1.TabIndex = 11;
            button1.Text = "History / Sales";
            button1.UseVisualStyleBackColor = false;
            // 
            // AppointmentBTN
            // 
            AppointmentBTN.BackColor = Color.Transparent;
            AppointmentBTN.FlatAppearance.BorderSize = 0;
            AppointmentBTN.FlatStyle = FlatStyle.Flat;
            AppointmentBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentBTN.ForeColor = SystemColors.Control;
            AppointmentBTN.Location = new Point(22, 22);
            AppointmentBTN.Name = "AppointmentBTN";
            AppointmentBTN.Size = new Size(132, 37);
            AppointmentBTN.TabIndex = 10;
            AppointmentBTN.Text = "Appointments";
            AppointmentBTN.UseVisualStyleBackColor = false;
            // 
            // Setting
            // 
            Setting.Dock = DockStyle.Fill;
            Setting.Location = new Point(0, 0);
            Setting.Name = "Setting";
            Setting.Size = new Size(752, 450);
            Setting.TabIndex = 13;
            // 
            // DoctorUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 450);
            Controls.Add(TopBar);
            Controls.Add(Appointment);
            Controls.Add(History_Sale);
            Controls.Add(Setting);
            Controls.Add(label4);
            Controls.Add(DoctorEmailLabel);
            Controls.Add(label100);
            Controls.Add(DoctorPhoneNumberLabel);
            Controls.Add(label2);
            Controls.Add(UserDoctorSpecializationLabel);
            Controls.Add(label3);
            Controls.Add(DoctorNameLabel);
            Controls.Add(DoctorID);
            Controls.Add(label1);
            Name = "DoctorUI";
            Text = "DoctorUI";
            Load += DoctorUI_Load;
            History_Sale.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label DoctorID;
        private Label DoctorNameLabel;
        private Label label3;
        private Label UserDoctorSpecializationLabel;
        private Label label2;
        private Label DoctorPhoneNumberLabel;
        private Label label100;
        private Label DoctorEmailLabel;
        private Label label4;
        private Panel TopBar;
        private Panel Appointment;
        private Panel History_Sale;
        private Panel Setting;
        private Button button2;
        private Button button1;
        private Button AppointmentBTN;
    }
}