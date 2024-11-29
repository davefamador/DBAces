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
    public partial class AddDoctorAppointment : Form
    {
        List<string> DayTime = new List<string>();

        int DoctorID;
        string daysmonthyear;
        public AddDoctorAppointment()
        {
            InitializeComponent();
        }

        private void AddDoctorAppointment_Load(object sender, EventArgs e)
        {
            DateApointment.Text = daysmonthyear;
        }

        private List<string> timeCheck()
        {
            Dictionary<CheckBox, string> checkBoxMappings = new Dictionary<CheckBox, string>
    {
    

        // Morning
        { checkBox1, "7:00 AM" },
        { checkBox2, "8:00 AM" },
        { checkBox4, "9:00 AM" },
        { checkBox3, "10:00 AM" },
        { checkBox5, "11:00 AM" },
        { checkBox10, "7:30 AM" },
        { checkBox9, "8:30 AM" },
        { checkBox8, "9:30 AM" },
        { checkBox7, "10:30 AM" },
        { checkBox6, "11:30 AM" },


        //Afternoon
        { checkBox20, "1:00 AM" },
        { checkBox19, "2:00 AM" },
        { checkBox18, "3:00 AM" },
        { checkBox17, "4:00 AM" },
        { checkBox16, "5:00 AM" },
        { checkBox15, "1:30 AM" },
        { checkBox14, "2:30 AM" },
        { checkBox13, "3:30 AM" },
        { checkBox12, "4:30 AM" },
        { checkBox11, "5:30 AM" },

        //Afternooon
        { checkBox24, "6:00 AM" },
        { checkBox23, "6:30 AM" },
        { checkBox22, "7:00 AM" },
        { checkBox21, "7:30 PM" },
        { checkBox25, "8:00 PM" },
        { SpecificTime, SpecificTimeTEXTBOX.Text}
            };

            return checkBoxMappings.Where(mapping => mapping.Key.Checked).Select(mapping => mapping.Value).ToList();
        }

        public void toGetData(int ID, string days, string monthtyear)
        {
            DoctorID = ID;
            daysmonthyear = days + " " + monthtyear;
        }

        private void SpecificTimeTEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != ' ' &&
           e.KeyChar != 'A' && e.KeyChar != 'a' &&
           e.KeyChar != 'P' && e.KeyChar != 'p' &&
            e.KeyChar != 'M' && e.KeyChar != 'm' &&
           !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SpecificTimeTEXTBOX_Leave(object sender, EventArgs e)
        {
            string timePattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (AM|PM|am|pm)$";
            if (SpecificTime.Text.Length > 0)
            {

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(SpecificTimeTEXTBOX.Text, timePattern))
            {
                MessageBox.Show("Invalid time format. Please enter time in hh:mm AM/PM format.");
                SpecificTimeTEXTBOX.Focus();
            }
        }

        private void SpecificTimeTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SpecificTimeTEXTBOX.Focused)  // Only execute if the textbox is focused
                {
                    if (SpecificTimeTEXTBOX.Text.Length > 0)
                    {
                        SpecificTime.Checked = true;
                    }
                    else
                    {
                        SpecificTime.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void SQLAppointment() { 
            
        }
        private void ToAddDoctorAvailableBTN_Click(object sender, EventArgs e)
        {
            DayTime = timeCheck();
            MessageBox.Show(string.Join("\n", DayTime), "Selected Times");
            DialogResult result = MessageBox.Show("Do you want to proceed?","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SQLAppointment();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
               
            }
           
        }
    }
}
