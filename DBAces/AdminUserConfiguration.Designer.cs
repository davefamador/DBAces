namespace DBAces
{
    partial class AdminUserConfiguration
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
            ConfirmationBTN = new Button();
            label1 = new Label();
            UsernameInput = new TextBox();
            UserInformation = new Panel();
            label4 = new Label();
            PasswordInput = new TextBox();
            label3 = new Label();
            UserBackground = new Panel();
            doctorIDs = new Label();
            button1 = new Button();
            ChangeEmailBTN = new Button();
            EmailBox = new TextBox();
            label8 = new Label();
            PhoneNumberBox = new TextBox();
            label7 = new Label();
            LastnameBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            ChangePhoneNumber = new Button();
            label6 = new Label();
            FirstnameBox = new TextBox();
            UserInformation.SuspendLayout();
            UserBackground.SuspendLayout();
            SuspendLayout();
            // 
            // ConfirmationBTN
            // 
            ConfirmationBTN.Location = new Point(36, 389);
            ConfirmationBTN.Name = "ConfirmationBTN";
            ConfirmationBTN.Size = new Size(473, 47);
            ConfirmationBTN.TabIndex = 0;
            ConfirmationBTN.Text = "Confirm";
            ConfirmationBTN.UseVisualStyleBackColor = true;
            ConfirmationBTN.Click += ConfirmationBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 86);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(118, 145);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(306, 23);
            UsernameInput.TabIndex = 2;
            // 
            // UserInformation
            // 
            UserInformation.Controls.Add(label4);
            UserInformation.Controls.Add(PasswordInput);
            UserInformation.Controls.Add(label3);
            UserInformation.Controls.Add(ConfirmationBTN);
            UserInformation.Controls.Add(label1);
            UserInformation.Controls.Add(UsernameInput);
            UserInformation.Location = new Point(9, 12);
            UserInformation.Name = "UserInformation";
            UserInformation.Size = new Size(550, 465);
            UserInformation.TabIndex = 3;
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
            label3.Location = new Point(183, 15);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 5;
            label3.Text = "User Information";
            // 
            // UserBackground
            // 
            UserBackground.Controls.Add(doctorIDs);
            UserBackground.Controls.Add(button1);
            UserBackground.Controls.Add(ChangeEmailBTN);
            UserBackground.Controls.Add(EmailBox);
            UserBackground.Controls.Add(label8);
            UserBackground.Controls.Add(PhoneNumberBox);
            UserBackground.Controls.Add(label7);
            UserBackground.Controls.Add(LastnameBox);
            UserBackground.Controls.Add(label2);
            UserBackground.Controls.Add(label5);
            UserBackground.Controls.Add(ChangePhoneNumber);
            UserBackground.Controls.Add(label6);
            UserBackground.Controls.Add(FirstnameBox);
            UserBackground.Location = new Point(10, 7);
            UserBackground.Name = "UserBackground";
            UserBackground.Size = new Size(550, 465);
            UserBackground.TabIndex = 4;
            UserBackground.Paint += UserBackground_Paint;
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
            // ChangeEmailBTN
            // 
            ChangeEmailBTN.Location = new Point(337, 366);
            ChangeEmailBTN.Name = "ChangeEmailBTN";
            ChangeEmailBTN.Size = new Size(146, 30);
            ChangeEmailBTN.TabIndex = 12;
            ChangeEmailBTN.Text = "Change Email";
            ChangeEmailBTN.UseVisualStyleBackColor = true;
            ChangeEmailBTN.Click += ChangeEmailBTN_Click;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(286, 330);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(222, 23);
            EmailBox.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(357, 297);
            label8.Name = "label8";
            label8.Size = new Size(66, 30);
            label8.TabIndex = 10;
            label8.Text = "Email";
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(26, 330);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(208, 23);
            PhoneNumberBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 297);
            label7.Name = "label7";
            label7.Size = new Size(163, 30);
            label7.TabIndex = 8;
            label7.Text = "Phone Number";
            // 
            // LastnameBox
            // 
            LastnameBox.Location = new Point(286, 115);
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
            // ChangePhoneNumber
            // 
            ChangePhoneNumber.Location = new Point(52, 366);
            ChangePhoneNumber.Name = "ChangePhoneNumber";
            ChangePhoneNumber.Size = new Size(146, 30);
            ChangePhoneNumber.TabIndex = 0;
            ChangePhoneNumber.Text = "Change Phone Number";
            ChangePhoneNumber.UseVisualStyleBackColor = true;
            ChangePhoneNumber.Click += ChangePhoneNumber_Click;
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
            // AdminUserConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(571, 479);
            Controls.Add(UserInformation);
            Controls.Add(UserBackground);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminUserConfiguration";
            Text = "AdminUserConfiguration";
            Load += AdminUserConfiguration_Load;
            UserInformation.ResumeLayout(false);
            UserInformation.PerformLayout();
            UserBackground.ResumeLayout(false);
            UserBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ConfirmationBTN;
        private Label label1;
        private TextBox UsernameInput;
        private Panel UserInformation;
        private Label label2;
        private TextBox FirstnameBox;
        private Label label3;
        private Label label4;
        private TextBox PasswordInput;
        private Panel UserBackground;
        private Label label5;
        private Button ChangePhoneNumber;
        private Label label6;
        private TextBox LastnameBox;
        private TextBox EmailBox;
        private Label label8;
        private TextBox PhoneNumberBox;
        private Label label7;
        private Button button1;
        private Button ChangeEmailBTN;
        private Label doctorIDs;
    }
}