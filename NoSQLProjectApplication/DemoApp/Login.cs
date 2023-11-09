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
            if((this.textBox_username.Text == "") || (this.textBox_password.Text == ""))
            {
                MessageBox.Show("Log in failed! Please enter your username and password!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                user = ValidateUserCreditentials(userService);
                if(user != null)
                {
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Close();
                }

            }
        }
        
        User ValidateUserCreditentials(UserService userService)
        {
            try
            {
                user = userService.GetUserByUserName(this.textBox_username.Text);

                if (user != null)
                {
                    User userByPassword = userService.GetUserByPassword(userService.Hash(this.textBox_password.Text));

                    if (userByPassword != null && user.Id == userByPassword.Id)
                    {
                        return user;
                    }
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
    }
    
}
