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
using LiveCharts;


namespace DemoApp
{
    public partial class Dashboard : Form
    {
        private List<Ticket> allTickets;
        private User loggedInUser;

        public Dashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;

            if (loggedInUser.Role == Role.ServiceDesk)
            {
                StyleServiceDesk();
            }
            else
            {
                StyleOther();
            }
        }

        private void StyleServiceDesk()
        {
            btnUser.Visible = true;
        }

        private void StyleOther()
        {
            btnUser.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnIncident_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTicket viewticket = new ViewTicket(loggedInUser);
            viewticket.ShowDialog();
            this.Close();
        
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement(loggedInUser);
            userManagement.Show();
            this.Close();
        }
    }
}
