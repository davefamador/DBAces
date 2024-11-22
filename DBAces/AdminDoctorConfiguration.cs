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
    public partial class AdminDoctorConfiguration : UserControl
    {
        string userPatientUsername, userPatientPassword, PatientFirstname, PatientLastname, gender;
        DateTime DateofBrith;
        int userPatientID, userDoctorID;
        string userDoctorUsername, userDoctorPassword, DoctorFirstname, DoctorLastname, DoctorSpecialization, DoctorPhoneNumber, DoctorEmail;

        public AdminDoctorConfiguration()
        {
            InitializeComponent();
        }
        private void AdminDoctorConfiguration_Load(object sender, EventArgs e)
        {

        }
       
       

       
        // string sql1 = "SELECT u.Username,u.Password,p.UserID,p.FirstName,p.Lastname,p.DateofBirth,p.Gender FROM Users u JOIN Patients ON u.UserID = p.UserID;";
  
        public void ToGetDatasPatient(string userPatientUsername,string userPatientPassword, int userPatientID,string PatientName,string DateofBrith,string gender) { 
           
        }

        public void toGetDatasDoctor(string DoctorUsername, string DoctorPassword, int DoctorID, string DoctorName, string DoctorSpecialization, string DoctorPhoneNumber, string DoctorEmail) { 
            
        }

    }
}
