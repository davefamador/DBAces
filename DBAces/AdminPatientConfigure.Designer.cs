namespace DBAces
{
    partial class AdminPatientConfigure
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
            UserBackground = new Panel();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            BirthdayBTN = new Button();
            doctorIDs = new Label();
            button1 = new Button();
            ChangeGenderBTN = new Button();
            label8 = new Label();
            label7 = new Label();
            LastnameBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            FirstnameBox = new TextBox();
            UserInformation = new Panel();
            label4 = new Label();
            PasswordInput = new TextBox();
            label3 = new Label();
            ConfirmationBTN = new Button();
            label1 = new Label();
            UsernameInput = new TextBox();
            UserBackground.SuspendLayout();
            UserInformation.SuspendLayout();
            SuspendLayout();
            // 
            // UserBackground
            // 
            UserBackground.Controls.Add(comboBox1);
            UserBackground.Controls.Add(dateTimePicker1);
            UserBackground.Controls.Add(BirthdayBTN);
            UserBackground.Controls.Add(doctorIDs);
            UserBackground.Controls.Add(button1);
            UserBackground.Controls.Add(ChangeGenderBTN);
            UserBackground.Controls.Add(label8);
            UserBackground.Controls.Add(label7);
            UserBackground.Controls.Add(LastnameBox);
            UserBackground.Controls.Add(label2);
            UserBackground.Controls.Add(label5);
            UserBackground.Controls.Add(label6);
            UserBackground.Controls.Add(FirstnameBox);
            UserBackground.Dock = DockStyle.Fill;
            UserBackground.Location = new Point(0, 0);
            UserBackground.Name = "UserBackground";
            UserBackground.Size = new Size(571, 479);
            UserBackground.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(303, 337);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(34, 337);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // BirthdayBTN
            // 
            BirthdayBTN.Location = new Point(52, 366);
            BirthdayBTN.Name = "BirthdayBTN";
            BirthdayBTN.Size = new Size(146, 30);
            BirthdayBTN.TabIndex = 16;
            BirthdayBTN.Text = "Change Birthday";
            BirthdayBTN.UseVisualStyleBackColor = true;
            BirthdayBTN.Click += BirthdayBTN_Click;
            // 
            // doctorIDs
            // 
            doctorIDs.AutoSize = true;
            doctorIDs.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorIDs.Location = new Point(3, 2);
            doctorIDs.Name = "doctorIDs";
            doctorIDs.Size = new Size(100, 30);
            doctorIDs.TabIndex = 15;
            doctorIDs.Text = "doctorID";
            // 
            // button1
            // 
            button1.Location = new Point(52, 166);
            button1.Name = "button1";
            button1.Size = new Size(431, 61);
            button1.TabIndex = 14;
            button1.Text = "Change Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChangeGenderBTN
            // 
            ChangeGenderBTN.Location = new Point(327, 366);
            ChangeGenderBTN.Name = "ChangeGenderBTN";
            ChangeGenderBTN.Size = new Size(146, 30);
            ChangeGenderBTN.TabIndex = 12;
            ChangeGenderBTN.Text = "Change Gender";
            ChangeGenderBTN.UseVisualStyleBackColor = true;
            ChangeGenderBTN.Click += ChangeGenderBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(356, 297);
            label8.Name = "label8";
            label8.Size = new Size(84, 30);
            label8.TabIndex = 10;
            label8.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 297);
            label7.Name = "label7";
            label7.Size = new Size(131, 30);
            label7.TabIndex = 8;
            label7.Text = "DateOfBirth";
            // 
            // LastnameBox
            // 
            LastnameBox.Location = new Point(302, 115);
            LastnameBox.Name = "LastnameBox";
            LastnameBox.Size = new Size(207, 23);
            LastnameBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(345, 82);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 6;
            label2.Text = "Lastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(182, 20);
            label5.Name = "label5";
            label5.Size = new Size(181, 30);
            label5.TabIndex = 5;
            label5.Text = "User Background";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 82);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 1;
            label6.Text = "Firstname";
            // 
            // FirstnameBox
            // 
            FirstnameBox.Location = new Point(26, 115);
            FirstnameBox.Name = "FirstnameBox";
            FirstnameBox.Size = new Size(208, 23);
            FirstnameBox.TabIndex = 2;
            // 
            // UserInformation
            // 
            UserInformation.Controls.Add(label4);
            UserInformation.Controls.Add(PasswordInput);
            UserInformation.Controls.Add(label3);
            UserInformation.Controls.Add(ConfirmationBTN);
            UserInformation.Controls.Add(label1);
            UserInformation.Controls.Add(UsernameInput);
            UserInformation.Dock = DockStyle.Fill;
            UserInformation.Location = new Point(0, 0);
            UserInformation.Name = "UserInformation";
            UserInformation.Size = new Size(571, 479);
            UserInformation.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(218, 225);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(118, 279);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(306, 23);
            PasswordInput.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 20);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 5;
            label3.Text = "User Information";
            // 
            // ConfirmationBTN
            // 
            ConfirmationBTN.Location = new Point(36, 389);
            ConfirmationBTN.Name = "ConfirmationBTN";
            ConfirmationBTN.Size = new Size(473, 47);
            ConfirmationBTN.TabIndex = 0;
            ConfirmationBTN.Text = "Confirm";
            ConfirmationBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 82);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(134, 144);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(306, 23);
            UsernameInput.TabIndex = 2;
            // 
            // AdminPatientConfigure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(571, 479);
            Controls.Add(UserBackground);
            Controls.Add(UserInformation);
            Name = "AdminPatientConfigure";
            Text = "AdminPatientConfigure";
            Load += AdminPatientConfigure_Load;
            UserBackground.ResumeLayout(false);
            UserBackground.PerformLayout();
            UserInformation.ResumeLayout(false);
            UserInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel UserBackground;
        private Label doctorIDs;
        private Button button1;
        private Button ChangeGenderBTN;
        private Label label8;
        private Label label7;
        private TextBox LastnameBox;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox FirstnameBox;
        private Panel UserInformation;
        private Label label4;
        private TextBox PasswordInput;
        private Label label3;
        private Button ConfirmationBTN;
        private Label label1;
        private TextBox UsernameInput;
        private Button BirthdayBTN;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}