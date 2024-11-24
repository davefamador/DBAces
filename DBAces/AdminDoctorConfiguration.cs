using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAces
{
    public partial class AdminDoctorConfiguration : UserControl
    {

        public AdminDoctorConfiguration()
        {
            InitializeComponent();
        }
        private void AdminDoctorConfiguration_Load(object sender, EventArgs e)
        {

        }

       
        public void toGetDatasDoctor(string DoctorUsername, string DoctorPassword, int DoctorID, string DoctorName, string DoctorPhoneNumber, string DoctorEmail)
        {
          DoctorIDLabel.Text = DoctorID.ToString();
          DoctorUsernameLabel.Text = DoctorUsername;
          DoctorPasswordLabel.Text = DoctorPassword;
          DoctorNameLabel.Text = DoctorName;
          DoctorPhoneNumberLabel.Text = DoctorPhoneNumber;
          DoctorEmailLabel.Text = DoctorEmail;

        }

    }
}
