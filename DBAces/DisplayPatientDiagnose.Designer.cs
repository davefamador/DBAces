namespace DBAces
{
    partial class DisplayPatientDiagnose
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
            PatientDiagnos = new Button();
            label2 = new Label();
            TreatmentsBox = new RichTextBox();
            label1 = new Label();
            ConditionBox = new RichTextBox();
            SuspendLayout();
            // 
            // PatientDiagnos
            // 
            PatientDiagnos.Location = new Point(31, 245);
            PatientDiagnos.Name = "PatientDiagnos";
            PatientDiagnos.Size = new Size(363, 50);
            PatientDiagnos.TabIndex = 11;
            PatientDiagnos.Text = "Done";
            PatientDiagnos.UseVisualStyleBackColor = true;
            PatientDiagnos.Click += PatientDiagnos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(138, 128);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 10;
            label2.Text = "Treatments";
            // 
            // TreatmentsBox
            // 
            TreatmentsBox.Location = new Point(31, 152);
            TreatmentsBox.Name = "TreatmentsBox";
            TreatmentsBox.ReadOnly = true;
            TreatmentsBox.Size = new Size(344, 62);
            TreatmentsBox.TabIndex = 9;
            TreatmentsBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(147, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 8;
            label1.Text = "Condition";
            // 
            // ConditionBox
            // 
            ConditionBox.Location = new Point(31, 42);
            ConditionBox.Name = "ConditionBox";
            ConditionBox.ReadOnly = true;
            ConditionBox.Size = new Size(344, 62);
            ConditionBox.TabIndex = 7;
            ConditionBox.Text = "";
            // 
            // DisplayPatientDiagnose
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
            Name = "DisplayPatientDiagnose";
            Text = "DisplayPatientDiagnose";
            Load += DisplayPatientDiagnose_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PatientDiagnos;
        private Label label2;
        private RichTextBox TreatmentsBox;
        private Label label1;
        private RichTextBox ConditionBox;
    }
}