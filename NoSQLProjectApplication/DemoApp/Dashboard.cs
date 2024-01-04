using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using Logic; // Include the Logic namespace where DashboardLogic is located
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Text;

namespace DemoApp
{
    public partial class Dashboard : Form
    {
        private User loggedInUser;
        private DashboardService dashboardLogic; // Add a field for DashboardLogic

        public Dashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            this.dashboardLogic = new DashboardService(); // Instantiate DashboardLogic

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

        private void Dashboard_Load(object sender, EventArgs e)
        {         
           // UpdateDashboard();
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

        // New method to update the dashboard with ticket status percentages
        private void UpdateDashboard()
        {
            Dictionary<string, double> percentages = dashboardLogic.GetTicketStatusPercentages();

            // Assuming you have three pie charts named chartUnresolved, chartInProgress, and chartSolved
            UpdateChart(chartUnresolved, "Unresolved", percentages["Unresolved"]);
            UpdateChart(chartInProgress, "InProgress", percentages["InProgress"]);
            UpdateChart(chartTransferred, "Transferred", percentages["Transferred"]);
        }

        // New method to update a chart with given series name and percentage
        private void UpdateChart(Chart chart, string seriesName, double percentage)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Percentage", typeof(double));

            // Add row for all tickets with rounded percentage
            dataTable.Rows.Add("All Tickets", Math.Round(100 - percentage, 0));

            // Add row for unresolved incidents with rounded percentage
            dataTable.Rows.Add("Unresolved", Math.Round(percentage, 0));

            chart.DataSource = dataTable;
            chart.Series.Clear();
            chart.Series.Add(new Series(seriesName));

            // Set chart type to Pie explicitly
            chart.Series[seriesName].ChartType = SeriesChartType.Pie;

            // Enable data labels
            chart.Series[seriesName].IsValueShownAsLabel = true;
            chart.Series[seriesName].LabelFormat = "{0}%"; 

            // Adjust pie angle
            chart.Series[seriesName]["PieStartAngle"] = "90"; 

            chart.Series[seriesName].XValueMember = "Status";
            chart.Series[seriesName].YValueMembers = "Percentage";
            chart.DataBind();
        }
    }
}
