namespace DemoApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnIncident = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TheGardenGroup_Logo = new System.Windows.Forms.PictureBox();
            this.chartUnresolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartInProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSolved)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "NoDesk";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(426, 70);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(206, 32);
            this.btnUser.TabIndex = 12;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnIncident
            // 
            this.btnIncident.Location = new System.Drawing.Point(215, 70);
            this.btnIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncident.Name = "btnIncident";
            this.btnIncident.Size = new System.Drawing.Size(206, 32);
            this.btnIncident.TabIndex = 11;
            this.btnIncident.Text = "Incident Management";
            this.btnIncident.UseVisualStyleBackColor = true;
            this.btnIncident.Click += new System.EventHandler(this.btnIncident_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TheGardenGroup_Logo
            // 
            this.TheGardenGroup_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.BackgroundImage")));
            this.TheGardenGroup_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.ErrorImage")));
            this.TheGardenGroup_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.InitialImage")));
            this.TheGardenGroup_Logo.Location = new System.Drawing.Point(9, 10);
            this.TheGardenGroup_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.TheGardenGroup_Logo.Name = "TheGardenGroup_Logo";
            this.TheGardenGroup_Logo.Size = new System.Drawing.Size(146, 44);
            this.TheGardenGroup_Logo.TabIndex = 21;
            this.TheGardenGroup_Logo.TabStop = false;
            // 
            // chartUnresolved
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUnresolved.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartUnresolved.Legends.Add(legend1);
            this.chartUnresolved.Location = new System.Drawing.Point(25, 146);
            this.chartUnresolved.Name = "chartUnresolved";
            this.chartUnresolved.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Unresolved";
            this.chartUnresolved.Series.Add(series1);
            this.chartUnresolved.Size = new System.Drawing.Size(153, 159);
            this.chartUnresolved.TabIndex = 22;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Unresolved Incidents";
            title1.Text = "Unresolved Incidents";
            this.chartUnresolved.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current Incidents";
            // 
            // chartInProgress
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInProgress.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chartInProgress.Legends.Add(legend2);
            this.chartInProgress.Location = new System.Drawing.Point(242, 146);
            this.chartInProgress.Name = "chartInProgress";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "InProgress";
            this.chartInProgress.Series.Add(series2);
            this.chartInProgress.Size = new System.Drawing.Size(153, 159);
            this.chartInProgress.TabIndex = 24;
            this.chartInProgress.Text = "InProgress Incidents";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "InProgress Incidents";
            title2.Text = "InProgress Incidents";
            this.chartInProgress.Titles.Add(title2);
            // 
            // chartSolved
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSolved.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.chartSolved.Legends.Add(legend3);
            this.chartSolved.Location = new System.Drawing.Point(468, 146);
            this.chartSolved.Name = "chartSolved";
            this.chartSolved.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Solved";
            this.chartSolved.Series.Add(series3);
            this.chartSolved.Size = new System.Drawing.Size(153, 159);
            this.chartSolved.TabIndex = 25;
            this.chartSolved.Text = "Solved";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title3.Name = "Solved Tickets";
            title3.Text = "Solved Tickets";
            this.chartSolved.Titles.Add(title3);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 357);
            this.Controls.Add(this.chartSolved);
            this.Controls.Add(this.chartInProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartUnresolved);
            this.Controls.Add(this.TheGardenGroup_Logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnIncident);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSolved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnIncident;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox TheGardenGroup_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInProgress;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSolved;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUnresolved;
    }
}