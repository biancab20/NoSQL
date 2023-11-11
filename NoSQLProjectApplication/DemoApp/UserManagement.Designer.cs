namespace DemoApp
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
            this.SuspendLayout();
            // 
            // listViewUsers
            // 
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(29, 194);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(730, 244);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Management";
            // 
            // txtFilterByEmail
            // 
            this.txtFilterByEmail.Location = new System.Drawing.Point(29, 131);
            this.txtFilterByEmail.Name = "txtFilterByEmail";
            this.txtFilterByEmail.Size = new System.Drawing.Size(156, 22);
            this.txtFilterByEmail.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(595, 142);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(164, 46);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // btnFilterByEmail
            // 
            this.btnFilterByEmail.Location = new System.Drawing.Point(212, 129);
            this.btnFilterByEmail.Name = "btnFilterByEmail";
            this.btnFilterByEmail.Size = new System.Drawing.Size(75, 23);
            this.btnFilterByEmail.TabIndex = 4;
            this.btnFilterByEmail.Text = "Search";
            this.btnFilterByEmail.UseVisualStyleBackColor = true;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}