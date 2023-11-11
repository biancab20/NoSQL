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
            this.txtUpdatedPassword = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_resetPassword = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.TheGardenGroup_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(288, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnUpdatePassword.Location = new System.Drawing.Point(190, 353);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(181, 47);
            this.btnUpdatePassword.TabIndex = 1;
            this.btnUpdatePassword.Text = "UpdatePassword";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // txtUpdatedPassword
            // 
            this.txtUpdatedPassword.Location = new System.Drawing.Point(288, 273);
            this.txtUpdatedPassword.Name = "txtUpdatedPassword";
            this.txtUpdatedPassword.Size = new System.Drawing.Size(142, 22);
            this.txtUpdatedPassword.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_email.Location = new System.Drawing.Point(121, 221);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(53, 21);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_resetPassword
            // 
            this.lbl_resetPassword.AutoSize = true;
            this.lbl_resetPassword.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_resetPassword.Location = new System.Drawing.Point(74, 116);
            this.lbl_resetPassword.Name = "lbl_resetPassword";
            this.lbl_resetPassword.Size = new System.Drawing.Size(430, 58);
            this.lbl_resetPassword.TabIndex = 4;
            this.lbl_resetPassword.Text = "Reset your password";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_newPassword.Location = new System.Drawing.Point(121, 273);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(120, 21);
            this.lbl_newPassword.TabIndex = 5;
            this.lbl_newPassword.Text = "New password:";
            // 
            // TheGardenGroup_Logo
            // 
            this.TheGardenGroup_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.BackgroundImage")));
            this.TheGardenGroup_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.ErrorImage")));
            this.TheGardenGroup_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TheGardenGroup_Logo.InitialImage")));
            this.TheGardenGroup_Logo.Location = new System.Drawing.Point(324, 34);
            this.TheGardenGroup_Logo.Name = "TheGardenGroup_Logo";
            this.TheGardenGroup_Logo.Size = new System.Drawing.Size(195, 54);
            this.TheGardenGroup_Logo.TabIndex = 6;
            this.TheGardenGroup_Logo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 494);
            this.Controls.Add(this.TheGardenGroup_Logo);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.lbl_resetPassword);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtUpdatedPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "Form2";
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.TheGardenGroup_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdatedPassword;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_resetPassword;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.PictureBox TheGardenGroup_Logo;
    }
}