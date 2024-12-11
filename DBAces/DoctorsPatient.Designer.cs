namespace DBAces
{
    partial class DoctorsPatient
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
            button1 = new Button();
            PatientName = new Label();
            label2 = new Label();
            label210 = new Label();
            label4 = new Label();
            PatientBirthday = new Label();
            PatientGender = new Label();
            label1 = new Label();
            label3 = new Label();
            IssueBox = new RichTextBox();
            PatientDate = new Label();
            AppointmentIDLabel1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(615, 20);
            button1.Name = "button1";
            button1.Size = new Size(118, 84);
            button1.TabIndex = 0;
            button1.Text = "Diagnosis";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new Font("Segoe UI", 14F);
            PatientName.ForeColor = Color.White;
            PatientName.Location = new Point(165, 20);
            PatientName.Name = "PatientName";
            PatientName.Size = new Size(125, 25);
            PatientName.TabIndex = 1;
            PatientName.Text = "Patient Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 20);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 2;
            label2.Text = "Patient Name  :";
            // 
            // label210
            // 
            label210.AutoSize = true;
            label210.Font = new Font("Segoe UI", 14F);
            label210.ForeColor = Color.White;
            label210.Location = new Point(14, 58);
            label210.Name = "label210";
            label210.Size = new Size(136, 25);
            label210.TabIndex = 3;
            label210.Text = "Birthday          :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 101);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender           :";
            // 
            // PatientBirthday
            // 
            PatientBirthday.AutoSize = true;
            PatientBirthday.Font = new Font("Segoe UI", 14F);
            PatientBirthday.ForeColor = Color.White;
            PatientBirthday.Location = new Point(165, 58);
            PatientBirthday.MaximumSize = new Size(111, 25);
            PatientBirthday.Name = "PatientBirthday";
            PatientBirthday.Size = new Size(111, 25);
            PatientBirthday.TabIndex = 5;
            PatientBirthday.Text = "Birthdayasd";
            PatientBirthday.TextAlign = ContentAlignment.TopCenter;
            // 
            // PatientGender
            // 
            PatientGender.AutoSize = true;
            PatientGender.Font = new Font("Segoe UI", 14F);
            PatientGender.ForeColor = Color.White;
            PatientGender.Location = new Point(165, 101);
            PatientGender.Name = "PatientGender";
            PatientGender.Size = new Size(137, 25);
            PatientGender.TabIndex = 6;
            PatientGender.Text = "Patient Gender";
            PatientGender.Click += PatientGender_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(340, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 7;
            label1.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(340, 79);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 8;
            label3.Text = "Issue";
            // 
            // IssueBox
            // 
            IssueBox.Location = new Point(400, 52);
            IssueBox.Name = "IssueBox";
            IssueBox.ReadOnly = true;
            IssueBox.Size = new Size(192, 83);
            IssueBox.TabIndex = 9;
            IssueBox.Text = "";
            // 
            // PatientDate
            // 
            PatientDate.AutoSize = true;
            PatientDate.Font = new Font("Segoe UI", 14F);
            PatientDate.ForeColor = Color.White;
            PatientDate.Location = new Point(400, 20);
            PatientDate.Name = "PatientDate";
            PatientDate.Size = new Size(125, 25);
            PatientDate.TabIndex = 10;
            PatientDate.Text = "Patient Name";
            // 
            // AppointmentIDLabel1
            // 
            AppointmentIDLabel1.AutoSize = true;
            AppointmentIDLabel1.Font = new Font("Segoe UI", 7F);
            AppointmentIDLabel1.ForeColor = Color.White;
            AppointmentIDLabel1.Location = new Point(3, 0);
            AppointmentIDLabel1.Name = "AppointmentIDLabel1";
            AppointmentIDLabel1.Size = new Size(73, 12);
            AppointmentIDLabel1.TabIndex = 11;
            AppointmentIDLabel1.Text = "AppointmentID";
            // 
            // button2
            // 
            button2.Location = new Point(615, 110);
            button2.Name = "button2";
            button2.Size = new Size(118, 38);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DoctorsPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            Controls.Add(button2);
            Controls.Add(AppointmentIDLabel1);
            Controls.Add(PatientDate);
            Controls.Add(IssueBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(PatientGender);
            Controls.Add(PatientBirthday);
            Controls.Add(label4);
            Controls.Add(label210);
            Controls.Add(label2);
            Controls.Add(PatientName);
            Controls.Add(button1);
            Name = "DoctorsPatient";
            Size = new Size(748, 161);
            Load += DoctorsPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label PatientName;
        private Label label2;
        private Label label210;
        private Label label4;
        private Label PatientBirthday;
        private Label PatientGender;
        private Label label1;
        private Label label3;
        private RichTextBox IssueBox;
        private Label PatientDate;
        private Label AppointmentIDLabel1;
        private Button button2;
    }
}
