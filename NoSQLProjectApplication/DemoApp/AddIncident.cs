using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Logic;
using Model;
using MongoDB.Driver;

namespace DemoApp
{
    public partial class AddIncident : Form
    {
        private User loggedInUser;
        private TicketService ticketService;
        private Ticket ticketToUpdate;

        public AddIncident(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            ticketService = new TicketService();
            ClearFormData();
            FillBoxesData();

            if (loggedInUser.Role == Role.ServiceDesk)
            {
                StyleServiceDesk();

               // this.ticketToUpdate = ticketToUpdate;

               // PopulateFormForUpdate(ticketToUpdate);
            }
            else
            {
                StyleOther();
            }

            //ticketService = new TicketService();
        }

        public AddIncident(User user, Ticket ticketToUpdate) :this(user)
        {
            this.ticketToUpdate = ticketToUpdate;

            if (this.ticketToUpdate != null)
            {
                PopulateFormForUpdate(this.ticketToUpdate);
            }
            else
            {
                MessageBox.Show("Ticket data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form or handle the null case appropriately
            }
        }

        private void StyleServiceDesk()
        {
            labelTopic.Text = "Update incident ticket";
            textBoxReportedByUser.ReadOnly = false;
            labelTicketStatus.Visible = true;
            comboBoxTicketStatus.Visible = true;
            buttonUpdateTicket.Visible = true;
            buttonSubmitTicket.Visible = false;
            buttonUserManagement.Visible = true;
        }

        private void StyleOther()
        {
            labelTopic.Text = "Create new incident ticket";
            textBoxReportedByUser.ReadOnly = true;
            labelTicketStatus.Visible = false;
            comboBoxTicketStatus.Visible = false;
            buttonUpdateTicket.Visible = false;
            buttonSubmitTicket.Visible = true;
            buttonUserManagement.Visible = false;
        }

        private void FillBoxesData()
        {
            foreach (int types in IncidentType.GetValues(typeof(IncidentType)))
            {
                comboBoxIncidentType.Items.Add(Enum.GetName(typeof(IncidentType), types));
            }
            foreach (int priority in Priority.GetValues(typeof(Priority)))
            {
                comboBoxPriority.Items.Add(Enum.GetName(typeof(Priority), priority));
            }
            foreach (int status in TicketStatus.GetValues(typeof(TicketStatus)))
            {
                comboBoxTicketStatus.Items.Add(Enum.GetName(typeof(TicketStatus), status));
            }

            textBoxReportedByUser.Text = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
        }

        private void ClearFormData()
        {
            textBoxSubject.Clear();
            comboBoxIncidentType.Items.Clear();
            comboBoxPriority.Items.Clear();
            textBoxDescription.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(loggedInUser);
            dashboard.ShowDialog();
            this.Close();
        }

        private void buttonSubmitTicket_Click(object sender, EventArgs e)
        {
            IncidentAdd();
        }
        private void IncidentAdd()
        {
            try
            {
                if(CheckForm())
                {
                    Ticket ticket = new Ticket();

                    ticket.DateTimeReported = dateTimePickerReported.Value;
                    ticket.Subject = textBoxSubject.Text;
                    ticket.IncidentType = (IncidentType)comboBoxIncidentType.SelectedIndex;
                    ticket.ReportedByUser = textBoxReportedByUser.Text;
                    ticket.Priority = (Priority)comboBoxPriority.SelectedIndex;
                    ticket.DeadlineFollowUp = dateTimePickerDeadlineFollowUp.Value;
                    ticket.Description = textBoxDescription.Text;
                    ticket.Status = TicketStatus.Unresolved;

                    ticketService.CreateTicket(ticket);
                    MessageBox.Show("Ticket has been created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Hide();
                    ViewTicket viewticket = new ViewTicket(loggedInUser);
                    viewticket.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void PopulateFormForUpdate(Ticket ticket)
        {
            textBoxSubject.Text = ticket.Subject;
            textBoxDescription.Text = ticket.Description;
            comboBoxIncidentType.SelectedItem = ticket.IncidentType.ToString();
            comboBoxPriority.SelectedItem = ticket.Priority.ToString();
            dateTimePickerReported.Value = ticket.DateTimeReported;
            dateTimePickerDeadlineFollowUp.Value = ticket.DeadlineFollowUp;
            comboBoxTicketStatus.SelectedItem = ticket.Status.ToString();
            textBoxReportedByUser.Text = ticket.ReportedByUser;
        }

        private bool CheckForm()
        {
            return
                !string.IsNullOrEmpty(textBoxSubject.Text) &&
                comboBoxIncidentType.SelectedItem != null &&
                !string.IsNullOrEmpty(textBoxReportedByUser.Text) &&
                comboBoxPriority.SelectedItem != null &&
                !string.IsNullOrEmpty(textBoxDescription.Text);
        }
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(loggedInUser);
            dashboard.ShowDialog();
            this.Close();
        }

        private void buttonIncidentManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTicket viewticket = new ViewTicket(loggedInUser);
            viewticket.ShowDialog();
            this.Close();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement(loggedInUser);
            userManagement.ShowDialog();
            this.Close();
        }

        private void buttonUpdateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForm())
                {
                    var updateDefinition = Builders<Ticket>.Update
                        .Set(t => t.Subject, textBoxSubject.Text)
                        .Set(t => t.Description, textBoxDescription.Text)
                        .Set(t => t.IncidentType, (IncidentType)Enum.Parse(typeof(IncidentType), comboBoxIncidentType.SelectedItem.ToString()))
                        .Set(t => t.Priority, (Priority)Enum.Parse(typeof(Priority), comboBoxPriority.SelectedItem.ToString()))
                        .Set(t => t.DeadlineFollowUp, dateTimePickerDeadlineFollowUp.Value)
                        .Set(t => t.Status, (TicketStatus)Enum.Parse(typeof(TicketStatus), comboBoxTicketStatus.SelectedItem.ToString()));

                    ticketService.UpdateTicket(ticketToUpdate.ObjectId.ToString(), updateDefinition);

                    MessageBox.Show("Ticket has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
