using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class ForgotPassword : Form
    {
        private User user;
        private UserService userService;
        public ForgotPassword(User user)
        {
            InitializeComponent();
            userService = new UserService();
            this.user = user;
            this.txtUpdatedPassword.PasswordChar = '*';
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtEmail.Text) || string.IsNullOrEmpty(this.txtUpdatedPassword.Text))
                    MessageBox.Show("Please write your email and new password.", "Message", MessageBoxButtons.OK);
                else
                {
                    string updatedPassword = txtUpdatedPassword.Text;
                    userService.UpdatePassword(user.Email, updatedPassword);
                    MessageBox.Show("You changed your password successfully!", "Message", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please try again later", "Message", MessageBoxButtons.OK);
            }
        }
    }
}
