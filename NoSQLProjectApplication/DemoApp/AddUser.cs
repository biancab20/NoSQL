using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class AddUser : Form
    {
        private UserService userService;

        public AddUser()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Role role = (Role)Enum.Parse(typeof(Role), cmbRole.Text);

            User newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Username = username,
                Password = userService.Hash(password),
                Role = role
            };

            userService.CreateUser(newUser);

            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
