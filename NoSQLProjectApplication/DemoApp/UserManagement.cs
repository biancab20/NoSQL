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
    public partial class UserManagement : Form
    {
        private UserService userService;
        private List<User> allUsers;

        public UserManagement()
        {
            InitializeComponent();
            userService = new UserService();

            listViewUsers.View = View.Details;
            listViewUsers.Columns.Add("ID", 80, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("First Name", 120, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("Last Name", 120, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("Email", 200, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("Number of Tickets", 120, HorizontalAlignment.Left);
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void LoadAllUsers()
        {
            // Get all users from the service
            allUsers = userService.GetAllUsers();

            // Clear existing items in ListView
            listViewUsers.Items.Clear();
           

            // Populate the ListView with user information
            foreach (var user in allUsers)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString()); // Numeric ID
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(user.Ticket.ToString());

                listViewUsers.Items.Add(item);
            }
        }

        private void btnFilterByEmail_Click(object sender, EventArgs e)
        {
            // Filter users by email
            string filterEmail = txtFilterByEmail.Text.Trim().ToLower();
            List<User> filteredUsers = allUsers.FindAll(user => user.Email.ToLower().Contains(filterEmail));

            // Update the ListView with filtered users
            PopulateListViewWithUsers(filteredUsers);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Open the AddUserForm
            AddUser addUserForm = new AddUser();
            addUserForm.ShowDialog();

            // Reload users when the AddUserForm is closed
            LoadAllUsers();
        }

        private void PopulateListViewWithUsers(List<User> users)
        {
            // Clear existing items in ListView
            listViewUsers.Items.Clear();

            // Populate the ListView with user information
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString()); // Numeric ID
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(user.Ticket.ToString()); // Assuming Ticket is an int property

                listViewUsers.Items.Add(item);
            }
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            // Open the AddUserForm
            AddUser addUserForm = new AddUser();
            addUserForm.ShowDialog();

            // Reload users when the AddUserForm is closed
            LoadAllUsers();
        }
    }

}

