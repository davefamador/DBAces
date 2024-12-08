namespace DBAces
{
    partial class DiagnosPatient
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
            PatientsName = new Label();
            ConditionBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            TreatmentsBox = new RichTextBox();
            PatientDiagnos = new Button();
            SuspendLayout();
            // 
            // PatientsName
            // 
            PatientsName.AutoSize = true;
            PatientsName.Font = new Font("Segoe UI", 12F);
            PatientsName.Location = new Point(12, 9);
            PatientsName.Name = "PatientsName";
            PatientsName.Size = new Size(99, 21);
            PatientsName.TabIndex = 0;
            PatientsName.Text = "PatientName";
            // 
            // ConditionBox
            // 
            ConditionBox.Location = new Point(12, 79);
            ConditionBox.Name = "ConditionBox";
            ConditionBox.Size = new Size(344, 62);
            ConditionBox.TabIndex = 1;
            ConditionBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 2;
            label1.Text = "Condition";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 160);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "Treatments";
            // 
            // TreatmentsBox
            // 
            TreatmentsBox.Location = new Point(12, 184);
            TreatmentsBox.Name = "TreatmentsBox";
            TreatmentsBox.Size = new Size(344, 62);
            TreatmentsBox.TabIndex = 3;
            TreatmentsBox.Text = "";
            // 
            // PatientDiagnos
            // 
            PatientDiagnos.Location = new Point(30, 268);
            PatientDiagnos.Name = "PatientDiagnos";
            PatientDiagnos.Size = new Size(326, 43);
            PatientDiagnos.TabIndex = 5;
            PatientDiagnos.Text = "Done";
            PatientDiagnos.UseVisualStyleBackColor = true;
            PatientDiagnos.Click += PatientDiagnos_Click;
            // 
            // DiagnosPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(407, 323);
            Controls.Add(PatientDiagnos);
            Controls.Add(label2);
            Controls.Add(TreatmentsBox);
            Controls.Add(label1);
            Controls.Add(ConditionBox);
            Controls.Add(PatientsName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DiagnosPatient";
            Text = "Diagnostic Assesment";
            Load += DiagnosPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PatientsName;
        private RichTextBox ConditionBox;
        private Label label1;
        private Label label2;
        private RichTextBox TreatmentsBox;
        private Button PatientDiagnos;
    }
}