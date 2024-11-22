using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace DBAces
{


    public partial class LoginConsole : Form
    {
        DoctorUI doctorui = new DoctorUI();
        User Users = new User();
        AdminUI adminui = new AdminUI();
        String sqlcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBAces;Integrated Security=True;Trust Server Certificate=True";
        String LoginPage = "LoginPagePanel";
        String RegisterPage = "RegisterPagePanel";
        String CurrentHost = "";
        String CurrentHostID = "";

       
        // ROLE
        String RolePatient = "Patient";
        public LoginConsole()
        {
            InitializeComponent();
        }

        private void ToLoadPanel(string s)
        {
            switch (s)
            {
                case "LoginPagePanel":
                    ToRegisterPanel.Hide();
                    ToLoginPanel.Show();

                    break;
                case "RegisterPagePanel":
                    ToLoginPanel.Hide();
                    ToRegisterPanel.Show();
                    break;
            }
        }
        private void CreateAccountBTN_Click_1(object sender, EventArgs e)
        {
            ToLoadPanel(RegisterPage);
        }

        private void ToLoginPagePanel_Click(object sender, EventArgs e)
        {
            ToLoadPanel(LoginPage);
        }

        private bool ToFindUserNamesql(string username)
        {
            // SQL command to check if a username exists
            string sql = "SELECT Username FROM Users WHERE Username = @Username";

            try
            {
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return !reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return false;
        }

        private bool ToVerifyUserLogin()
        {
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                string sql = "SELECT UserID,Role FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", UsernameLoginInput.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordLoginInput.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Role"] != DBNull.Value)
                            {
                                string hostName = reader["Role"].ToString();
                                string UserID = reader["UserID"].ToString();

                                CurrentHost = hostName;
                                CurrentHostID = UserID;
                                return true;

                            }
                            else
                            {
                                MessageBox.Show("The Role column is NULL.");
                                return false;
                            }

                        }
                    }
                }
            }
            return false;
        }
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UsernameLoginInput.Text) && !String.IsNullOrEmpty(PasswordLoginInput.Text))
            {
                if (ToVerifyUserLogin())
                {
                    int UsersID = int.Parse(CurrentHostID);
                    switch (CurrentHost)
                    {
                        case "Patient":
                            this.Hide();
                            Users.Show();
                            break;
                        case "Doctor":
                            doctorui.getValues(UsersID);
                            this.Hide();
                            doctorui.Show();
                            break;
                        case "Admin":
                            this.Hide();
                            adminui.Show();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input another username & Password");
            }
        }
        private void toRegisterCustomer()
        {
            bool iteration1sql = false, iteration2sql = false;
            string userName = UserNameRegisterInput.Text.ToString();
            string passWord = PasswordRegisterInput.Text.ToString();
            string sql = "INSERT INTO Users (Username, Password, Role) OUTPUT INSERTED.UserID VALUES (@Username, @Password, @Role)";
            string sql1 = "INSERT INTO Patients (UserID) VALUES (@UserID)";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                try
                {
                    int newUserID = 0;
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userName;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passWord;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = RolePatient;
                        newUserID = (int)cmd.ExecuteScalar();
                        iteration1sql = true;
                    }

                    if (iteration1sql)
                    {
                        using (SqlCommand cmd = new SqlCommand(sql1, con))
                        {
                            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = newUserID;
                            cmd.ExecuteNonQuery();
                            iteration2sql = true;
                        }
                    }
                    if (iteration1sql == true && iteration2sql == true)
                    {
                        MessageBox.Show("Your account is added. Please click the login button.");
                    }
                    else if (iteration1sql == true && iteration2sql == false) {
                        MessageBox.Show("There was an issue on Patient DB");
                    }
                    else {
                        MessageBox.Show("The account didn't create");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("\n" + e);
                }
            }
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UserNameRegisterInput.Text) && !String.IsNullOrEmpty(PasswordRegisterInput.Text))
            {
                if (ToFindUserNamesql(UserNameRegisterInput.Text))
                {
                    toRegisterCustomer();
                    UsernameLoginInput.Text = "";
                    PasswordRegisterInput.Text = "";
                }
                else if (!ToFindUserNamesql(UserNameRegisterInput.Text))
                {
                    MessageBox.Show("Please input another username. The username is already taken.");
                }
            }
            else
            {
                MessageBox.Show("Please input another username & Password");
            }

        }

        private void ToLoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginConsole_Load(object sender, EventArgs e)
        {

        }

        private void UsernameLoginInput_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
