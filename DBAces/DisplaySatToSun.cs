using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DBAces
{
    public partial class DisplaySatToSun : UserControl
    {
        public DisplaySatToSun()
        {
            InitializeComponent();
        }

        private void DisplaySatToSun_Load(object sender, EventArgs e)
        {

        }

        public void display(string d)
        {
            SetDate.Text = d;
        }

        private void SetDate_Click(object sender, EventArgs e)
        {

        }
    }
}
