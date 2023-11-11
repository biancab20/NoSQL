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
        private User user;

        public Dashboard()
        {
            InitializeComponent();
        }


        public Dashboard(User user)
        {
            this.user = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
