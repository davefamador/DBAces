using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAces
{
    public partial class AdminPatientConfiguration : UserControl
    {
        public AdminPatientConfiguration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        public void toGetAttributes(string userPatientUsername, string userPatientPassword, int userPatientID, string PatientName, DateOnly DateofBrith, string gender) { 
            UserIDLabel.Text = userPatientID.ToString();
            PatientUsernameLabel.Text = userPatientUsername;
            PatientPasswordLabel.Text = userPatientPassword;
            PatientNameLabel.Text = PatientName;
            PatientDateOfBirth.Text = DateofBrith.ToString();
            PatientGenderLabel.Text = gender;
        }
        private void AdminPatientConfiguration_Load(object sender, EventArgs e)
        {

        }
    }
}
