namespace DBAces
{
    partial class AdminPatientConfiguration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserIDLabel = new Label();
            label2 = new Label();
            PatientNameLabel = new Label();
            PatientDateOfBirth = new Label();
            label4 = new Label();
            PatientGenderLabel = new Label();
            label5 = new Label();
            label3 = new Label();
            PatientUsernameLabel = new Label();
            label7 = new Label();
            PatientPasswordLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            BalanceLABEL = new Label();
            SuspendLayout();
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIDLabel.ForeColor = Color.White;
            UserIDLabel.Location = new Point(3, 0);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(44, 15);
            UserIDLabel.TabIndex = 0;
            UserIDLabel.Text = "userID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(239, 58);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "Date Of Birth";
            // 
            // PatientNameLabel
            // 
            PatientNameLabel.AutoSize = true;
            PatientNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PatientNameLabel.ForeColor = SystemColors.Window;
            PatientNameLabel.Location = new Point(270, 39);
            PatientNameLabel.Name = "PatientNameLabel";
            PatientNameLabel.Size = new Size(132, 19);
            PatientNameLabel.TabIndex = 2;
            PatientNameLabel.Text = "PatientNameLabel";
            // 
            // PatientDateOfBirth
            // 
            PatientDateOfBirth.AutoSize = true;
            PatientDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PatientDateOfBirth.ForeColor = SystemColors.Window;
            PatientDateOfBirth.Location = new Point(270, 79);
            PatientDateOfBirth.Name = "PatientDateOfBirth";
            PatientDateOfBirth.Size = new Size(135, 19);
            PatientDateOfBirth.TabIndex = 4;
            PatientDateOfBirth.Text = "PatientDateOfBirth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(239, 18);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 3;
            label4.Text = "Doctor Name";
            label4.Click += label4_Click;
            // 
            // PatientGenderLabel
            // 
            PatientGenderLabel.AutoSize = true;
            PatientGenderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PatientGenderLabel.ForeColor = SystemColors.Window;
            PatientGenderLabel.Location = new Point(468, 79);
            PatientGenderLabel.Name = "PatientGenderLabel";
            PatientGenderLabel.Size = new Size(105, 19);
            PatientGenderLabel.TabIndex = 6;
            PatientGenderLabel.Text = "PatientGender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(485, 58);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 5;
            label5.Text = "Gender";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 18);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 8;
            label3.Text = "Patient Username";
            // 
            // PatientUsernameLabel
            // 
            PatientUsernameLabel.AutoSize = true;
            PatientUsernameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PatientUsernameLabel.ForeColor = SystemColors.Window;
            PatientUsernameLabel.Location = new Point(44, 39);
            PatientUsernameLabel.Name = "PatientUsernameLabel";
            PatientUsernameLabel.Size = new Size(158, 19);
            PatientUsernameLabel.TabIndex = 7;
            PatientUsernameLabel.Text = "DoctorUsernameLabel";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 58);
            label7.Name = "label7";
            label7.Size = new Size(141, 21);
            label7.TabIndex = 10;
            label7.Text = "Patient Password";
            // 
            // PatientPasswordLabel
            // 
            PatientPasswordLabel.AutoSize = true;
            PatientPasswordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PatientPasswordLabel.ForeColor = SystemColors.Window;
            PatientPasswordLabel.Location = new Point(44, 79);
            PatientPasswordLabel.Name = "PatientPasswordLabel";
            PatientPasswordLabel.Size = new Size(155, 19);
            PatientPasswordLabel.TabIndex = 9;
            PatientPasswordLabel.Text = "DoctorPasswordLabel";
            // 
            // button1
            // 
            button1.Location = new Point(270, 133);
            button1.Name = "button1";
            button1.Size = new Size(289, 53);
            button1.TabIndex = 11;
            button1.Text = "Configure Doctor Information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 133);
            button2.Name = "button2";
            button2.Size = new Size(227, 53);
            button2.TabIndex = 12;
            button2.Text = "Configure Doctor User Information";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(468, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 13;
            label1.Text = "BALANCE";
            // 
            // button3
            // 
            button3.Location = new Point(602, 99);
            button3.Name = "button3";
            button3.Size = new Size(113, 78);
            button3.TabIndex = 15;
            button3.Text = "DELETE USER";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BalanceLABEL
            // 
            BalanceLABEL.AutoSize = true;
            BalanceLABEL.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BalanceLABEL.ForeColor = Color.White;
            BalanceLABEL.Location = new Point(591, 18);
            BalanceLABEL.Name = "BalanceLABEL";
            BalanceLABEL.Size = new Size(82, 21);
            BalanceLABEL.TabIndex = 16;
            BalanceLABEL.Text = "BALANCE";
            // 
            // AdminPatientConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(BalanceLABEL);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(PatientPasswordLabel);
            Controls.Add(label3);
            Controls.Add(PatientUsernameLabel);
            Controls.Add(PatientGenderLabel);
            Controls.Add(label5);
            Controls.Add(PatientDateOfBirth);
            Controls.Add(label4);
            Controls.Add(PatientNameLabel);
            Controls.Add(label2);
            Controls.Add(UserIDLabel);
            Name = "AdminPatientConfiguration";
            Size = new Size(737, 203);
            Load += AdminPatientConfiguration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserIDLabel;
        private Label label2;
        private Label PatientNameLabel;
        private Label PatientDateOfBirth;
        private Label label4;
        private Label PatientGenderLabel;
        private Label label5;
        private Label label3;
        private Label PatientUsernameLabel;
        private Label label7;
        private Label PatientPasswordLabel;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label6;
        private Button button3;
        private Label BalanceLABEL;
    }
}
