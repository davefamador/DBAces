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
            label2 = new Label();
            UserDoctorSpecializationLabel = new Label();
            label100 = new Label();
            DoctorPhoneNumberLabel = new Label();
            label4 = new Label();
            DoctorEmailLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR ID";
            // 
            // DoctorID
            // 
            DoctorID.AutoSize = true;
            DoctorID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorID.Location = new Point(210, 9);
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
            DoctorNameLabel.Location = new Point(135, 152);
            DoctorNameLabel.Name = "DoctorNameLabel";
            DoctorNameLabel.Size = new Size(132, 37);
            DoctorNameLabel.TabIndex = 2;
            DoctorNameLabel.Text = "asdasdas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 115);
            label3.Name = "label3";
            label3.Size = new Size(189, 37);
            label3.TabIndex = 3;
            label3.Text = "Doctor Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 198);
            label2.Name = "label2";
            label2.Size = new Size(196, 37);
            label2.TabIndex = 5;
            label2.Text = "Specialization";
            // 
            // UserDoctorSpecializationLabel
            // 
            UserDoctorSpecializationLabel.AutoSize = true;
            UserDoctorSpecializationLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserDoctorSpecializationLabel.Location = new Point(135, 235);
            UserDoctorSpecializationLabel.Name = "UserDoctorSpecializationLabel";
            UserDoctorSpecializationLabel.Size = new Size(132, 37);
            UserDoctorSpecializationLabel.TabIndex = 4;
            UserDoctorSpecializationLabel.Text = "asdasdas";
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label100.Location = new Point(408, 126);
            label100.Name = "label100";
            label100.Size = new Size(210, 37);
            label100.TabIndex = 7;
            label100.Text = "Phone Number";
            // 
            // DoctorPhoneNumberLabel
            // 
            DoctorPhoneNumberLabel.AutoSize = true;
            DoctorPhoneNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorPhoneNumberLabel.Location = new Point(515, 163);
            DoctorPhoneNumberLabel.Name = "DoctorPhoneNumberLabel";
            DoctorPhoneNumberLabel.Size = new Size(132, 37);
            DoctorPhoneNumberLabel.TabIndex = 6;
            DoctorPhoneNumberLabel.Text = "asdasdas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(438, 214);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // DoctorEmailLabel
            // 
            DoctorEmailLabel.AutoSize = true;
            DoctorEmailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorEmailLabel.Location = new Point(504, 251);
            DoctorEmailLabel.Name = "DoctorEmailLabel";
            DoctorEmailLabel.Size = new Size(132, 37);
            DoctorEmailLabel.TabIndex = 8;
            DoctorEmailLabel.Text = "asdasdas";
            // 
            // DoctorUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 450);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label DoctorID;
        private Label DoctorNameLabel;
        private Label label3;
        private Label label2;
        private Label UserDoctorSpecializationLabel;
        private Label label100;
        private Label DoctorPhoneNumberLabel;
        private Label label4;
        private Label DoctorEmailLabel;
    }
}