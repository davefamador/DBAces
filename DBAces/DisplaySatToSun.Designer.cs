namespace DBAces
{
    partial class DisplaySatToSun
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
            SetDate = new Label();
            SuspendLayout();
            // 
            // SetDate
            // 
            SetDate.AutoSize = true;
            SetDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SetDate.Location = new Point(5, 21);
            SetDate.Name = "SetDate";
            SetDate.Size = new Size(90, 20);
            SetDate.TabIndex = 1;
            SetDate.Text = "Wednesday";
            SetDate.Click += SetDate_Click;
            // 
            // DisplaySatToSun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SetDate);
            Name = "DisplaySatToSun";
            Size = new Size(98, 66);
            Load += DisplaySatToSun_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SetDate;
    }
}
