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
    public partial class DoctorUI : Form
    {
        int UserID;
        public DoctorUI()
        {
            InitializeComponent();
        }
        public void getValues(int ID)
        {
            UserID = ID;
        }
        private void DoctorUI_Load(object sender, EventArgs e)
        {
            DoctorID.Text = UserID.ToString();  
        }

        private void DoctorID_Click(object sender, EventArgs e)
        {

        }
    }
}
