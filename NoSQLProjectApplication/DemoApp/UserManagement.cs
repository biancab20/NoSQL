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
        private User loggedInUser;

        public UserManagement(User user)
        {
            InitializeComponent();

            this.loggedInUser = user;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            userService = new UserService();

            listViewUsers.View = View.Details;
            listViewUsers.Columns.Add("ID", 80, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("First Name", 120, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("Last Name", 120, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("Email", 120, HorizontalAlignment.Left);
            listViewUsers.Columns.Add("Number of Tickets", 120, HorizontalAlignment.Left);

            LoadAllUsers();
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void LoadAllUsers()
        {
            //// Get all users from the service
            //allUsers = userService.GetAllUsers();

            //TicketService ticketService = new TicketService();

            //// Clear existing items in ListView
            //listViewUsers.Items.Clear();

            //foreach (var user in allUsers)
            //{
            //    user.Tickets = ticketService.GetTicketsByUserId(user.Id.ToString());
            //}

            //// Populate the ListView with btnUser information
            //for (int i = 0; i < allUsers.Count; i++)
            //{
            //    var user = allUsers[i];

            //    int totalTickets = user.Tickets.Count;

            //    // Assign a numerical ID based on the position in the list
            //    int numericId = i + 1;

            //    ListViewItem item = new ListViewItem(numericId.ToString()); // Numeric ID
            //    item.SubItems.Add(user.FirstName);
            //    item.SubItems.Add(user.LastName);
            //    item.SubItems.Add(user.Email);
            //    item.SubItems.Add(totalTickets.ToString());

            //    listViewUsers.Items.Add(item);
            //}

            allUsers = userService.GetAllUsers();
            TicketService ticketService = new TicketService();

            listViewUsers.Items.Clear();

            foreach (var user in allUsers)
            {
                string userFullName = $"{user.FirstName} {user.LastName}";
                var userTickets = ticketService.GetTicketsByUsername(userFullName); // Fetch tickets for each user by name
                int totalTickets = userTickets.Count;

                ListViewItem item = new ListViewItem(user.Id.ToString());
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(totalTickets.ToString()); // Add ticket count

                listViewUsers.Items.Add(item);
            }
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

            // Populate the ListView with btnUser information
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString()); // Numeric ID
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Tickets.Count.ToString()); // Assuming Ticket is an int property

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

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(loggedInUser);
            dashboard.ShowDialog();
            this.Close();
        }

        private void incident_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTicket viewTicket = new ViewTicket(loggedInUser);
            viewTicket.ShowDialog();    
            this.Close();
        }

        private void btnFilterByEmail_Click_1(object sender, EventArgs e)
        {
            // Filter users by email
            string filterEmail = txtFilterByEmail.Text.Trim().ToLower();
            List<User> filteredUsers = allUsers.FindAll(user => user.Email.ToLower().Contains(filterEmail));

            // Update the ListView with filtered users
            PopulateListViewWithUsers(filteredUsers);
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedUserItem = listViewUsers.SelectedItems[0];
            string userId = selectedUserItem.SubItems[0].Text; // Assuming the first subitem is the user ID
            string userName = $"{selectedUserItem.SubItems[1].Text} {selectedUserItem.SubItems[2].Text}";

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete this user ({userName})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                userService.DeleteUser(userId);
                MessageBox.Show("User deleted successfully.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllUsers();
            }
        }
    }

}

