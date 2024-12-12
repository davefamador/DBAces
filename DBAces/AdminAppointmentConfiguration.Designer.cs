namespace DBAces
{
    partial class AdminAppointmentConfiguration
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
            label2 = new Label();
            PatientName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            DoctorName = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            UpdateBTN = new Button();
            label7 = new Label();
            ConditionRBox = new RichTextBox();
            TreatmentsRBox = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "Patient Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 19);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 1;
            label2.Text = "Doctor Name";
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientName.Location = new Point(39, 47);
            PatientName.Name = "PatientName";
            PatientName.Size = new Size(142, 28);
            PatientName.TabIndex = 2;
            PatientName.Text = "Patient Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PatientName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 108);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(DoctorName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(294, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 108);
            panel2.TabIndex = 4;
            // 
            // DoctorName
            // 
            DoctorName.AutoSize = true;
            DoctorName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorName.Location = new Point(49, 47);
            DoctorName.Name = "DoctorName";
            DoctorName.Size = new Size(139, 28);
            DoctorName.TabIndex = 2;
            DoctorName.Text = "Doctor Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 148);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 3;
            label5.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DIAGNOSE", "CANCELLED", "FINISHED", "PENDING" });
            comboBox1.Location = new Point(51, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(363, 148);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 6;
            label6.Text = "Issue";
            // 
            // UpdateBTN
            // 
            UpdateBTN.Location = new Point(71, 208);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(111, 23);
            UpdateBTN.TabIndex = 7;
            UpdateBTN.Text = "Update";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(294, 176);
            label7.Name = "label7";
            label7.Size = new Size(109, 28);
            label7.TabIndex = 8;
            label7.Text = "IssueLabel";
            // 
            // ConditionRBox
            // 
            ConditionRBox.Location = new Point(33, 313);
            ConditionRBox.Name = "ConditionRBox";
            ConditionRBox.Size = new Size(242, 77);
            ConditionRBox.TabIndex = 9;
            ConditionRBox.Text = "";
            // 
            // TreatmentsRBox
            // 
            TreatmentsRBox.Location = new Point(294, 313);
            TreatmentsRBox.Name = "TreatmentsRBox";
            TreatmentsRBox.Size = new Size(242, 77);
            TreatmentsRBox.TabIndex = 10;
            TreatmentsRBox.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(82, 396);
            button2.Name = "button2";
            button2.Size = new Size(111, 41);
            button2.TabIndex = 12;
            button2.Text = "Modify Condition";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(363, 396);
            button3.Name = "button3";
            button3.Size = new Size(111, 41);
            button3.TabIndex = 13;
            button3.Text = "Modify Treatment";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(96, 282);
            label8.Name = "label8";
            label8.Size = new Size(104, 28);
            label8.TabIndex = 14;
            label8.Text = "Condition";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(363, 282);
            label9.Name = "label9";
            label9.Size = new Size(118, 28);
            label9.TabIndex = 15;
            label9.Text = "Treatments";
            // 
            // AdminAppointmentConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(581, 449);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(TreatmentsRBox);
            Controls.Add(ConditionRBox);
            Controls.Add(label7);
            Controls.Add(UpdateBTN);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAppointmentConfiguration";
            Text = "AdminAppointmentConfiguration";
            Load += AdminAppointmentConfiguration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label PatientName;
        private Panel panel1;
        private Panel panel2;
        private Label DoctorName;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Button UpdateBTN;
        private Label label7;
        private RichTextBox ConditionRBox;
        private RichTextBox TreatmentsRBox;
        private Button button2;
        private Button button3;
        private Label label8;
        private Label label9;
    }
}