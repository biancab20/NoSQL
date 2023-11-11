namespace DemoApp
{
    partial class AddIncident
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelIncident = new System.Windows.Forms.Label();
            this.labelReportedByUser = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelDeadlineFollowUp = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePickerReported = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmitTicket = new System.Windows.Forms.Button();
            this.dateTimePickerDeadlineFollowUp = new System.Windows.Forms.DateTimePicker();
            this.comboBoxIncidentType = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.textBoxReportedByUser = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Incident Management";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "User Management";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "NoDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(30, 200);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(128, 16);
            this.labelDateTime.TabIndex = 5;
            this.labelDateTime.Text = "Date/Time reported:";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.labelTopic.Location = new System.Drawing.Point(26, 140);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(381, 37);
            this.labelTopic.TabIndex = 6;
            this.labelTopic.Text = "Create new incident ticket";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(30, 230);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(115, 16);
            this.labelSubject.TabIndex = 7;
            this.labelSubject.Text = "Subject of incident";
            // 
            // labelIncident
            // 
            this.labelIncident.AutoSize = true;
            this.labelIncident.Location = new System.Drawing.Point(30, 260);
            this.labelIncident.Name = "labelIncident";
            this.labelIncident.Size = new System.Drawing.Size(102, 16);
            this.labelIncident.TabIndex = 8;
            this.labelIncident.Text = "Type of incident";
            // 
            // labelReportedByUser
            // 
            this.labelReportedByUser.AutoSize = true;
            this.labelReportedByUser.Location = new System.Drawing.Point(30, 290);
            this.labelReportedByUser.Name = "labelReportedByUser";
            this.labelReportedByUser.Size = new System.Drawing.Size(114, 16);
            this.labelReportedByUser.TabIndex = 9;
            this.labelReportedByUser.Text = "Reported by user:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(30, 320);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(48, 16);
            this.labelPriority.TabIndex = 10;
            this.labelPriority.Text = "Priority";
            // 
            // labelDeadlineFollowUp
            // 
            this.labelDeadlineFollowUp.AutoSize = true;
            this.labelDeadlineFollowUp.Location = new System.Drawing.Point(30, 350);
            this.labelDeadlineFollowUp.Name = "labelDeadlineFollowUp";
            this.labelDeadlineFollowUp.Size = new System.Drawing.Size(129, 16);
            this.labelDeadlineFollowUp.TabIndex = 11;
            this.labelDeadlineFollowUp.Text = "Deadline / Follow up";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(30, 380);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePickerReported
            // 
            this.dateTimePickerReported.Location = new System.Drawing.Point(228, 200);
            this.dateTimePickerReported.Name = "dateTimePickerReported";
            this.dateTimePickerReported.Size = new System.Drawing.Size(368, 22);
            this.dateTimePickerReported.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(228, 380);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(368, 124);
            this.textBoxDescription.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(228, 510);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(179, 52);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmitTicket
            // 
            this.buttonSubmitTicket.Location = new System.Drawing.Point(417, 510);
            this.buttonSubmitTicket.Name = "buttonSubmitTicket";
            this.buttonSubmitTicket.Size = new System.Drawing.Size(179, 52);
            this.buttonSubmitTicket.TabIndex = 11;
            this.buttonSubmitTicket.Text = "SUBMIT TICKET";
            this.buttonSubmitTicket.UseVisualStyleBackColor = true;
            this.buttonSubmitTicket.Click += new System.EventHandler(this.buttonSubmitTicket_Click);
            // 
            // dateTimePickerDeadlineFollowUp
            // 
            this.dateTimePickerDeadlineFollowUp.Location = new System.Drawing.Point(228, 350);
            this.dateTimePickerDeadlineFollowUp.Name = "dateTimePickerDeadlineFollowUp";
            this.dateTimePickerDeadlineFollowUp.Size = new System.Drawing.Size(368, 22);
            this.dateTimePickerDeadlineFollowUp.TabIndex = 8;
            // 
            // comboBoxIncidentType
            // 
            this.comboBoxIncidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncidentType.FormattingEnabled = true;
            this.comboBoxIncidentType.Location = new System.Drawing.Point(228, 260);
            this.comboBoxIncidentType.Name = "comboBoxIncidentType";
            this.comboBoxIncidentType.Size = new System.Drawing.Size(368, 24);
            this.comboBoxIncidentType.TabIndex = 5;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(228, 320);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(368, 24);
            this.comboBoxPriority.TabIndex = 7;
            // 
            // textBoxReportedByUser
            // 
            this.textBoxReportedByUser.Location = new System.Drawing.Point(228, 290);
            this.textBoxReportedByUser.Name = "textBoxReportedByUser";
            this.textBoxReportedByUser.Size = new System.Drawing.Size(368, 22);
            this.textBoxReportedByUser.TabIndex = 6;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(228, 230);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(368, 22);
            this.textBoxSubject.TabIndex = 4;
            // 
            // AddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 592);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxReportedByUser);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxIncidentType);
            this.Controls.Add(this.dateTimePickerDeadlineFollowUp);
            this.Controls.Add(this.buttonSubmitTicket);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dateTimePickerReported);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDeadlineFollowUp);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelReportedByUser);
            this.Controls.Add(this.labelIncident);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddIncident";
            this.Text = "AddIncident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelIncident;
        private System.Windows.Forms.Label labelReportedByUser;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelDeadlineFollowUp;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReported;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmitTicket;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadlineFollowUp;
        private System.Windows.Forms.ComboBox comboBoxIncidentType;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.TextBox textBoxReportedByUser;
        private System.Windows.Forms.TextBox textBoxSubject;
    }
}