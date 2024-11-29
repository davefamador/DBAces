namespace DBAces
{
    partial class CalendarDisplayCurrentMonth
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
            DisplayDayslabel = new Label();
            SuspendLayout();
            // 
            // DisplayDayslabel
            // 
            DisplayDayslabel.AutoSize = true;
            DisplayDayslabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayDayslabel.Location = new Point(57, 0);
            DisplayDayslabel.Name = "DisplayDayslabel";
            DisplayDayslabel.Size = new Size(38, 45);
            DisplayDayslabel.TabIndex = 0;
            DisplayDayslabel.Text = "1";
            // 
            // CalendarDisplayCurrentMonth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(DisplayDayslabel);
            Name = "CalendarDisplayCurrentMonth";
            Size = new Size(98, 66);
            Load += CalendarDisplayCurrentMonth_Load;
            Click += CalendarDisplayCurrentMonth_Click;
            MouseClick += CalendarDisplayCurrentMonth_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DisplayDayslabel;
    }
}
