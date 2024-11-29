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
        public CalendarDisplayCurrentMonth()
        {
            InitializeComponent();
        }

        private void CalendarDisplayCurrentMonth_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays,string MonthYear)
        {
            DisplayDayslabel.Text = numdays + "";
        }

        private void CalendarDisplayCurrentMonth_Click(object sender, EventArgs e)
        {
            
        }
    }
}
