namespace DemoApp
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_resetPassword = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.TheGardenGroup_Logo = new System.Windows.Forms.PictureBox();
            this.btnSendToken = new System.Windows.Forms.Button();
            this.lbl_token = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lbl_newPasswordConfirmed = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnUpdatePassword.Location = new System.Drawing.Point(193, 577);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(181, 47);
            this.btnUpdatePassword.TabIndex = 1;
            this.btnUpdatePassword.Text = "UpdatePassword";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(84, 427);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_email.Location = new System.Drawing.Point(80, 157);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(191, 21);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Enter your email address:";
            // 
            // lbl_resetPassword
            // 
            this.lbl_resetPassword.AutoSize = true;
            this.lbl_resetPassword.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_resetPassword.Location = new System.Drawing.Point(74, 78);
            this.lbl_resetPassword.Name = "lbl_resetPassword";
            this.lbl_resetPassword.Size = new System.Drawing.Size(430, 58);
            this.lbl_resetPassword.TabIndex = 4;
            this.lbl_resetPassword.Text = "Reset your password";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_newPassword.Location = new System.Drawing.Point(80, 389);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(172, 21);
            this.lbl_newPassword.TabIndex = 5;
            this.lbl_newPassword.Text = "Enter a new password:";
            // 
            // TheGardenGroup_Logo
            // 
            this.TheGardenGroup_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.BackgroundImage")));
            this.TheGardenGroup_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.ErrorImage")));
            this.TheGardenGroup_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.InitialImage")));
            this.TheGardenGroup_Logo.Location = new System.Drawing.Point(324, 12);
            this.TheGardenGroup_Logo.Name = "TheGardenGroup_Logo";
            this.TheGardenGroup_Logo.Size = new System.Drawing.Size(195, 54);
            this.TheGardenGroup_Logo.TabIndex = 6;
            this.TheGardenGroup_Logo.TabStop = false;
            // 
            // btnSendToken
            // 
            this.btnSendToken.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSendToken.Location = new System.Drawing.Point(193, 241);
            this.btnSendToken.Name = "btnSendToken";
            this.btnSendToken.Size = new System.Drawing.Size(181, 47);
            this.btnSendToken.TabIndex = 7;
            this.btnSendToken.Text = "Send Token";
            this.btnSendToken.UseVisualStyleBackColor = false;
            this.btnSendToken.Click += new System.EventHandler(this.btnSendToken_Click);
            // 
            // lbl_token
            // 
            this.lbl_token.AutoSize = true;
            this.lbl_token.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_token.Location = new System.Drawing.Point(80, 315);
            this.lbl_token.Name = "lbl_token";
            this.lbl_token.Size = new System.Drawing.Size(134, 21);
            this.lbl_token.TabIndex = 8;
            this.lbl_token.Text = "Enter your token:";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(84, 349);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(290, 22);
            this.txtToken.TabIndex = 9;
            // 
            // lbl_newPasswordConfirmed
            // 
            this.lbl_newPasswordConfirmed.AutoSize = true;
            this.lbl_newPasswordConfirmed.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_newPasswordConfirmed.Location = new System.Drawing.Point(80, 470);
            this.lbl_newPasswordConfirmed.Name = "lbl_newPasswordConfirmed";
            this.lbl_newPasswordConfirmed.Size = new System.Drawing.Size(179, 21);
            this.lbl_newPasswordConfirmed.TabIndex = 10;
            this.lbl_newPasswordConfirmed.Text = "Confirm your password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(84, 511);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(290, 22);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 685);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lbl_newPasswordConfirmed);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lbl_token);
            this.Controls.Add(this.btnSendToken);
            this.Controls.Add(this.TheGardenGroup_Logo);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.lbl_resetPassword);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_resetPassword;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.PictureBox TheGardenGroup_Logo;
        private System.Windows.Forms.Button btnSendToken;
        private System.Windows.Forms.Label lbl_token;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lbl_newPasswordConfirmed;
        private System.Windows.Forms.TextBox txtConfirmPassword;
    }
}