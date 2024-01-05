using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using Logic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Text;

namespace DemoApp
{
    public partial class Dashboard : Form
    {
        private User loggedInUser;
        private DashboardService dashboardLogic;

        public Dashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            this.dashboardLogic = new DashboardService();

            if (loggedInUser.Role == Role.ServiceDesk)
            {
                StyleServiceDesk();
            }
            else
            {
                StyleOther();
            }

            UpdateDashboard();
        }

        private void StyleServiceDesk()
        {
            btnUser.Visible = true;
        }

        private void StyleOther()
        {
            btnUser.Visible = false;
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
            userManagement.ShowDialog();
            this.Close();
        }

        private void UpdateDashboard()
        {
            Dictionary<string, double> percentages = dashboardLogic.GetTicketStatusPercentages();

            // Updates the legends and data for each chart
            UpdateChart(chartUnresolved, "Unresolved", percentages["Unresolved"], "Unresolved");
            UpdateChart(chartInProgress, "InProgress", percentages["InProgress"], "In Progress ");
            UpdateChart(chartSolved, "Solved", percentages["Solved"], "Solved Tickets");
        }

        private void UpdateChart(Chart chart, string seriesName, double percentage, string legend2)
        {
            DataTable dataTable = new DataTable(); 
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Percentage", typeof(double));
         
            dataTable.Rows.Add("All Tickets", Math.Round(100 - percentage, 0));

            dataTable.Rows.Add(legend2, Math.Round(percentage, 0));

            chart.DataSource = dataTable;
            chart.Series.Clear();
            chart.Series.Add(new Series(seriesName));

            chart.Series[seriesName].ChartType = SeriesChartType.Pie;

            chart.Series[seriesName].IsValueShownAsLabel = true;
            chart.Series[seriesName].LabelFormat = "{0}%";

            chart.Series[seriesName]["PieStartAngle"] = "90";

            chart.Series[seriesName].XValueMember = "Status";
            chart.Series[seriesName].YValueMembers = "Percentage";
            chart.DataBind();
        }
    }
}
