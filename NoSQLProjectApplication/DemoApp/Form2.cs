using Logic;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private UserService userService;
        
    
        private void Form2_Load(object sender, EventArgs e)
        {
            userService = new UserService();

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string updatedPassword = txtUpdatedPassword.Text;
            userService.UpdatePassword(email, updatedPassword);



        }
    }
}
