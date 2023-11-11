using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Security.Cryptography;
using System.Security.Policy;

namespace DemoApp
{
    public partial class Login : Form
    {
        private UserService userService;
        private User user;
        public Login()
        {
            InitializeComponent();
            userService = new UserService();
            user = new User();
            this.textBox_password.PasswordChar = '*';
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.textBox_username.Text) || string.IsNullOrWhiteSpace(this.textBox_password.Text))
            {
                MessageBox.Show("Log in failed! Please enter your username and password!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                string username = this.textBox_username.Text;
                string password = this.textBox_password.Text;

                user = ValidateUserCreditentials(username, password);
                if(user != null)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.ShowDialog();
                    this.Close();
                }
            }
        }
        
        User ValidateUserCreditentials(string username, string password)
        {
            try
            {
                user = userService.GetUserByUserName(username);

                if (user != null)
                {
                    if (user.Password == userService.Hash(password))
                        return user;
                    //User userByPassword = userService.GetUserByPassword(password);

                    //if (userByPassword != null && user.Password == userByPassword.Password)
                    //{
                    //    return user;
                    //}
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again!", "Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username. Please try again!", "Message", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred. Please try again later.", "Message", MessageBoxButtons.OK);
            }

            return null;
        }

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox_username.Text))
                MessageBox.Show("Please write your username first.", "Message", MessageBoxButtons.OK);
            else
            {
                try
                {
                    string username = this.textBox_username.Text;
                    user = userService.GetUserByUserName(username);
                    if (user != null)
                    {
                        ForgotPassword forgotPassword = new ForgotPassword(user);
                        forgotPassword.ShowDialog();
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                  //  MessageBox.Show("An error occurred. Please try again later.", "Message", MessageBoxButtons.OK);
                }

            }
        }
    }
    
}
