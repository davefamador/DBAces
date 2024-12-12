namespace DBAces
{
    partial class AdminDiagnoseConfiguration
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
            PatientDiagnos.Location = new Point(48, 246);
            PatientDiagnos.Name = "PatientDiagnos";
            PatientDiagnos.Size = new Size(326, 43);
            PatientDiagnos.TabIndex = 15;
            PatientDiagnos.Text = "Modify";
            PatientDiagnos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(144, 126);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 14;
            label2.Text = "Treatments";
            // 
            // TreatmentsBox
            // 
            TreatmentsBox.Location = new Point(30, 150);
            TreatmentsBox.Name = "TreatmentsBox";
            TreatmentsBox.Size = new Size(344, 62);
            TreatmentsBox.TabIndex = 13;
            TreatmentsBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(153, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 12;
            label1.Text = "Condition";
            // 
            // ConditionBox
            // 
            ConditionBox.Location = new Point(30, 45);
            ConditionBox.Name = "ConditionBox";
            ConditionBox.Size = new Size(344, 62);
            ConditionBox.TabIndex = 11;
            ConditionBox.Text = "";
            // 
            // AdminDiagnoseConfiguration
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
            Name = "AdminDiagnoseConfiguration";
            Text = "AdminDiagnoseConfiguration";
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