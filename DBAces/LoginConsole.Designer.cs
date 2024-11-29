namespace DBAces
{
    partial class LoginConsole
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
            ToLoginPanel = new Panel();
            ForgetPasswordBTN = new Button();
            LabelLogin = new Label();
            UsernameLoginInput = new TextBox();
            UserLabel = new Label();
            PasswordInputLabel = new Label();
            PasswordLoginInput = new TextBox();
            CreateAccountBTN = new Button();
            LoginBTN = new Button();
            FpasswordPanel = new Panel();
            ChangeUserInformation = new Button();
            FPasswordTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            FPasswordUsernameBox = new TextBox();
            GBackPanelBTN = new Button();
            ToRegisterPanel = new Panel();
            label1 = new Label();
            UserNameRegisterInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordRegisterInput = new TextBox();
            RegisterBTN = new Button();
            ToLoginPagePanel = new Button();
            userHistory1 = new UserHistory();
            ToLoginPanel.SuspendLayout();
            FpasswordPanel.SuspendLayout();
            ToRegisterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ToLoginPanel
            // 
            ToLoginPanel.Controls.Add(ForgetPasswordBTN);
            ToLoginPanel.Controls.Add(LabelLogin);
            ToLoginPanel.Controls.Add(UsernameLoginInput);
            ToLoginPanel.Controls.Add(UserLabel);
            ToLoginPanel.Controls.Add(PasswordInputLabel);
            ToLoginPanel.Controls.Add(PasswordLoginInput);
            ToLoginPanel.Controls.Add(CreateAccountBTN);
            ToLoginPanel.Controls.Add(LoginBTN);
            ToLoginPanel.Dock = DockStyle.Fill;
            ToLoginPanel.Location = new Point(0, 0);
            ToLoginPanel.Name = "ToLoginPanel";
            ToLoginPanel.Size = new Size(317, 299);
            ToLoginPanel.TabIndex = 9;
            ToLoginPanel.Paint += ToLoginPanel_Paint;
            // 
            // ForgetPasswordBTN
            // 
            ForgetPasswordBTN.Location = new Point(166, 214);
            ForgetPasswordBTN.Name = "ForgetPasswordBTN";
            ForgetPasswordBTN.Size = new Size(117, 23);
            ForgetPasswordBTN.TabIndex = 10;
            ForgetPasswordBTN.Text = "Forget Password";
            ForgetPasswordBTN.UseVisualStyleBackColor = true;
            ForgetPasswordBTN.Click += ForgetPasswordBTN_Click;
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LabelLogin.ImeMode = ImeMode.NoControl;
            LabelLogin.Location = new Point(118, 9);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(71, 25);
            LabelLogin.TabIndex = 8;
            LabelLogin.Text = "LOGIN";
            // 
            // UsernameLoginInput
            // 
            UsernameLoginInput.Location = new Point(37, 71);
            UsernameLoginInput.Name = "UsernameLoginInput";
            UsernameLoginInput.Size = new Size(221, 23);
            UsernameLoginInput.TabIndex = 0;
            UsernameLoginInput.Text = "doctor2";
            UsernameLoginInput.TextChanged += UsernameLoginInput_TextChanged;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.ImeMode = ImeMode.NoControl;
            UserLabel.Location = new Point(37, 53);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(30, 15);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "User";
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.ImeMode = ImeMode.NoControl;
            PasswordInputLabel.Location = new Point(37, 120);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(57, 15);
            PasswordInputLabel.TabIndex = 3;
            PasswordInputLabel.Text = "Password";
            // 
            // PasswordLoginInput
            // 
            PasswordLoginInput.Location = new Point(37, 138);
            PasswordLoginInput.Name = "PasswordLoginInput";
            PasswordLoginInput.Size = new Size(221, 23);
            PasswordLoginInput.TabIndex = 4;
            PasswordLoginInput.Text = "123";
            // 
            // CreateAccountBTN
            // 
            CreateAccountBTN.ImeMode = ImeMode.NoControl;
            CreateAccountBTN.Location = new Point(37, 214);
            CreateAccountBTN.Name = "CreateAccountBTN";
            CreateAccountBTN.Size = new Size(106, 23);
            CreateAccountBTN.TabIndex = 6;
            CreateAccountBTN.Text = "Create Account";
            CreateAccountBTN.UseVisualStyleBackColor = true;
            CreateAccountBTN.Click += CreateAccountBTN_Click_1;
            // 
            // LoginBTN
            // 
            LoginBTN.ImeMode = ImeMode.NoControl;
            LoginBTN.Location = new Point(54, 185);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(183, 23);
            LoginBTN.TabIndex = 7;
            LoginBTN.Text = "Login";
            LoginBTN.UseVisualStyleBackColor = true;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // FpasswordPanel
            // 
            FpasswordPanel.Controls.Add(ChangeUserInformation);
            FpasswordPanel.Controls.Add(FPasswordTextBox);
            FpasswordPanel.Controls.Add(label5);
            FpasswordPanel.Controls.Add(label4);
            FpasswordPanel.Controls.Add(FPasswordUsernameBox);
            FpasswordPanel.Controls.Add(GBackPanelBTN);
            FpasswordPanel.Dock = DockStyle.Fill;
            FpasswordPanel.Location = new Point(0, 0);
            FpasswordPanel.Name = "FpasswordPanel";
            FpasswordPanel.Size = new Size(317, 299);
            FpasswordPanel.TabIndex = 11;
            // 
            // ChangeUserInformation
            // 
            ChangeUserInformation.Location = new Point(29, 229);
            ChangeUserInformation.Name = "ChangeUserInformation";
            ChangeUserInformation.Size = new Size(250, 34);
            ChangeUserInformation.TabIndex = 5;
            ChangeUserInformation.Text = "Change";
            ChangeUserInformation.UseVisualStyleBackColor = true;
            ChangeUserInformation.Click += ChangeUserInformation_Click;
            // 
            // FPasswordTextBox
            // 
            FPasswordTextBox.ForeColor = SystemColors.ScrollBar;
            FPasswordTextBox.Location = new Point(29, 161);
            FPasswordTextBox.Name = "FPasswordTextBox";
            FPasswordTextBox.Size = new Size(241, 23);
            FPasswordTextBox.TabIndex = 4;
            FPasswordTextBox.Text = "Input New Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 143);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 3;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 79);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 2;
            label4.Text = "UserName";
            // 
            // FPasswordUsernameBox
            // 
            FPasswordUsernameBox.ForeColor = SystemColors.ScrollBar;
            FPasswordUsernameBox.Location = new Point(29, 100);
            FPasswordUsernameBox.Name = "FPasswordUsernameBox";
            FPasswordUsernameBox.Size = new Size(241, 23);
            FPasswordUsernameBox.TabIndex = 1;
            FPasswordUsernameBox.Text = "Input Username";
            // 
            // GBackPanelBTN
            // 
            GBackPanelBTN.Location = new Point(11, 9);
            GBackPanelBTN.Name = "GBackPanelBTN";
            GBackPanelBTN.Size = new Size(75, 25);
            GBackPanelBTN.TabIndex = 0;
            GBackPanelBTN.Text = "Go Back";
            GBackPanelBTN.UseVisualStyleBackColor = true;
            GBackPanelBTN.Click += GBackPanelBTN_Click;
            // 
            // ToRegisterPanel
            // 
            ToRegisterPanel.Controls.Add(label1);
            ToRegisterPanel.Controls.Add(UserNameRegisterInput);
            ToRegisterPanel.Controls.Add(label2);
            ToRegisterPanel.Controls.Add(label3);
            ToRegisterPanel.Controls.Add(PasswordRegisterInput);
            ToRegisterPanel.Controls.Add(RegisterBTN);
            ToRegisterPanel.Controls.Add(ToLoginPagePanel);
            ToRegisterPanel.Controls.Add(userHistory1);
            ToRegisterPanel.Dock = DockStyle.Fill;
            ToRegisterPanel.Location = new Point(0, 0);
            ToRegisterPanel.Name = "ToRegisterPanel";
            ToRegisterPanel.Size = new Size(317, 299);
            ToRegisterPanel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(118, 32);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 14;
            label1.Text = "REGISTER";
            // 
            // UserNameRegisterInput
            // 
            UserNameRegisterInput.Location = new Point(37, 94);
            UserNameRegisterInput.Name = "UserNameRegisterInput";
            UserNameRegisterInput.Size = new Size(221, 23);
            UserNameRegisterInput.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(37, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(37, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // PasswordRegisterInput
            // 
            PasswordRegisterInput.Location = new Point(37, 161);
            PasswordRegisterInput.Name = "PasswordRegisterInput";
            PasswordRegisterInput.Size = new Size(221, 23);
            PasswordRegisterInput.TabIndex = 12;
            // 
            // RegisterBTN
            // 
            RegisterBTN.ImeMode = ImeMode.NoControl;
            RegisterBTN.Location = new Point(54, 208);
            RegisterBTN.Name = "RegisterBTN";
            RegisterBTN.Size = new Size(204, 38);
            RegisterBTN.TabIndex = 13;
            RegisterBTN.Text = "Register";
            RegisterBTN.UseVisualStyleBackColor = true;
            RegisterBTN.Click += RegisterBTN_Click;
            // 
            // ToLoginPagePanel
            // 
            ToLoginPagePanel.BackgroundImageLayout = ImageLayout.None;
            ToLoginPagePanel.FlatAppearance.BorderSize = 0;
            ToLoginPagePanel.FlatStyle = FlatStyle.System;
            ToLoginPagePanel.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            ToLoginPagePanel.ImeMode = ImeMode.NoControl;
            ToLoginPagePanel.Location = new Point(3, 269);
            ToLoginPagePanel.Name = "ToLoginPagePanel";
            ToLoginPagePanel.Size = new Size(109, 23);
            ToLoginPagePanel.TabIndex = 1;
            ToLoginPagePanel.Text = "Back To Login Page";
            ToLoginPagePanel.UseVisualStyleBackColor = true;
            ToLoginPagePanel.Click += ToLoginPagePanel_Click;
            // 
            // userHistory1
            // 
            userHistory1.Location = new Point(78, 68);
            userHistory1.Name = "userHistory1";
            userHistory1.Size = new Size(8, 8);
            userHistory1.TabIndex = 0;
            // 
            // LoginConsole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 299);
            Controls.Add(ToLoginPanel);
            Controls.Add(FpasswordPanel);
            Controls.Add(ToRegisterPanel);
            Name = "LoginConsole";
            Text = "LoginConsole";
            Load += LoginConsole_Load;
            ToLoginPanel.ResumeLayout(false);
            ToLoginPanel.PerformLayout();
            FpasswordPanel.ResumeLayout(false);
            FpasswordPanel.PerformLayout();
            ToRegisterPanel.ResumeLayout(false);
            ToRegisterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ToLoginPanel;
        private Label LabelLogin;
        private TextBox UsernameLoginInput;
        private Label UserLabel;
        private Label PasswordInputLabel;
        private TextBox PasswordLoginInput;
        private Button CreateAccountBTN;
        private Button LoginBTN;
        private Panel ToRegisterPanel;
        private Label label1;
        private TextBox UserNameRegisterInput;
        private Label label2;
        private Label label3;
        private TextBox PasswordRegisterInput;
        private Button RegisterBTN;
        private Button ToLoginPagePanel;
        private UserHistory userHistory1;
        private Button ForgetPasswordBTN;
        private Panel FpasswordPanel;
        private Button GBackPanelBTN;
        private Button ChangeUserInformation;
        private TextBox FPasswordTextBox;
        private Label label5;
        private Label label4;
        private TextBox FPasswordUsernameBox;
    }
}