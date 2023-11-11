using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }

        private void buttonViewHisOwnTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTicket viewTicket = new ViewTicket();
            viewTicket.ShowDialog();
            this.Close();
        }

        private void buttonAddIncident_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = "Temporary";
            user.Role = Role.Other;

            this.Hide();
            AddIncident addIncident = new AddIncident(user);
            addIncident.ShowDialog();
            this.Close();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement();
            userManagement.ShowDialog();
            this.Close();
        }
    }
}
