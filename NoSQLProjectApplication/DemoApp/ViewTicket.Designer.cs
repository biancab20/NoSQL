namespace DemoApp
{
    partial class ViewTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTicket));
            this.btnUser = new System.Windows.Forms.Button();
            this.incident = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.btnAddIncident = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.buttonDeleteIncident = new System.Windows.Forms.Button();
            this.buttonUpdateIncident = new System.Windows.Forms.Button();
            this.TheGardenGroup_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(566, 91);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(275, 40);
            this.btnUser.TabIndex = 10;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.user_Click);
            // 
            // incident
            // 
            this.incident.Location = new System.Drawing.Point(285, 91);
            this.incident.Name = "incident";
            this.incident.Size = new System.Drawing.Size(275, 40);
            this.incident.TabIndex = 9;
            this.incident.Text = "Incident Management";
            this.incident.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(4, 91);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(275, 40);
            this.dashboard.TabIndex = 8;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "NoDesk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tickets Overview";
            // 
            // listViewTickets
            // 
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(4, 185);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(837, 239);
            this.listViewTickets.TabIndex = 14;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.SelectedIndexChanged += new System.EventHandler(this.listViewTickets_SelectedIndexChanged);
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.Location = new System.Drawing.Point(622, 434);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(219, 36);
            this.btnAddIncident.TabIndex = 15;
            this.btnAddIncident.Text = "Add Incident";
            this.btnAddIncident.UseVisualStyleBackColor = true;
            this.btnAddIncident.Click += new System.EventHandler(this.btnAddIncident_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(575, 157);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(738, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // buttonDeleteIncident
            // 
            this.buttonDeleteIncident.Location = new System.Drawing.Point(4, 434);
            this.buttonDeleteIncident.Name = "buttonDeleteIncident";
            this.buttonDeleteIncident.Size = new System.Drawing.Size(219, 36);
            this.buttonDeleteIncident.TabIndex = 18;
            this.buttonDeleteIncident.Text = "Delete incident";
            this.buttonDeleteIncident.UseVisualStyleBackColor = true;
            this.buttonDeleteIncident.Click += new System.EventHandler(this.buttonDeleteIncident_Click);
            // 
            // buttonUpdateIncident
            // 
            this.buttonUpdateIncident.Location = new System.Drawing.Point(314, 434);
            this.buttonUpdateIncident.Name = "buttonUpdateIncident";
            this.buttonUpdateIncident.Size = new System.Drawing.Size(219, 36);
            this.buttonUpdateIncident.TabIndex = 19;
            this.buttonUpdateIncident.Text = "Update incident";
            this.buttonUpdateIncident.UseVisualStyleBackColor = true;
            this.buttonUpdateIncident.Click += new System.EventHandler(this.buttonUpdateIncident_Click);
            // 
            // TheGardenGroup_Logo
            // 
            this.TheGardenGroup_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.BackgroundImage")));
            this.TheGardenGroup_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.ErrorImage")));
            this.TheGardenGroup_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.InitialImage")));
            this.TheGardenGroup_Logo.Location = new System.Drawing.Point(12, 12);
            this.TheGardenGroup_Logo.Name = "TheGardenGroup_Logo";
            this.TheGardenGroup_Logo.Size = new System.Drawing.Size(195, 54);
            this.TheGardenGroup_Logo.TabIndex = 20;
            this.TheGardenGroup_Logo.TabStop = false;
            // 
            // ViewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 482);
            this.Controls.Add(this.TheGardenGroup_Logo);
            this.Controls.Add(this.buttonUpdateIncident);
            this.Controls.Add(this.buttonDeleteIncident);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(this.listViewTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.incident);
            this.Controls.Add(this.dashboard);
            this.Name = "ViewTicket";
            this.Text = "ViewTicket";
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button incident;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button buttonDeleteIncident;
        private System.Windows.Forms.Button buttonUpdateIncident;
        private System.Windows.Forms.PictureBox TheGardenGroup_Logo;
    }
}