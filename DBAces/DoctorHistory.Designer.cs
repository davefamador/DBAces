namespace DBAces
{
    partial class DoctorHistory
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
            StatusLabel = new Label();
            label2 = new Label();
            GenderLabel = new Label();
            label4 = new Label();
            BirthdayLabel = new Label();
            IssueBox = new RichTextBox();
            label3 = new Label();
            PatientLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(538, 67);
            button1.Name = "button1";
            button1.Size = new Size(151, 68);
            button1.TabIndex = 27;
            button1.Text = "Check Diagnose";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            StatusLabel.ForeColor = SystemColors.ActiveCaptionText;
            StatusLabel.Location = new Point(538, 11);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(96, 37);
            StatusLabel.TabIndex = 22;
            StatusLabel.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(307, 159);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 21;
            label2.Text = "Issue";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            GenderLabel.ForeColor = SystemColors.ActiveCaptionText;
            GenderLabel.Location = new Point(117, 23);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(42, 20);
            GenderLabel.TabIndex = 20;
            GenderLabel.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(29, 23);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 19;
            label4.Text = "Gender";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BirthdayLabel.ForeColor = SystemColors.ActiveCaptionText;
            BirthdayLabel.Location = new Point(117, 60);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(42, 20);
            BirthdayLabel.TabIndex = 18;
            BirthdayLabel.Text = "Date";
            // 
            // IssueBox
            // 
            IssueBox.Location = new Point(52, 182);
            IssueBox.Name = "IssueBox";
            IssueBox.ReadOnly = true;
            IssueBox.Size = new Size(582, 57);
            IssueBox.TabIndex = 17;
            IssueBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(39, 59);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 16;
            label3.Text = "Date";
            // 
            // PatientLabel
            // 
            PatientLabel.AutoSize = true;
            PatientLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientLabel.ForeColor = SystemColors.ActiveCaptionText;
            PatientLabel.Location = new Point(167, 11);
            PatientLabel.Name = "PatientLabel";
            PatientLabel.Size = new Size(161, 32);
            PatientLabel.TabIndex = 15;
            PatientLabel.Text = "PatientName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(52, 11);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 14;
            label1.Text = "Patient";
            // 
            // panel1
            // 
            panel1.Controls.Add(GenderLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BirthdayLabel);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(24, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 102);
            panel1.TabIndex = 28;
            // 
            // DoctorHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(StatusLabel);
            Controls.Add(IssueBox);
            Controls.Add(PatientLabel);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "DoctorHistory";
            Size = new Size(730, 265);
            Load += DoctorHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label StatusLabel;
        private Label label2;
        private Label GenderLabel;
        private Label label4;
        private Label BirthdayLabel;
        private RichTextBox IssueBox;
        private Label label3;
        private Label PatientLabel;
        private Label label1;
        private Panel panel1;
    }
}
