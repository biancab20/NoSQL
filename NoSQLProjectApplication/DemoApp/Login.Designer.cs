namespace DemoApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.TheGardenGroup_Logo = new System.Windows.Forms.PictureBox();
            this.label_welcome = new System.Windows.Forms.Label();
            this.pictureBox_background = new System.Windows.Forms.PictureBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_forgotPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Honeydew;
            this.label_username.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(167, 277);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(92, 21);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username :";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Honeydew;
            this.label_password.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_password.Location = new System.Drawing.Point(167, 324);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(91, 21);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password  :";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(265, 276);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(147, 22);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(265, 324);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(147, 22);
            this.textBox_password.TabIndex = 3;
            // 
            // TheGardenGroup_Logo
            // 
            this.TheGardenGroup_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.BackgroundImage")));
            this.TheGardenGroup_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.ErrorImage")));
            this.TheGardenGroup_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.InitialImage")));
            this.TheGardenGroup_Logo.Location = new System.Drawing.Point(348, 12);
            this.TheGardenGroup_Logo.Name = "TheGardenGroup_Logo";
            this.TheGardenGroup_Logo.Size = new System.Drawing.Size(195, 54);
            this.TheGardenGroup_Logo.TabIndex = 4;
            this.TheGardenGroup_Logo.TabStop = false;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(188, 101);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(209, 58);
            this.label_welcome.TabIndex = 5;
            this.label_welcome.Text = "Welcome";
            // 
            // pictureBox_background
            // 
            this.pictureBox_background.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox_background.Location = new System.Drawing.Point(136, 192);
            this.pictureBox_background.Name = "pictureBox_background";
            this.pictureBox_background.Size = new System.Drawing.Size(309, 263);
            this.pictureBox_background.TabIndex = 6;
            this.pictureBox_background.TabStop = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_login.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_login.Location = new System.Drawing.Point(231, 394);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(129, 34);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Honeydew;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(251, 205);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(87, 29);
            this.label_login.TabIndex = 8;
            this.label_login.Text = "LOGIN";
            // 
            // label_forgotPassword
            // 
            this.label_forgotPassword.AutoSize = true;
            this.label_forgotPassword.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forgotPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_forgotPassword.Location = new System.Drawing.Point(210, 506);
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Size = new System.Drawing.Size(187, 24);
            this.label_forgotPassword.TabIndex = 9;
            this.label_forgotPassword.Text = "I forgot my password";
            this.label_forgotPassword.Click += new System.EventHandler(this.label_forgotPassword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 597);
            this.Controls.Add(this.label_forgotPassword);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.TheGardenGroup_Logo);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox_background);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox TheGardenGroup_Logo;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.PictureBox pictureBox_background;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_forgotPassword;
    }
}