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
                    //this.Hide();
                    //AddIncident addIncident = new AddIncident(user);
                    //addIncident.ShowDialog();
                    //this.Close();

                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();
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
                    User userByPassword = userService.GetUserByPassword(password);

                    if (userByPassword != null && user.Password == userByPassword.Password)
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

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
    
}
