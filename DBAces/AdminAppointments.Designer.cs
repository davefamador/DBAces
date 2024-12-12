namespace DBAces
{
    partial class AdminAppointments
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
            name = new Label();
            PaymentLabel = new Label();
            label1 = new Label();
            StatusLabel = new Label();
            label4 = new Label();
            ModifyBTN = new Button();
            label5 = new Label();
            label3 = new Label();
            DateLabel = new Label();
            IssueBox = new RichTextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(3, 9);
            name.Name = "name";
            name.Size = new Size(96, 37);
            name.TabIndex = 0;
            name.Text = "label1";
            // 
            // PaymentLabel
            // 
            PaymentLabel.AutoSize = true;
            PaymentLabel.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            PaymentLabel.Location = new Point(152, 98);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(72, 30);
            PaymentLabel.TabIndex = 1;
            PaymentLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            label1.Location = new Point(267, 87);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 2;
            label1.Text = "Issue";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            StatusLabel.Location = new Point(131, 46);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(125, 30);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "StatusLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            label4.Location = new Point(26, 46);
            label4.Name = "label4";
            label4.Size = new Size(73, 30);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // ModifyBTN
            // 
            ModifyBTN.Location = new Point(651, 9);
            ModifyBTN.Name = "ModifyBTN";
            ModifyBTN.Size = new Size(118, 75);
            ModifyBTN.TabIndex = 6;
            ModifyBTN.Text = "Modify";
            ModifyBTN.UseVisualStyleBackColor = true;
            ModifyBTN.Click += ModifyBTN_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            label5.Location = new Point(26, 98);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 7;
            label5.Text = "Payment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            label3.Location = new Point(271, 46);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            DateLabel.Location = new Point(347, 46);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(58, 30);
            DateLabel.TabIndex = 9;
            DateLabel.Text = "Date";
            // 
            // IssueBox
            // 
            IssueBox.Location = new Point(347, 87);
            IssueBox.Name = "IssueBox";
            IssueBox.Size = new Size(238, 41);
            IssueBox.TabIndex = 10;
            IssueBox.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(651, 90);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 11;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            label2.Location = new Point(476, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 30);
            label2.TabIndex = 12;
            label2.Text = "id";
            // 
            // AdminAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(IssueBox);
            Controls.Add(DateLabel);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(ModifyBTN);
            Controls.Add(StatusLabel);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(PaymentLabel);
            Controls.Add(name);
            Name = "AdminAppointments";
            Size = new Size(806, 141);
            Load += AdminAppointments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label PaymentLabel;
        private Label label1;
        private Label StatusLabel;
        private Label label4;
        private Button ModifyBTN;
        private Label label5;
        private Label label3;
        private Label DateLabel;
        private RichTextBox IssueBox;
        private Button button1;
        private Label label2;
    }
}
