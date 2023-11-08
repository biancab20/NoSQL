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
            if((this.textBox_username.Text == null) || (this.textBox_password.Text == null))
            {
                MessageBox.Show("Log in failed! Please enter your username and password!", "Message", MessageBoxButtons.OK);
            }
            else
            {

            }
        }
        //User GetUser(UserService userService)
        //{

        //}
    }
}
