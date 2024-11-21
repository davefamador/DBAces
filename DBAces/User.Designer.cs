namespace DBAces
{
    partial class User
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
            panel1 = new Panel();
            UserBalanceLabel = new Label();
            BalanceLabel = new Label();
            SettingBTN = new Button();
            HistoryBTN = new Button();
            AppointmentBTN = new Button();
            HistoryPanel = new Panel();
            UserHistoryFlowPanel = new FlowLayoutPanel();
            label3 = new Label();
            AppointmentPanel = new Panel();
            UserSetting = new Panel();
            UserAddBalanceBTN = new Button();
            panel3 = new Panel();
            button2 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            UsersPassword = new Label();
            PasswordLABEL = new Label();
            UsersUsername = new Label();
            label2 = new Label();
            label1 = new Label();
            AddBalancePanel = new Panel();
            panel1.SuspendLayout();
            HistoryPanel.SuspendLayout();
            UserSetting.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(UserBalanceLabel);
            panel1.Controls.Add(BalanceLabel);
            panel1.Controls.Add(SettingBTN);
            panel1.Controls.Add(HistoryBTN);
            panel1.Controls.Add(AppointmentBTN);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 64);
            panel1.TabIndex = 0;
            // 
            // UserBalanceLabel
            // 
            UserBalanceLabel.AutoSize = true;
            UserBalanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UserBalanceLabel.ForeColor = SystemColors.Control;
            UserBalanceLabel.Location = new Point(704, 20);
            UserBalanceLabel.Name = "UserBalanceLabel";
            UserBalanceLabel.Size = new Size(46, 21);
            UserBalanceLabel.TabIndex = 8;
            UserBalanceLabel.Text = "1000";
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BalanceLabel.ForeColor = SystemColors.Control;
            BalanceLabel.Location = new Point(611, 20);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(78, 21);
            BalanceLabel.TabIndex = 6;
            BalanceLabel.Text = "Balance :";
            // 
            // SettingBTN
            // 
            SettingBTN.BackColor = Color.Transparent;
            SettingBTN.FlatAppearance.BorderSize = 0;
            SettingBTN.FlatStyle = FlatStyle.Flat;
            SettingBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingBTN.ForeColor = SystemColors.Control;
            SettingBTN.Location = new Point(295, 12);
            SettingBTN.Name = "SettingBTN";
            SettingBTN.Size = new Size(126, 37);
            SettingBTN.TabIndex = 5;
            SettingBTN.Text = "Setting";
            SettingBTN.UseVisualStyleBackColor = false;
            SettingBTN.Click += SettingBTN_Click;
            // 
            // HistoryBTN
            // 
            HistoryBTN.BackColor = Color.Transparent;
            HistoryBTN.FlatAppearance.BorderSize = 0;
            HistoryBTN.FlatStyle = FlatStyle.Flat;
            HistoryBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HistoryBTN.ForeColor = SystemColors.Control;
            HistoryBTN.Location = new Point(179, 12);
            HistoryBTN.Name = "HistoryBTN";
            HistoryBTN.Size = new Size(126, 37);
            HistoryBTN.TabIndex = 4;
            HistoryBTN.Text = "History";
            HistoryBTN.UseVisualStyleBackColor = false;
            HistoryBTN.Click += HistoryBTN_Click;
            // 
            // AppointmentBTN
            // 
            AppointmentBTN.BackColor = Color.Transparent;
            AppointmentBTN.BackgroundImageLayout = ImageLayout.Center;
            AppointmentBTN.Cursor = Cursors.Hand;
            AppointmentBTN.FlatAppearance.BorderSize = 0;
            AppointmentBTN.FlatStyle = FlatStyle.Flat;
            AppointmentBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentBTN.ForeColor = SystemColors.Control;
            AppointmentBTN.Location = new Point(39, 12);
            AppointmentBTN.Name = "AppointmentBTN";
            AppointmentBTN.Size = new Size(134, 37);
            AppointmentBTN.TabIndex = 1;
            AppointmentBTN.Text = "Appointment";
            AppointmentBTN.UseVisualStyleBackColor = false;
            AppointmentBTN.Click += AppointmentBTN_Click;
            // 
            // HistoryPanel
            // 
            HistoryPanel.Controls.Add(UserHistoryFlowPanel);
            HistoryPanel.Controls.Add(label3);
            HistoryPanel.Dock = DockStyle.Fill;
            HistoryPanel.Location = new Point(0, 64);
            HistoryPanel.Name = "HistoryPanel";
            HistoryPanel.Size = new Size(823, 460);
            HistoryPanel.TabIndex = 1;
            HistoryPanel.Paint += HistoryPanel_Paint;
            // 
            // UserHistoryFlowPanel
            // 
            UserHistoryFlowPanel.Location = new Point(45, 77);
            UserHistoryFlowPanel.Name = "UserHistoryFlowPanel";
            UserHistoryFlowPanel.Size = new Size(742, 356);
            UserHistoryFlowPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 15);
            label3.Name = "label3";
            label3.Size = new Size(131, 45);
            label3.TabIndex = 1;
            label3.Text = "History";
            // 
            // AppointmentPanel
            // 
            AppointmentPanel.Dock = DockStyle.Fill;
            AppointmentPanel.Location = new Point(0, 64);
            AppointmentPanel.Name = "AppointmentPanel";
            AppointmentPanel.Size = new Size(823, 460);
            AppointmentPanel.TabIndex = 2;
            // 
            // UserSetting
            // 
            UserSetting.Controls.Add(UserAddBalanceBTN);
            UserSetting.Controls.Add(panel3);
            UserSetting.Controls.Add(panel2);
            UserSetting.Controls.Add(label1);
            UserSetting.Dock = DockStyle.Fill;
            UserSetting.Location = new Point(0, 64);
            UserSetting.Name = "UserSetting";
            UserSetting.Size = new Size(823, 460);
            UserSetting.TabIndex = 0;
            UserSetting.Paint += UserSetting_Paint;
            // 
            // UserAddBalanceBTN
            // 
            UserAddBalanceBTN.Location = new Point(658, 29);
            UserAddBalanceBTN.Name = "UserAddBalanceBTN";
            UserAddBalanceBTN.Size = new Size(129, 75);
            UserAddBalanceBTN.TabIndex = 10;
            UserAddBalanceBTN.Text = "ADD BALANCE";
            UserAddBalanceBTN.UseVisualStyleBackColor = true;
            UserAddBalanceBTN.Click += UserAddBalanceBTN_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(389, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 225);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(100, 165);
            button2.Name = "button2";
            button2.Size = new Size(213, 41);
            button2.TabIndex = 6;
            button2.Text = "Change User Information";
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(242, 38);
            label11.Name = "label11";
            label11.Size = new Size(94, 21);
            label11.TabIndex = 9;
            label11.Text = "10/29/2003";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(269, 109);
            label10.Name = "label10";
            label10.Size = new Size(44, 21);
            label10.TabIndex = 8;
            label10.Text = "Male";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.Location = new Point(222, 7);
            label9.Name = "label9";
            label9.Size = new Size(140, 28);
            label9.TabIndex = 7;
            label9.Text = "Date Of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(256, 80);
            label8.Name = "label8";
            label8.Size = new Size(80, 28);
            label8.TabIndex = 6;
            label8.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(31, 111);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 5;
            label4.Text = "DashM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(17, 80);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 4;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(28, 44);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 3;
            label6.Text = "DashM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(14, 13);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 2;
            label7.Text = "First Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(UsersPassword);
            panel2.Controls.Add(PasswordLABEL);
            panel2.Controls.Add(UsersUsername);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(45, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 124);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(167, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 64);
            button1.TabIndex = 3;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            // 
            // UsersPassword
            // 
            UsersPassword.AutoSize = true;
            UsersPassword.Location = new Point(28, 100);
            UsersPassword.Name = "UsersPassword";
            UsersPassword.Size = new Size(91, 15);
            UsersPassword.TabIndex = 5;
            UsersPassword.Text = "12321312312321";
            // 
            // PasswordLABEL
            // 
            PasswordLABEL.AutoSize = true;
            PasswordLABEL.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PasswordLABEL.Location = new Point(14, 69);
            PasswordLABEL.Name = "PasswordLABEL";
            PasswordLABEL.Size = new Size(82, 21);
            PasswordLABEL.TabIndex = 4;
            PasswordLABEL.Text = "Password";
            // 
            // UsersUsername
            // 
            UsersUsername.AutoSize = true;
            UsersUsername.Location = new Point(28, 44);
            UsersUsername.Name = "UsersUsername";
            UsersUsername.Size = new Size(44, 15);
            UsersUsername.TabIndex = 3;
            UsersUsername.Text = "DashM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 29);
            label1.Name = "label1";
            label1.Size = new Size(152, 45);
            label1.TabIndex = 0;
            label1.Text = "SETTING";
            // 
            // AddBalancePanel
            // 
            AddBalancePanel.Dock = DockStyle.Fill;
            AddBalancePanel.Location = new Point(0, 64);
            AddBalancePanel.Name = "AddBalancePanel";
            AddBalancePanel.Size = new Size(823, 460);
            AddBalancePanel.TabIndex = 11;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 524);
            Controls.Add(UserSetting);
            Controls.Add(AddBalancePanel);
            Controls.Add(HistoryPanel);
            Controls.Add(AppointmentPanel);
            Controls.Add(panel1);
            Name = "User";
            Text = "University Of Cebu Health Appointment";
            Load += User_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HistoryPanel.ResumeLayout(false);
            HistoryPanel.PerformLayout();
            UserSetting.ResumeLayout(false);
            UserSetting.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AppointmentBTN;
        private Panel HistoryPanel;
        private Panel AppointmentPanel;
        private Panel UserSetting;
        private Button SettingBTN;
        private Button HistoryBTN;
        private Panel panel2;
        private Label UsersPassword;
        private Label PasswordLABEL;
        private Label UsersUsername;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Button button2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private FlowLayoutPanel UserHistoryFlowPanel;
        private Label label3;
        private Label UserBalanceLabel;
        private Label BalanceLabel;
        private Button UserAddBalanceBTN;
        private Panel AddBalancePanel;
    }
}