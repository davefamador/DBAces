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
            TopBar_UserBTN = new Button();
            UserPanel = new Panel();
            TopBar_PaymentHistoryBTN = new Button();
            button2 = new Button();
            AppointmentPanel = new Panel();
            PaymentHistoryPanel = new Panel();
            DoctorDisplayFlowLayout = new FlowLayoutPanel();
            PatientDisplayFlowLayout = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            TopbarPanel.SuspendLayout();
            UserPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TopbarPanel
            // 
            TopbarPanel.BackColor = Color.Navy;
            TopbarPanel.Controls.Add(button2);
            TopbarPanel.Controls.Add(TopBar_PaymentHistoryBTN);
            TopbarPanel.Controls.Add(TopBar_UserBTN);
            TopbarPanel.Dock = DockStyle.Top;
            TopbarPanel.Location = new Point(0, 0);
            TopbarPanel.Name = "TopbarPanel";
            TopbarPanel.Size = new Size(838, 59);
            TopbarPanel.TabIndex = 0;
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
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(172, 12);
            button2.Name = "button2";
            button2.Size = new Size(142, 37);
            button2.TabIndex = 8;
            button2.Text = "Appointments";
            button2.UseVisualStyleBackColor = false;
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
            PatientDisplayFlowLayout.Location = new Point(36, 262);
            PatientDisplayFlowLayout.Name = "PatientDisplayFlowLayout";
            PatientDisplayFlowLayout.Size = new Size(744, 148);
            PatientDisplayFlowLayout.TabIndex = 10;
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
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(DoctorDisplayFlowLayout);
            panel1.Controls.Add(PatientDisplayFlowLayout);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 504);
            panel1.TabIndex = 14;
            // 
            // AdminUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 482);
            Controls.Add(UserPanel);
            Controls.Add(AppointmentPanel);
            Controls.Add(PaymentHistoryPanel);
            Controls.Add(TopbarPanel);
            Name = "AdminUI";
            Text = "AdminUI";
            Load += AdminUI_Load;
            TopbarPanel.ResumeLayout(false);
            UserPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopbarPanel;
        private Button TopBar_UserBTN;
        private Panel UserPanel;
        private Button TopBar_PaymentHistoryBTN;
        private Button button2;
        private Panel AppointmentPanel;
        private Panel PaymentHistoryPanel;
        private Label label1;
        private FlowLayoutPanel PatientDisplayFlowLayout;
        private FlowLayoutPanel DoctorDisplayFlowLayout;
        private Label label2;
        private Panel panel1;
    }
}