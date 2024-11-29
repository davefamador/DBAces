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
    public partial class CalendarDisplayCurrentMonth : UserControl
    {

        private AddDoctorAppointment addappointment;
        string daymonthYear,Days;
        int DoctorID;
        public CalendarDisplayCurrentMonth()
        {
            InitializeComponent();
        }

        private void CalendarDisplayCurrentMonth_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays, string MonthYear,int ID)
        {
            DoctorID = ID;
            Days = numdays + "";
            DisplayDayslabel.Text = numdays + "";

            daymonthYear = MonthYear;
        }

        private void CalendarDisplayCurrentMonth_Click(object sender, EventArgs e)
        {
            if (addappointment != null && !addappointment.IsDisposed)
            {
                addappointment.Close(); // Ensures the form is closed
                addappointment.Dispose(); // Releases resources
                addappointment = null; // Avoids reusing the disposed object
            }
            else {
                addappointment = new AddDoctorAppointment();
                addappointment.toGetData(DoctorID, Days, daymonthYear);
                addappointment.Show();
            }

            // Create and show a new instance
          
        }

        private void CalendarDisplayCurrentMonth_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
