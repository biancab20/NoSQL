﻿namespace DemoApp
{
    partial class UserManagement
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterByEmail = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnFilterByEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Button();
            this.incident = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUsers
            // 
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(6, 194);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(829, 324);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Management";
            // 
            // txtFilterByEmail
            // 
            this.txtFilterByEmail.Location = new System.Drawing.Point(22, 164);
            this.txtFilterByEmail.Name = "txtFilterByEmail";
            this.txtFilterByEmail.Size = new System.Drawing.Size(156, 22);
            this.txtFilterByEmail.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(671, 141);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(164, 46);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // btnFilterByEmail
            // 
            this.btnFilterByEmail.Location = new System.Drawing.Point(193, 162);
            this.btnFilterByEmail.Name = "btnFilterByEmail";
            this.btnFilterByEmail.Size = new System.Drawing.Size(75, 26);
            this.btnFilterByEmail.TabIndex = 4;
            this.btnFilterByEmail.Text = "Search";
            this.btnFilterByEmail.UseVisualStyleBackColor = true;
            this.btnFilterByEmail.Click += new System.EventHandler(this.btnFilterByEmail_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "NoDesk";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(568, 72);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(275, 40);
            this.user.TabIndex = 7;
            this.user.Text = "User Management";
            this.user.UseVisualStyleBackColor = true;
            // 
            // incident
            // 
            this.incident.Location = new System.Drawing.Point(287, 72);
            this.incident.Name = "incident";
            this.incident.Size = new System.Drawing.Size(275, 40);
            this.incident.TabIndex = 6;
            this.incident.Text = "Incident Management";
            this.incident.UseVisualStyleBackColor = true;
            this.incident.Click += new System.EventHandler(this.incident_Click);
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(6, 72);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(275, 40);
            this.dashboard.TabIndex = 5;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user);
            this.Controls.Add(this.incident);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.btnFilterByEmail);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtFilterByEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewUsers);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterByEmail;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnFilterByEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button incident;
        private System.Windows.Forms.Button dashboard;
    }
}