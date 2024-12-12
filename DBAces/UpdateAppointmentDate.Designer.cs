namespace DBAces
{
    partial class UpdateAppointmentDate
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
            DayComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            TimeComboBox = new ComboBox();
            DoctorIDlabel = new Label();
            AppointmentIDlabel = new Label();
            UpdateDateBTN = new Button();
            SuspendLayout();
            // 
            // DayComboBox
            // 
            DayComboBox.FormattingEnabled = true;
            DayComboBox.Location = new Point(30, 65);
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(237, 23);
            DayComboBox.TabIndex = 0;
            DayComboBox.SelectedIndexChanged += DayComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // TimeComboBox
            // 
            TimeComboBox.FormattingEnabled = true;
            TimeComboBox.Location = new Point(30, 119);
            TimeComboBox.Name = "TimeComboBox";
            TimeComboBox.Size = new Size(237, 23);
            TimeComboBox.TabIndex = 2;
            TimeComboBox.SelectedIndexChanged += TimeComboBox_SelectedIndexChanged;
            // 
            // DoctorIDlabel
            // 
            DoctorIDlabel.AutoSize = true;
            DoctorIDlabel.Location = new Point(158, 9);
            DoctorIDlabel.Name = "DoctorIDlabel";
            DoctorIDlabel.Size = new Size(54, 15);
            DoctorIDlabel.TabIndex = 4;
            DoctorIDlabel.Text = "DoctorID";
            // 
            // AppointmentIDlabel
            // 
            AppointmentIDlabel.AutoSize = true;
            AppointmentIDlabel.Location = new Point(233, 9);
            AppointmentIDlabel.Name = "AppointmentIDlabel";
            AppointmentIDlabel.Size = new Size(114, 15);
            AppointmentIDlabel.TabIndex = 5;
            AppointmentIDlabel.Text = "AppointmentIDlabel";
            // 
            // UpdateDateBTN
            // 
            UpdateDateBTN.Location = new Point(30, 203);
            UpdateDateBTN.Name = "UpdateDateBTN";
            UpdateDateBTN.Size = new Size(269, 48);
            UpdateDateBTN.TabIndex = 6;
            UpdateDateBTN.Text = "UPDATE DATE";
            UpdateDateBTN.UseVisualStyleBackColor = true;
            // 
            // UpdateAppointmentDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 263);
            Controls.Add(UpdateDateBTN);
            Controls.Add(AppointmentIDlabel);
            Controls.Add(DoctorIDlabel);
            Controls.Add(label2);
            Controls.Add(TimeComboBox);
            Controls.Add(label1);
            Controls.Add(DayComboBox);
            Name = "UpdateAppointmentDate";
            Text = "New Appointment";
            Load += UpdateAppointmentDate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DayComboBox;
        private Label label1;
        private Label label2;
        private ComboBox TimeComboBox;
        private Label DoctorIDlabel;
        private Label AppointmentIDlabel;
        private Button UpdateDateBTN;
    }
}