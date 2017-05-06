namespace AServiceController
{
    partial class ctrlServiceDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkCanRaiseEvents = new System.Windows.Forms.CheckBox();
            this.chkCanPauseContinue = new System.Windows.Forms.CheckBox();
            this.chkCanShutdown = new System.Windows.Forms.CheckBox();
            this.chkCanStop = new System.Windows.Forms.CheckBox();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.txtStartType = new System.Windows.Forms.TextBox();
            this.lblStartType = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.bsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.AutoSize = true;
            this.panelDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDetails.Controls.Add(this.lblDescription);
            this.panelDetails.Controls.Add(this.chkCanRaiseEvents);
            this.panelDetails.Controls.Add(this.chkCanPauseContinue);
            this.panelDetails.Controls.Add(this.chkCanShutdown);
            this.panelDetails.Controls.Add(this.chkCanStop);
            this.panelDetails.Controls.Add(this.txtServiceType);
            this.panelDetails.Controls.Add(this.lblServiceType);
            this.panelDetails.Controls.Add(this.txtStartType);
            this.panelDetails.Controls.Add(this.lblStartType);
            this.panelDetails.Controls.Add(this.txtStatus);
            this.panelDetails.Controls.Add(this.lblStatus);
            this.panelDetails.Controls.Add(this.txtDisplayName);
            this.panelDetails.Controls.Add(this.lblDisplayName);
            this.panelDetails.Controls.Add(this.txtMachineName);
            this.panelDetails.Controls.Add(this.lblMachineName);
            this.panelDetails.Controls.Add(this.txtDescription);
            this.panelDetails.Controls.Add(this.txtServiceName);
            this.panelDetails.Controls.Add(this.lblServiceName);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(478, 284);
            this.panelDetails.TabIndex = 0;
            this.panelDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlServiceDetails_MouseDown);
            this.panelDetails.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDetails_MouseMove);
            this.panelDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDetails_MouseUp);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 153);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(130, 17);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Service Description";
            // 
            // chkCanRaiseEvents
            // 
            this.chkCanRaiseEvents.AutoSize = true;
            this.chkCanRaiseEvents.Location = new System.Drawing.Point(106, 130);
            this.chkCanRaiseEvents.Name = "chkCanRaiseEvents";
            this.chkCanRaiseEvents.Size = new System.Drawing.Size(142, 21);
            this.chkCanRaiseEvents.TabIndex = 19;
            this.chkCanRaiseEvents.Text = "Can Raise Events";
            this.chkCanRaiseEvents.UseVisualStyleBackColor = true;
            // 
            // chkCanPauseContinue
            // 
            this.chkCanPauseContinue.AutoSize = true;
            this.chkCanPauseContinue.Location = new System.Drawing.Point(264, 130);
            this.chkCanPauseContinue.Name = "chkCanPauseContinue";
            this.chkCanPauseContinue.Size = new System.Drawing.Size(160, 21);
            this.chkCanPauseContinue.TabIndex = 18;
            this.chkCanPauseContinue.Text = "Can Pause-Continue";
            this.chkCanPauseContinue.UseVisualStyleBackColor = true;
            // 
            // chkCanShutdown
            // 
            this.chkCanShutdown.AutoSize = true;
            this.chkCanShutdown.Location = new System.Drawing.Point(339, 103);
            this.chkCanShutdown.Name = "chkCanShutdown";
            this.chkCanShutdown.Size = new System.Drawing.Size(121, 21);
            this.chkCanShutdown.TabIndex = 17;
            this.chkCanShutdown.Text = "Can Shutdown";
            this.chkCanShutdown.UseVisualStyleBackColor = true;
            // 
            // chkCanStop
            // 
            this.chkCanStop.AutoSize = true;
            this.chkCanStop.Location = new System.Drawing.Point(224, 103);
            this.chkCanStop.Name = "chkCanStop";
            this.chkCanStop.Size = new System.Drawing.Size(88, 21);
            this.chkCanStop.TabIndex = 16;
            this.chkCanStop.Text = "Can Stop";
            this.chkCanStop.UseVisualStyleBackColor = true;
            // 
            // txtServiceType
            // 
            this.txtServiceType.Location = new System.Drawing.Point(106, 75);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(133, 22);
            this.txtServiceType.TabIndex = 13;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(10, 78);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(91, 17);
            this.lblServiceType.TabIndex = 12;
            this.lblServiceType.Text = "Service Type";
            // 
            // txtStartType
            // 
            this.txtStartType.Location = new System.Drawing.Point(343, 75);
            this.txtStartType.Name = "txtStartType";
            this.txtStartType.Size = new System.Drawing.Size(117, 22);
            this.txtStartType.TabIndex = 11;
            // 
            // lblStartType
            // 
            this.lblStartType.AutoSize = true;
            this.lblStartType.Location = new System.Drawing.Point(247, 78);
            this.lblStartType.Name = "lblStartType";
            this.lblStartType.Size = new System.Drawing.Size(90, 17);
            this.lblStartType.TabIndex = 10;
            this.lblStartType.Text = "Startup Type";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(106, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(106, 47);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(354, 22);
            this.txtDisplayName.TabIndex = 7;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(10, 50);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(95, 17);
            this.lblDisplayName.TabIndex = 6;
            this.lblDisplayName.Text = "Display Name";
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(347, 16);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(113, 22);
            this.txtMachineName.TabIndex = 5;
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(245, 19);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(102, 17);
            this.lblMachineName.TabIndex = 4;
            this.lblMachineName.Text = "Machine Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(13, 173);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(447, 84);
            this.txtDescription.TabIndex = 3;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(106, 16);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(133, 22);
            this.txtServiceName.TabIndex = 1;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(10, 19);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(96, 17);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Service Name";
            // 
            // ctrlServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetails);
            this.Name = "ctrlServiceDetails";
            this.Size = new System.Drawing.Size(478, 284);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlServiceDetails_MouseDown);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.TextBox txtStartType;
        private System.Windows.Forms.Label lblStartType;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkCanRaiseEvents;
        private System.Windows.Forms.CheckBox chkCanPauseContinue;
        private System.Windows.Forms.CheckBox chkCanShutdown;
        private System.Windows.Forms.CheckBox chkCanStop;
        private System.Windows.Forms.BindingSource bsDetails;
    }
}
