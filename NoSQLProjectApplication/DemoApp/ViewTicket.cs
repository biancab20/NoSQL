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

    public partial class ViewTicket : Form
    {
        private TicketService ticketService;
        private UserService userService;
        private List<Ticket> allTickets;
        private TicketFilterService ticketFilterService;
        private User loggedInUser;



        private void StyleServiceDesk()
        {
            btnUser.Visible = true;
            buttonDeleteIncident.Visible = true;
            buttonUpdateIncident.Visible = true;
        }

        private void StyleOther()
        {
            btnUser.Visible = false;
            buttonDeleteIncident.Visible = false;
            buttonUpdateIncident.Visible = false;
        }

        public ViewTicket(User user)
        {
            InitializeComponent();

            this.loggedInUser = user;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ticketService = new TicketService();
            userService = new UserService();

            listViewTickets.View = View.Details;
            listViewTickets.Columns.Add("ID", 80, HorizontalAlignment.Left);
            listViewTickets.Columns.Add("User", 120, HorizontalAlignment.Left);
            listViewTickets.Columns.Add("Priority", 120, HorizontalAlignment.Left);
            listViewTickets.Columns.Add("Subject", 200, HorizontalAlignment.Left);
            listViewTickets.Columns.Add("Description", 300, HorizontalAlignment.Left);
            listViewTickets.Columns.Add("Deadline", 120, HorizontalAlignment.Left);
            listViewTickets.Columns.Add("Status", 120, HorizontalAlignment.Left);

            listViewTickets.SelectedIndexChanged += listViewTickets_SelectedIndexChanged;

            ticketFilterService = new TicketFilterService(allTickets);

            if (loggedInUser.Role == Role.ServiceDesk)
            {
                StyleServiceDesk();
            }
            else
            {
                StyleOther();
            }

            LoadAllTickets();
        }

        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTickets.SelectedItems[0];

                string id = selectedItem.SubItems[0].Text;
                string user = selectedItem.SubItems[1].Text;
                string priority = selectedItem.SubItems[2].Text;
                string subject = selectedItem.SubItems[3].Text;
                string description = selectedItem.SubItems[4].Text;
                string deadline = selectedItem.SubItems[5].Text;
                string status = selectedItem.SubItems[6].Text;
            }
        }

        private void ViewTicket_Load(object sender, EventArgs e)
        {
            LoadAllTickets();
        }

        private void LoadAllTickets()
        {

            allTickets = ticketService.GetAllTicket();

            listViewTickets.Items.Clear();

            // Populate based on btnUser role
            PopulateListViewWithTickets(allTickets, loggedInUser.Role.ToString(), loggedInUser.Username);
        }

        private void PopulateListViewWithTickets(List<Ticket> tickets, string userRole, string currentUsername)
        {
            listViewTickets.Items.Clear();

            for (int i = 0; i < tickets.Count; i++)
            {
                var ticket = tickets[i];

                // Check if the essential fields are not empty
                if (!string.IsNullOrEmpty(ticket.ReportedByUser) && !string.IsNullOrEmpty(ticket.Subject))
                {
                    if (userRole == "ServiceDesk")
                    {
                        int numericId = i + 1;

                        ListViewItem item = new ListViewItem(numericId.ToString());
                        item.SubItems.Add(ticket.ReportedByUser);
                        item.SubItems.Add(ticket.Priority.ToString());
                        item.SubItems.Add(ticket.Subject);
                        item.SubItems.Add(ticket.Description);
                        item.SubItems.Add(ticket.DeadlineFollowUp.ToString("yyyy-MM-dd HH:mm:ss"));
                        item.SubItems.Add(ticket.Status.ToString());

                        item.Tag = ticket.ObjectId.ToString();

                        listViewTickets.Items.Add(item);
                    }
                    else if (userRole == "Other" && ticket.ReportedByUser == currentUsername)
                    {
                        int numericId = i + 1;

                        ListViewItem item = new ListViewItem(numericId.ToString());
                        item.SubItems.Add(ticket.ReportedByUser);
                        item.SubItems.Add(ticket.Priority.ToString());
                        item.SubItems.Add(ticket.Subject);
                        item.SubItems.Add(ticket.Description);
                        item.SubItems.Add(ticket.DeadlineFollowUp.ToString("yyyy-MM-dd HH:mm:ss"));
                        item.SubItems.Add(ticket.Status.ToString());

                        listViewTickets.Items.Add(item);
                    }
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.ToLower();

            List<Ticket> filteredTickets = ticketFilterService.FilterTickets(searchQuery, loggedInUser.Role.ToString(), loggedInUser.Username);

            PopulateListViewWithTickets(filteredTickets, loggedInUser.Role.ToString(), loggedInUser.Username);
        }

        private void user_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement(loggedInUser);
            userManagement.ShowDialog();
            this.Close();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(loggedInUser);
            dashboard.ShowDialog();
            this.Close();
        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddIncident addIncident = new AddIncident(loggedInUser);
            addIncident.ShowDialog();
            this.Close();
        }

        private void buttonDeleteIncident_Click(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                string ticketId = listViewTickets.SelectedItems[0].Tag.ToString();

                ticketService.DeleteTicket(ticketId);
                MessageBox.Show("Ticket has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdateIncident_Click(object sender, EventArgs e)
        {

        }
    }
}
