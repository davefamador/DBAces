﻿using System;
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
            string sql = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";


            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UserNameRegisterInput.Text.ToString();
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordRegisterInput.Text.ToString();
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = RolePatient;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your account is added. Please click the login button.");
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
    }


}
