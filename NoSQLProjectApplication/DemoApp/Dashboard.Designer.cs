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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnIncident = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TheGardenGroup_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "NoDesk";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(568, 86);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(275, 40);
            this.btnUser.TabIndex = 12;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnIncident
            // 
            this.btnIncident.Location = new System.Drawing.Point(287, 86);
            this.btnIncident.Name = "btnIncident";
            this.btnIncident.Size = new System.Drawing.Size(275, 40);
            this.btnIncident.TabIndex = 11;
            this.btnIncident.Text = "Incident Management";
            this.btnIncident.UseVisualStyleBackColor = true;
            this.btnIncident.Click += new System.EventHandler(this.btnIncident_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TheGardenGroup_Logo
            // 
            this.TheGardenGroup_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.BackgroundImage")));
            this.TheGardenGroup_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.ErrorImage")));
            this.TheGardenGroup_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.InitialImage")));
            this.TheGardenGroup_Logo.Location = new System.Drawing.Point(12, 12);
            this.TheGardenGroup_Logo.Name = "TheGardenGroup_Logo";
            this.TheGardenGroup_Logo.Size = new System.Drawing.Size(195, 54);
            this.TheGardenGroup_Logo.TabIndex = 21;
            this.TheGardenGroup_Logo.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 439);
            this.Controls.Add(this.TheGardenGroup_Logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnIncident);
            this.Controls.Add(this.button1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).EndInit();
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
    }
}