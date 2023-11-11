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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            userService = new UserService();

            cmbRole.Items.AddRange(Enum.GetNames(typeof(Role)));

            cmbRole.Text = "Select Role";
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
            string.IsNullOrWhiteSpace(txtLastName.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtUsername.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text) ||
             cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields and select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "Select Role";
        }
    }
}
