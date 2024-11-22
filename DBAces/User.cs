using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace DBAces
{
    public partial class User : Form
    {

        static String CurrentPanels = "";
        static String Appointment_Panel = "Appoinment_Panel";
        static String History_Panel = "History_Panel";
        static String UserSetting_Panel = "UserSetting_Panel";
        static String AddUserBalance = "AddUserBalance_Panel";
        public User()
        {
            InitializeComponent();
        }


        private void toLoadPanels(String s)
        {
            switch (s)
            {
                case "Appoinment_Panel":
                    AddBalancePanel.Hide();
                    HistoryPanel.Hide();
                    UserSetting.Hide();
                    AppointmentPanel.Show();
                    break;
                case "History_Panel":
                    AppointmentPanel.Hide();
                    AddBalancePanel.Hide();
                    UserSetting.Hide();
                    HistoryPanel.Show();
                    break;
                case "UserSetting_Panel":
                    HistoryPanel.Hide();
                    AppointmentPanel.Hide();
                    AddBalancePanel.Hide();
                    UserSetting.Show();
                    break;
                case "AddUserBalance_Panel":
                    HistoryPanel.Hide();
                    AppointmentPanel.Hide();
                    UserSetting.Hide();
                    AddBalancePanel.Show();
                    break;


            }
        }
        private void User_Load(object sender, EventArgs e)
        {

        }


        private void UserSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(History_Panel);
        }

        private void AppointmentBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(Appointment_Panel);
        }

        private void SettingBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(UserSetting_Panel);
        }

        private void HistoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserAddBalanceBTN_Click(object sender, EventArgs e)
        {
            toLoadPanels(AddUserBalance);
        }
    }
}
