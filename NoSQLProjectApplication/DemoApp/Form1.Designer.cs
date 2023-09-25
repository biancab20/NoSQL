
namespace DemoApp
{
    partial class Form1
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonViewHisOwnTicket = new System.Windows.Forms.Button();
            this.buttonAddIncident = new System.Windows.Forms.Button();
            this.labelTemporaryForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(72, 78);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(146, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(72, 107);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(146, 23);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonViewHisOwnTicket
            // 
            this.buttonViewHisOwnTicket.Location = new System.Drawing.Point(72, 136);
            this.buttonViewHisOwnTicket.Name = "buttonViewHisOwnTicket";
            this.buttonViewHisOwnTicket.Size = new System.Drawing.Size(146, 23);
            this.buttonViewHisOwnTicket.TabIndex = 2;
            this.buttonViewHisOwnTicket.Text = "View his own ticket";
            this.buttonViewHisOwnTicket.UseVisualStyleBackColor = true;
            this.buttonViewHisOwnTicket.Click += new System.EventHandler(this.buttonViewHisOwnTicket_Click);
            // 
            // buttonAddIncident
            // 
            this.buttonAddIncident.Location = new System.Drawing.Point(72, 165);
            this.buttonAddIncident.Name = "buttonAddIncident";
            this.buttonAddIncident.Size = new System.Drawing.Size(146, 23);
            this.buttonAddIncident.TabIndex = 3;
            this.buttonAddIncident.Text = "Add Incident";
            this.buttonAddIncident.UseVisualStyleBackColor = true;
            this.buttonAddIncident.Click += new System.EventHandler(this.buttonAddIncident_Click);
            // 
            // labelTemporaryForm
            // 
            this.labelTemporaryForm.AutoSize = true;
            this.labelTemporaryForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemporaryForm.Location = new System.Drawing.Point(50, 32);
            this.labelTemporaryForm.Name = "labelTemporaryForm";
            this.labelTemporaryForm.Size = new System.Drawing.Size(185, 29);
            this.labelTemporaryForm.TabIndex = 4;
            this.labelTemporaryForm.Text = "Temporary form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 235);
            this.Controls.Add(this.labelTemporaryForm);
            this.Controls.Add(this.buttonAddIncident);
            this.Controls.Add(this.buttonViewHisOwnTicket);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonViewHisOwnTicket;
        private System.Windows.Forms.Button buttonAddIncident;
        private System.Windows.Forms.Label labelTemporaryForm;
    }
}

