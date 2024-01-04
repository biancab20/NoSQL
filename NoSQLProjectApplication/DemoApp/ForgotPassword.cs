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
        private string email;
        private string token;
        public ForgotPassword(User user)
        {
            InitializeComponent();
            userService = new UserService();
            this.user = user;
            this.txtPassword.PasswordChar = '*';
            this.txtConfirmPassword.PasswordChar = '*';
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            { 
                this.token = txtToken.Text;

                bool verifiedToken = userService.VerifyResetToken(email, token);


                if (verifiedToken)
                {
                    string newPassword = txtPassword.Text;
                    string confirmedPassword = txtConfirmPassword.Text;

                    if (newPassword != confirmedPassword)
                    {
                        MessageBox.Show("Passwords do not match. Please enter matching passwords", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        userService.UpdatePassword(email, newPassword);
                        MessageBox.Show("Password reset successfully!", "Message", MessageBoxButtons.OK);

                        this.Invoke((MethodInvoker)delegate
                        {
                            this.Close();
                        });
                        
                    }
                }
                else
                    MessageBox.Show("Invalid token. Please request a new one.", "Message", MessageBoxButtons.OK);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSendToken_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(this.txtEmail.Text))
                    MessageBox.Show("Please write your email first.", "Message", MessageBoxButtons.OK);
                else
                {
                    email = txtEmail.Text;
                    token = ResetPassword(email);
                    MessageBox.Show("A token has been sent to your email address.", "Message", MessageBoxButtons.OK);

                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please try again later", "Message", MessageBoxButtons.OK);

            }
        }
        public string ResetPassword(string email)
        {
            string token = Guid.NewGuid().ToString();
            userService.StorePasswordResetToken(email, token);
            SendToken(email, token);
            return token;
        }
        private void SendToken(string email, string token)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("gardengroup77@gmail.com", "tahi bqem vykl birq"),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("gardengroup77@gmail.com"),
                Subject = "Password reset",
                Body = $"Dear {user.Username},<br><br>" +
                       $"We received a request for changing your password. If that was you, please use the following token to proceed with the process:<br><br>" +
                       $"<strong>{token}</strong><br><br>" +
                       $"If you did not request a password reset, please ignore this email or contact our support team.<br><br>" +
                       $"Best regards,<br>" +
                       $"The Garden Group Support Team",

                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);

            client.Send(mailMessage);
        }
    }
}
