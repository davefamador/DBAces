using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DBAces
{
    public partial class AdminPatientConfiguration : UserControl
    {

        int PatientID;
        string username, password, Doctorname, DoctorphoneNumber, Email;

        AdminUserConfiguration admin = new AdminUserConfiguration();
        public AdminPatientConfiguration()
        {
            InitializeComponent();
        }




        public void toGetAttributes(string DoctorUsername, string DoctorPassword, int PatientID, string PatientName, string DateofBirth, string gender)
        {

            PatientID = PatientID;
            username = DoctorUsername;
            password = DoctorPassword;
            Doctorname = PatientName;
            DoctorphoneNumber = DateofBirth;
            Email = gender;

            UserIDLabel.Text = PatientID.ToString();
            PatientUsernameLabel.Text = DoctorUsername;
            PatientPasswordLabel.Text = DoctorPassword;
            PatientNameLabel.Text = PatientName;
            PatientDateOfBirth.Text = DateofBirth;
            PatientGenderLabel.Text = gender;
        }
        private void AdminPatientConfiguration_Load(object sender, EventArgs e)
        {

        }

        public void ChangeInfoStatus(string aa)
        {
            switch (aa)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            admin.Close();
            admin = new AdminUserConfiguration();
            admin.getAttributes(PatientID, username, password, Doctorname, DoctorphoneNumber, Email);
            admin.SwitchPanel(1); // User Account Information
            admin.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.Close();
            admin = new AdminUserConfiguration();
            admin.getAttributes(PatientID, username, password, Doctorname, DoctorphoneNumber, Email);
            admin.SwitchPanel(2); // User Account Information
            admin.Show();
        }
    }
}
