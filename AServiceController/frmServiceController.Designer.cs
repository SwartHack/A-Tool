namespace AServiceController
{
    partial class frmSvcCtlr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSvcCtlr));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Win 32 Own Process");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Win 32 Share Process");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Process Services", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Adapter");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("File System");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Interactive");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Kernel");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Recognizer");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Device Services", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("My Service Groups", 2, 2);
            this.tvMainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilServices = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMemory = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.option2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.option2sub1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.option2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.option1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.option1sub1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timerMemory = new System.Windows.Forms.Timer(this.components);
            this.deleteServiceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbServiceDetails = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkCanPauseContinue = new System.Windows.Forms.CheckBox();
            this.chkCanShutDown = new System.Windows.Forms.CheckBox();
            this.chkCanStop = new System.Windows.Forms.CheckBox();
            this.lblServiceStartType = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvServices = new System.Windows.Forms.TreeView();
            this.consoleDebug = new ConsoleControl.ConsoleControl();
            this.toolStripConsole = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsServices = new System.Windows.Forms.ToolStrip();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.tsddbOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.cascadeStart = new System.Windows.Forms.ToolStripMenuItem();
            this.showRunningServicesOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.enableProcessMonitoring = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDetails = new System.Windows.Forms.ToolStripButton();
            this.tsbDebugConsole = new System.Windows.Forms.ToolStripButton();
            this.deleteGroupContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tvMainContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.deleteServiceContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbServiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripConsole.SuspendLayout();
            this.tsServices.SuspendLayout();
            this.deleteGroupContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvMainContextMenu
            // 
            this.tvMainContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tvMainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGroupToolStripMenuItem});
            this.tvMainContextMenu.Name = "tvContextMenu";
            this.tvMainContextMenu.Size = new System.Drawing.Size(160, 30);
            // 
            // newGroupToolStripMenuItem
            // 
            this.newGroupToolStripMenuItem.Name = "newGroupToolStripMenuItem";
            this.newGroupToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.newGroupToolStripMenuItem.Text = "New Group";
            this.newGroupToolStripMenuItem.Click += new System.EventHandler(this.newGroupToolStripMenuItem_Click);
            // 
            // ilServices
            // 
            this.ilServices.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilServices.ImageStream")));
            this.ilServices.TransparentColor = System.Drawing.Color.Transparent;
            this.ilServices.Images.SetKeyName(0, "Driver.ico");
            this.ilServices.Images.SetKeyName(1, "ProcessServices.ico");
            this.ilServices.Images.SetKeyName(2, "Disco-Ball.png");
            this.ilServices.Images.SetKeyName(3, "DriverRunning32.png");
            this.ilServices.Images.SetKeyName(4, "DriverStopped32.png");
            this.ilServices.Images.SetKeyName(5, "ServiceStop.png");
            this.ilServices.Images.SetKeyName(6, "ServiceRunning.png");
            this.ilServices.Images.SetKeyName(7, "steal_your_face_by_toshiyo.jpg");
            this.ilServices.Images.SetKeyName(8, "OCF.ico");
            this.ilServices.Images.SetKeyName(9, "Cancel.ico");
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMain,
            this.tsslMemory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1202, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslMain
            // 
            this.tsslMain.Name = "tsslMain";
            this.tsslMain.Size = new System.Drawing.Size(1131, 20);
            this.tsslMain.Spring = true;
            this.tsslMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslMemory
            // 
            this.tsslMemory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslMemory.Name = "tsslMemory";
            this.tsslMemory.Size = new System.Drawing.Size(56, 20);
            this.tsslMemory.Text = "% used";
            // 
            // tssMessage
            // 
            this.tssMessage.Name = "tssMessage";
            this.tssMessage.Size = new System.Drawing.Size(82, 21);
            this.tssMessage.Text = "Messages...";
            // 
            // option2ToolStripMenuItem2
            // 
            this.option2ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option2sub1ToolStripMenuItem});
            this.option2ToolStripMenuItem2.Name = "option2ToolStripMenuItem2";
            this.option2ToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.option2ToolStripMenuItem2.Text = "option2";
            // 
            // option2sub1ToolStripMenuItem
            // 
            this.option2sub1ToolStripMenuItem.Name = "option2sub1ToolStripMenuItem";
            this.option2sub1ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.option2sub1ToolStripMenuItem.Text = "option2-sub1";
            // 
            // option1ToolStripMenuItem1
            // 
            this.option1ToolStripMenuItem1.Name = "option1ToolStripMenuItem1";
            this.option1ToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.option1ToolStripMenuItem1.Text = "option1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option2ToolStripMenuItem1,
            this.option1ToolStripMenuItem2});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // option2ToolStripMenuItem1
            // 
            this.option2ToolStripMenuItem1.Name = "option2ToolStripMenuItem1";
            this.option2ToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.option2ToolStripMenuItem1.Text = "option2";
            // 
            // option1ToolStripMenuItem2
            // 
            this.option1ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1sub1ToolStripMenuItem});
            this.option1ToolStripMenuItem2.Name = "option1ToolStripMenuItem2";
            this.option1ToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.option1ToolStripMenuItem2.Text = "option1";
            // 
            // option1sub1ToolStripMenuItem
            // 
            this.option1sub1ToolStripMenuItem.Name = "option1sub1ToolStripMenuItem";
            this.option1sub1ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.option1sub1ToolStripMenuItem.Text = "option1-sub1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 20);
            // 
            // timerMemory
            // 
            this.timerMemory.Interval = 2500;
            this.timerMemory.Tick += new System.EventHandler(this.timerMemory_Tick);
            // 
            // deleteServiceContextMenu
            // 
            this.deleteServiceContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deleteServiceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.deleteServiceContextMenu.Name = "tvServicesContextMenu";
            this.deleteServiceContextMenu.Size = new System.Drawing.Size(129, 30);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.deleteToolStripMenuItem.Image = global::AServiceController.Properties.Resources.Cancel_32x;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteServiceContextMenu_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbServiceDetails);
            this.splitContainer2.Panel1.Controls.Add(this.tvMain);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3, 3, 2, 1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.Controls.Add(this.tsServices);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 1, 2, 1);
            this.splitContainer2.Size = new System.Drawing.Size(1202, 639);
            this.splitContainer2.SplitterDistance = 353;
            this.splitContainer2.TabIndex = 2;
            // 
            // gbServiceDetails
            // 
            this.gbServiceDetails.BackColor = System.Drawing.Color.DimGray;
            this.gbServiceDetails.Controls.Add(this.txtDescription);
            this.gbServiceDetails.Controls.Add(this.chkCanPauseContinue);
            this.gbServiceDetails.Controls.Add(this.chkCanShutDown);
            this.gbServiceDetails.Controls.Add(this.chkCanStop);
            this.gbServiceDetails.Controls.Add(this.lblServiceStartType);
            this.gbServiceDetails.Controls.Add(this.lblServiceType);
            this.gbServiceDetails.Controls.Add(this.lblServiceStatus);
            this.gbServiceDetails.Controls.Add(this.lblDisplayName);
            this.gbServiceDetails.Controls.Add(this.lblServiceName);
            this.gbServiceDetails.Controls.Add(this.label6);
            this.gbServiceDetails.Controls.Add(this.label5);
            this.gbServiceDetails.Controls.Add(this.label4);
            this.gbServiceDetails.Controls.Add(this.label3);
            this.gbServiceDetails.Controls.Add(this.label1);
            this.gbServiceDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbServiceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServiceDetails.Location = new System.Drawing.Point(3, 261);
            this.gbServiceDetails.Name = "gbServiceDetails";
            this.gbServiceDetails.Size = new System.Drawing.Size(348, 377);
            this.gbServiceDetails.TabIndex = 6;
            this.gbServiceDetails.TabStop = false;
            this.gbServiceDetails.Text = "Service Details";
            this.gbServiceDetails.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.DimGray;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Location = new System.Drawing.Point(3, 161);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(342, 213);
            this.txtDescription.TabIndex = 15;
            // 
            // chkCanPauseContinue
            // 
            this.chkCanPauseContinue.AutoSize = true;
            this.chkCanPauseContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanPauseContinue.Location = new System.Drawing.Point(179, 133);
            this.chkCanPauseContinue.Name = "chkCanPauseContinue";
            this.chkCanPauseContinue.Size = new System.Drawing.Size(135, 22);
            this.chkCanPauseContinue.TabIndex = 14;
            this.chkCanPauseContinue.Text = "Pause/Continue";
            this.chkCanPauseContinue.UseVisualStyleBackColor = true;
            // 
            // chkCanShutDown
            // 
            this.chkCanShutDown.AutoSize = true;
            this.chkCanShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanShutDown.Location = new System.Drawing.Point(77, 133);
            this.chkCanShutDown.Name = "chkCanShutDown";
            this.chkCanShutDown.Size = new System.Drawing.Size(96, 22);
            this.chkCanShutDown.TabIndex = 13;
            this.chkCanShutDown.Text = "Shutdown";
            this.chkCanShutDown.UseVisualStyleBackColor = true;
            // 
            // chkCanStop
            // 
            this.chkCanStop.AutoSize = true;
            this.chkCanStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanStop.Location = new System.Drawing.Point(10, 133);
            this.chkCanStop.Name = "chkCanStop";
            this.chkCanStop.Size = new System.Drawing.Size(61, 22);
            this.chkCanStop.TabIndex = 12;
            this.chkCanStop.Text = "Stop";
            this.chkCanStop.UseVisualStyleBackColor = true;
            // 
            // lblServiceStartType
            // 
            this.lblServiceStartType.AutoSize = true;
            this.lblServiceStartType.BackColor = System.Drawing.Color.DimGray;
            this.lblServiceStartType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServiceStartType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceStartType.Location = new System.Drawing.Point(113, 107);
            this.lblServiceStartType.Name = "lblServiceStartType";
            this.lblServiceStartType.Size = new System.Drawing.Size(93, 20);
            this.lblServiceStartType.TabIndex = 11;
            this.lblServiceStartType.Text = "Startup Type";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.DimGray;
            this.lblServiceType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(113, 67);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(95, 20);
            this.lblServiceType.TabIndex = 10;
            this.lblServiceType.Text = "Service Type";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.BackColor = System.Drawing.Color.DimGray;
            this.lblServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceStatus.Location = new System.Drawing.Point(113, 87);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(105, 20);
            this.lblServiceStatus.TabIndex = 9;
            this.lblServiceStatus.Text = "Service Status";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.DimGray;
            this.lblDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(112, 44);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(98, 20);
            this.lblDisplayName.TabIndex = 8;
            this.lblDisplayName.Text = "DisplayName";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.BackColor = System.Drawing.Color.DimGray;
            this.lblServiceName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(113, 24);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(47, 20);
            this.lblServiceName.TabIndex = 6;
            this.lblServiceName.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Service Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Startup Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Display Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Name";
            // 
            // tvMain
            // 
            this.tvMain.AllowDrop = true;
            this.tvMain.BackColor = System.Drawing.Color.DimGray;
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMain.ForeColor = System.Drawing.Color.White;
            this.tvMain.FullRowSelect = true;
            this.tvMain.HideSelection = false;
            this.tvMain.ImageIndex = 0;
            this.tvMain.ImageList = this.ilServices;
            this.tvMain.Location = new System.Drawing.Point(3, 3);
            this.tvMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tvMain.Name = "tvMain";
            treeNode1.ImageKey = "ProcessServices.ico";
            treeNode1.Name = "nodeServicesWin32Own";
            treeNode1.SelectedImageKey = "ProcessServices.ico";
            treeNode1.Tag = "Win32OwnProcess";
            treeNode1.Text = "Win 32 Own Process";
            treeNode1.ToolTipText = "A Win32 program that can be started by the Service Controller and that obeys the " +
    "service control protocol. This type of Win32 service runs in a process by itself" +
    ".";
            treeNode2.ImageKey = "ProcessServices.ico";
            treeNode2.Name = "nodeServicesWin32Share";
            treeNode2.SelectedImageKey = "ProcessServices.ico";
            treeNode2.Tag = "Win32ShareProcess";
            treeNode2.Text = "Win 32 Share Process";
            treeNode2.ToolTipText = "A Win32 service that can share a process with other Win32 services.";
            treeNode3.ImageKey = "ProcessServices.ico";
            treeNode3.Name = "nodeServicesAll";
            treeNode3.SelectedImageKey = "ProcessServices.ico";
            treeNode3.Text = "Process Services";
            treeNode4.ImageKey = "Driver.ico";
            treeNode4.Name = "nodeDriversAdapter";
            treeNode4.SelectedImageKey = "Driver.ico";
            treeNode4.Tag = "Adapter";
            treeNode4.Text = "Adapter";
            treeNode4.ToolTipText = "A service for a hardware device that requires its own driver.";
            treeNode5.ImageKey = "Driver.ico";
            treeNode5.Name = "nodeDriversFS";
            treeNode5.SelectedImageKey = "Driver.ico";
            treeNode5.Tag = "FileSystemDriver";
            treeNode5.Text = "File System";
            treeNode5.ToolTipText = "A file system driver, which is also a Kernel device driver.";
            treeNode6.ImageKey = "Driver.ico";
            treeNode6.Name = "nodeDriversInteractive";
            treeNode6.SelectedImageKey = "Driver.ico";
            treeNode6.Tag = "InteractiveProcess";
            treeNode6.Text = "Interactive";
            treeNode6.ToolTipText = "A service that can communicate with the desktop.";
            treeNode7.ImageKey = "Driver.ico";
            treeNode7.Name = "nodeDriversKernel";
            treeNode7.SelectedImageKey = "Driver.ico";
            treeNode7.Tag = "KernelDriver";
            treeNode7.Text = "Kernel";
            treeNode7.ToolTipText = "A Kernel device driver such as a hard disk or other low-level hardware device dri" +
    "ver.";
            treeNode8.ImageKey = "Driver.ico";
            treeNode8.Name = "nodeDriversRecognizer";
            treeNode8.SelectedImageKey = "Driver.ico";
            treeNode8.Tag = "RecognizerDriver";
            treeNode8.Text = "Recognizer";
            treeNode8.ToolTipText = "A file system driver used during startup to determine the file systems present on" +
    " the system.";
            treeNode9.ImageKey = "Driver.ico";
            treeNode9.Name = "nodeDevicesAll";
            treeNode9.SelectedImageKey = "Driver.ico";
            treeNode9.Text = "Device Services";
            treeNode10.ContextMenuStrip = this.tvMainContextMenu;
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "serviceGroups";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "My Service Groups";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode9,
            treeNode10});
            this.tvMain.SelectedImageIndex = 0;
            this.tvMain.Size = new System.Drawing.Size(348, 635);
            this.tvMain.TabIndex = 5;
            this.tvMain.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvMain_AfterLabelEdit);
            this.tvMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMain_NodeMouseClick);
            this.tvMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvMain_DragDrop);
            this.tvMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvMain_DragEnter);
            this.tvMain.DragOver += new System.Windows.Forms.DragEventHandler(this.tvMain_DragOver);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            
            this.splitContainer1.Panel1.Controls.Add(this.tvServices);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.consoleDebug);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripConsole);
            this.splitContainer1.Size = new System.Drawing.Size(843, 598);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvServices
            // 
            this.tvServices.AllowDrop = true;
            this.tvServices.BackColor = System.Drawing.Color.DimGray;
            this.tvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvServices.ForeColor = System.Drawing.Color.White;
            this.tvServices.ImageIndex = 0;
            this.tvServices.ImageList = this.ilServices;
            this.tvServices.Location = new System.Drawing.Point(0, 0);
            this.tvServices.Margin = new System.Windows.Forms.Padding(2);
            this.tvServices.Name = "tvServices";
            this.tvServices.SelectedImageIndex = 0;
            this.tvServices.Size = new System.Drawing.Size(843, 342);
            this.tvServices.TabIndex = 0;
            this.tvServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvServices_MouseDown);
            // 
            // consoleDebug
            // 
            this.consoleDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleDebug.IsInputEnabled = false;
            this.consoleDebug.Location = new System.Drawing.Point(0, 31);
            this.consoleDebug.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.consoleDebug.Name = "consoleDebug";
            this.consoleDebug.SendKeyboardCommandsToProcess = false;
            this.consoleDebug.ShowDiagnostics = false;
            this.consoleDebug.Size = new System.Drawing.Size(843, 222);
            this.consoleDebug.TabIndex = 1;
            // 
            // toolStripConsole
            // 
            this.toolStripConsole.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripConsole.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripConsole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripConsole.Location = new System.Drawing.Point(0, 0);
            this.toolStripConsole.Name = "toolStripConsole";
            this.toolStripConsole.Size = new System.Drawing.Size(843, 31);
            this.toolStripConsole.TabIndex = 0;
            this.toolStripConsole.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Black;
            this.toolStripLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.SteelBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel1.Text = ">\\";
            // 
            // tsServices
            // 
            this.tsServices.BackColor = System.Drawing.Color.SteelBlue;
            this.tsServices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStart,
            this.tsbStop,
            this.tsbAbout,
            this.tsddbOptions,
            this.toolStripSeparator1,
            this.tsbDetails,
            this.tsbDebugConsole});
            this.tsServices.Location = new System.Drawing.Point(0, 1);
            this.tsServices.Name = "tsServices";
            this.tsServices.Size = new System.Drawing.Size(843, 39);
            this.tsServices.TabIndex = 0;
            // 
            // tsbStart
            // 
            this.tsbStart.AutoSize = false;
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStart.Image = global::AServiceController.Properties.Resources.Start;
            this.tsbStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(36, 36);
            this.tsbStart.Text = "toolStripButton1";
            this.tsbStart.ToolTipText = "Start Service(s)";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = global::AServiceController.Properties.Resources.Stop_32x;
            this.tsbStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(36, 36);
            this.tsbStop.Text = "toolStripButton2";
            this.tsbStop.ToolTipText = "Stop Service(s)";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbAbout
            // 
            this.tsbAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAbout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Margin = new System.Windows.Forms.Padding(10, 1, 20, 2);
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(73, 36);
            this.tsbAbout.Text = "About...";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // tsddbOptions
            // 
            this.tsddbOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsddbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeStart,
            this.showRunningServicesOnly,
            this.enableProcessMonitoring});
            this.tsddbOptions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsddbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsddbOptions.Image")));
            this.tsddbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbOptions.Margin = new System.Windows.Forms.Padding(6, 1, 6, 2);
            this.tsddbOptions.Name = "tsddbOptions";
            this.tsddbOptions.Size = new System.Drawing.Size(34, 36);
            this.tsddbOptions.Text = "Options";
            // 
            // cascadeStart
            // 
            this.cascadeStart.BackColor = System.Drawing.Color.SteelBlue;
            this.cascadeStart.CheckOnClick = true;
            this.cascadeStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cascadeStart.Name = "cascadeStart";
            this.cascadeStart.Size = new System.Drawing.Size(344, 28);
            this.cascadeStart.Text = "Cascade Start Dependent Services";
            // 
            // showRunningServicesOnly
            // 
            this.showRunningServicesOnly.BackColor = System.Drawing.Color.SteelBlue;
            this.showRunningServicesOnly.CheckOnClick = true;
            this.showRunningServicesOnly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showRunningServicesOnly.Name = "showRunningServicesOnly";
            this.showRunningServicesOnly.Size = new System.Drawing.Size(344, 28);
            this.showRunningServicesOnly.Text = "Show Running Services Only";
            this.showRunningServicesOnly.Click += new System.EventHandler(this.showRunningServicesOnly_Click);
            // 
            // enableProcessMonitoring
            // 
            this.enableProcessMonitoring.BackColor = System.Drawing.Color.SteelBlue;
            this.enableProcessMonitoring.CheckOnClick = true;
            this.enableProcessMonitoring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enableProcessMonitoring.Name = "enableProcessMonitoring";
            this.enableProcessMonitoring.Size = new System.Drawing.Size(344, 28);
            this.enableProcessMonitoring.Text = "Enable Memory Monitoring";
            this.enableProcessMonitoring.Click += new System.EventHandler(this.enableProcessMonitoring_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbDetails
            // 
            this.tsbDetails.AutoSize = false;
            this.tsbDetails.CheckOnClick = true;
            this.tsbDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDetails.Image = global::AServiceController.Properties.Resources.DetailPageItemTemplate_32x;
            this.tsbDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetails.Margin = new System.Windows.Forms.Padding(8, 1, 4, 2);
            this.tsbDetails.Name = "tsbDetails";
            this.tsbDetails.Size = new System.Drawing.Size(36, 36);
            this.tsbDetails.Tag = "false";
            this.tsbDetails.Text = "Toggle Service Details";
            this.tsbDetails.ToolTipText = "Toggle Service Details";
            this.tsbDetails.CheckedChanged += new System.EventHandler(this.tsbDetails_CheckedChanged);
            // 
            // tsbDebugConsole
            // 
            this.tsbDebugConsole.AutoSize = false;
            this.tsbDebugConsole.CheckOnClick = true;
            this.tsbDebugConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDebugConsole.Image = global::AServiceController.Properties.Resources.VSTAAbout_32x;
            this.tsbDebugConsole.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDebugConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDebugConsole.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsbDebugConsole.Name = "tsbDebugConsole";
            this.tsbDebugConsole.Size = new System.Drawing.Size(36, 36);
            this.tsbDebugConsole.Text = "toolStripButton1";
            this.tsbDebugConsole.ToolTipText = "Show/Hide Console output";
            this.tsbDebugConsole.Click += new System.EventHandler(this.tsbDebugConsole_Click);
            // 
            // deleteGroupContextMenu
            // 
            this.deleteGroupContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deleteGroupContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.deleteGroupContextMenu.Name = "tvServicesContextMenu";
            this.deleteGroupContextMenu.Size = new System.Drawing.Size(129, 30);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.HotPink;
            this.toolStripMenuItem1.Image = global::AServiceController.Properties.Resources.Cancel_32x;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.deleteGroupContextMenu_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 148);
            // 
            // frmSvcCtlr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1202, 664);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSvcCtlr";
            this.Text = "A Service Controller for Overclockers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmSvcCtlr_Paint);
            this.tvMainContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.deleteServiceContextMenu.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbServiceDetails.ResumeLayout(false);
            this.gbServiceDetails.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripConsole.ResumeLayout(false);
            this.toolStripConsole.PerformLayout();
            this.tsServices.ResumeLayout(false);
            this.tsServices.PerformLayout();
            this.deleteGroupContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip tvMainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newGroupToolStripMenuItem;
        private System.Windows.Forms.ImageList ilServices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssMessage;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem option2sub1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem option1sub1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel tsslMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslMemory;
        private System.Windows.Forms.Timer timerMemory;
        private System.Windows.Forms.ContextMenuStrip deleteServiceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.ContextMenuStrip deleteGroupContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvServices;
        private System.Windows.Forms.ToolStrip toolStripConsole;
        private System.Windows.Forms.ToolStrip tsServices;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripDropDownButton tsddbOptions;
        private System.Windows.Forms.ToolStripMenuItem cascadeStart;
        private System.Windows.Forms.ToolStripMenuItem showRunningServicesOnly;
        private System.Windows.Forms.ToolStripMenuItem enableProcessMonitoring;
        private System.Windows.Forms.ToolStripButton tsbDetails;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private ConsoleControl.ConsoleControl consoleDebug;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDebugConsole;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox gbServiceDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.CheckBox chkCanPauseContinue;
        private System.Windows.Forms.CheckBox chkCanShutDown;
        private System.Windows.Forms.CheckBox chkCanStop;
        private System.Windows.Forms.Label lblServiceStartType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

