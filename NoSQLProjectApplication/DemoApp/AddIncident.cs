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
using Logic;
using Model;

namespace DemoApp
{
    public partial class AddIncident : Form
    {
        private TicketService ticketService;

        public AddIncident()
        {
            InitializeComponent();
            // Tell form which user is logged in for form
            ClearFormData();
            FillComboBoxesData();

            ticketService = new TicketService();
        }

        private void FillComboBoxesData()
        {
            foreach (int types in IncidentType.GetValues(typeof(IncidentType)))
            {
                comboBoxIncidentType.Items.Add(Enum.GetName(typeof(IncidentType), types));
            }
            foreach (int priority in Priority.GetValues(typeof(Priority)))
            {
                comboBoxPriority.Items.Add(Enum.GetName(typeof(Priority), priority));
            }
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
            // Go back to previous screen or Dashboard
        }

        private void buttonSubmitTicket_Click(object sender, EventArgs e)
        {
            IncidentAdd();
        }

        private void IncidentAdd()
        {
            try
            {
                Ticket ticket = new Ticket();

                ticket.DateTimeReported = dateTimePickerReported.Value;
                ticket.Subject = textBoxSubject.Text;
                ticket.IncidentType = (IncidentType)comboBoxIncidentType.SelectedIndex;
                ticket.ReportedByUser = textBoxReportedByUser.Text; // Tell form which user is currently logged in
                ticket.Priority = (Priority)comboBoxPriority.SelectedIndex;
                ticket.DeadlineFollowUp = dateTimePickerDeadlineFollowUp.Value;
                ticket.Description = textBoxDescription.Text;
                ticket.Status = TicketStatus.Unresolved;

                ticketService.CreateTicket(ticket);
                MessageBox.Show("Ticket has been created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
