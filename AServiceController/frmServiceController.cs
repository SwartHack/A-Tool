using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Management;
using System.Security.Principal;
using System.Windows;

namespace AServiceController
{
    public partial class frmSvcCtlr : Form
    {
        private string XMLFILE { get; set; }
        private bool GroupMode { get; set; }
        private List<ServiceType> ProcessTypes { get; set; }
        private List<ServiceType> DeviceTypes { get; set; }

        public frmSvcCtlr()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////// 
        /// Form Events
        //////////////////////////////////////////////////////////////////////////////////
        #region FormEvents
        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessTypes = new List<ServiceType> { ServiceType.Win32OwnProcess, ServiceType.Win32ShareProcess, ServiceType.InteractiveProcess };
            DeviceTypes = new List<ServiceType> { ServiceType.Adapter, ServiceType.FileSystemDriver, ServiceType.KernelDriver, ServiceType.RecognizerDriver };

            tvMain.SelectedNode = tvMain.Nodes["nodeServicesAll"];
            tvMain.SelectedNode.EnsureVisible();
            tvMain.SelectedNode.ExpandAll();
            QueryServicesByClick(tvMain.SelectedNode);

            //timerMemory.Start();
            tsbStart.Enabled = false;
            tsbStop.Enabled = false;
            tsbDetails.Enabled = false;

            XMLFILE = String.Format("{0}\\groups.xml", Path.GetDirectoryName(this.GetType().Assembly.Location));

            // add any service groups 
            ReadXML();
            GroupMode = false;

            consoleDebug.IsInputEnabled = false;
            splitContainer1.Panel2Collapsed = true;
            consoleDebug.WriteInput("A Service Controller Output enabled....\r\n", Color.Yellow, true);
           
           

            toolStripConsole.Renderer = new ConsoleToolStripRenderer();
            tsServices.Renderer = new MainToolStripRenderer();
        }

        /// <summary>
        /// toolstrip renderers
        /// empty form paint override
        /// </summary> 
        private class ConsoleToolStripRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderLabelBackground(ToolStripItemRenderEventArgs e)
            {
                using (var brush = new SolidBrush(e.Item.BackColor))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                }
            }
        }
        private class MainToolStripRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            {
                using (var brush = new SolidBrush(e.Item.BackColor))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                }
            }
        }
        private void frmSvcCtlr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbStart_Click(object sender, EventArgs e)
        {
            ServiceController service = GetAllServices().Find(services => services.ServiceName == tvServices.SelectedNode.Name);
            consoleDebug.ClearOutput();
            StartService(service, cascadeStart.Checked);
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            ServiceController service = GetAllServices().Find(services => services.ServiceName == tvServices.SelectedNode.Name);
            consoleDebug.ClearOutput();
            StopService(service);
        }

        private void tsbDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (tsbDetails.Checked)
            {
                tsbDetails.BackColor = Color.AliceBlue;
                gbServiceDetails.Visible = true;
            }
            else
            {
                tsbDetails.BackColor = Color.SteelBlue;
                gbServiceDetails.Visible = false;
            }
        }

        private void tsbDebugConsole_Click(object sender, EventArgs e)
        {
            if (tsbDebugConsole.Checked)
            {
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
            }
            //consoleDebug.StartProcess("cmd", null);
            //UpdateConsoleUI();
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog(this);
        }

        private void tvMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tvMain.LabelEdit = false;
                tvServices.ContextMenuStrip = null;
                QueryServicesByClick(e.Node);
                //tslServicesStatus.Text = String.Format("{0} Services", bsServices.Count);
            }
        }

        private void newGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvMain.SelectedNode = tvMain.SelectedNode.Nodes.Add(String.Format("Group{0}", new Random().Next(1000, 9999)));
            tvMain.SelectedNode.Name = tvMain.SelectedNode.Text;
            tvMain.SelectedNode.EnsureVisible();
            tvMain.SelectedNode.Tag = new List<string>();
        }

        private void deleteServiceContextMenu_Click(object sender, EventArgs e)
        {
            RemoveServiceFromGroup();
        }

        private void deleteGroupContextMenu_Click(object sender, EventArgs e)
        {
            RemoveGroup();
        }

        private void tvMain_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!(e.CancelEdit && e.Label == String.Empty))
            {
                e.Node.Name = e.Label;
                WriteXML();
            }

        }

        private void showRunningServicesOnly_Click(object sender, EventArgs e)
        {
            if (showRunningServicesOnly.Checked)
            {
                QueryServicesByClick(tvMain.SelectedNode);
            }
        }

        private void enableProcessMonitoring_CheckedChanged(object sender, EventArgs e)
        {

            ///enableProcessMonitoring.Checked? timerMemory.Start() : timerMemory.Stop() 

            if (enableProcessMonitoring.Checked)
                timerMemory.Start();
            else
                timerMemory.Stop();

        }

        private void enableProcessMonitoring_Click(object sender, EventArgs e)
        {

        }

        private void timerMemory_Tick(object sender, EventArgs e)
        {
            tsslMemory.Text = String.Empty;
            var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new
            {
                FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
                TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString())
            }).FirstOrDefault();

            if (memoryValues != null)
            {
                double percent = Math.Round(((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100, 2);
                double total = Math.Round(memoryValues.TotalVisibleMemorySize / 1000, 0);
                double free = Math.Round(memoryValues.FreePhysicalMemory / 1000, 0);
                tsslMemory.Text = String.Format("Total Memory: {0} Kbs, Free Physical: {1} Kbs  {2}%", total, free, percent);
            }
        }

        //////////////////////////////////////////////////////////////////////////
        /// Drag and Drop Events
        ////////////////////////////////////////////////////////////////////////////
        #region DragDrop
        private void tvServices_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Point p = tvServices.PointToClient(new Point(e.X, e.Y));
                TreeNode node = tvServices.GetNodeAt(e.X, e.Y);
                tvServices.SelectedNode = node ?? null;
                if (tvServices.SelectedNode is null)   //timing
                {
                    //Debug.Print("tvServices_MouseDown No tvServices.SelectedNode.../n");
                    return;
                }

                SetSelectedService();

                // Debug.Print(String.Format("Mouse Down: {0}", ((ServiceController)tvServices.SelectedNode.Tag).DisplayName));
                tvServices.DoDragDrop(tvServices.SelectedNode, DragDropEffects.Copy);
            }

        }

        //private void tvServices_DragOver(object sender, DragEventArgs e)
        //{
        //    Point p = tvServices.PointToClient(new Point(e.X, e.Y));
        //    ctrlServiceDetails.Location = p;
        //}

        private void tvMain_DragEnter(object sender, DragEventArgs e)
        {
            //Debug.Print("Drag Enter: Data is {0}", e.Data.GetData(typeof(TreeNode)));
            if (!(e.Data.GetData(typeof(TreeNode)) == null))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void tvMain_DragOver(object sender, DragEventArgs e)
        {
            Point p = tvMain.PointToClient(new Point(e.X, e.Y));
            TreeNode node = tvMain.GetNodeAt(p.X, p.Y);

            if (!(node is null))
            {
                //Debug.Print((((node.Text == "My Service Groups")) || ((node.Parent != null) && (node.Parent.Text == "My Service Groups"))).ToString());
                if ((node.Text == "My Service Groups") || ((node.Parent != null) && node.Parent.Text == "My Service Groups"))
                {
                    if (node.PrevVisibleNode != null)
                    {
                        node.PrevVisibleNode.BackColor = Color.DimGray;
                    }
                    if (node.NextVisibleNode != null)
                    {
                        node.NextVisibleNode.BackColor = Color.DimGray;
                    }

                    node.BackColor = Color.SteelBlue;
                    DropTarget = node;
                }
                else
                    DropTarget = node;

            }
            else
                DropTarget = null;

        }

        TreeNode DropTarget { get; set; }

        private void tvMain_DragDrop(object sender, DragEventArgs e)
        {
            if (DropTarget is null)
                return;

            //need a target node under service groups
            if (e.Effect == DragDropEffects.Copy)
            {
                if (DropTarget.Text == "My Service Groups")
                {
                    if (MessageBox.Show("Do you want to create a new group with dragged contents?", "Create New Group", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        DropTarget = DropTarget.Nodes.Add(String.Format("Group{0}", new Random().Next(1000, 9999)));
                        DropTarget.Name = DropTarget.Text;
                        DropTarget.EnsureVisible();
                        tvMain.SelectedNode = DropTarget;
                        tvMain.SelectedNode.Tag = new List<string>();
                    }
                    else
                    {
                        return;
                    }
                }

                //get the info from dragged node
                TreeNode nodeService = (TreeNode)e.Data.GetData(typeof(TreeNode));
                ServiceController service = GetAllServices().Find(services => services.ServiceName == nodeService.Name);

                // TODO - conditional operators!
                if (DropTarget.Tag is null)
                {
                    DropTarget.Tag = new List<String>();
                }
                ((List<String>)DropTarget.Tag).Add(service.ServiceName);

                //load the node??? or leave it be
                LoadServiceGroup(DropTarget);
                tsslMain.Text = String.Format("Added Service: {0}, to Service Group:{1}", service.ServiceName, DropTarget.Text);
                Application.DoEvents();

                WriteXML();
            }
        }
        #endregion

        #endregion

        //////////////////////////////////////////////////////////////////////////////////// 
        /// Form Functions
        //////////////////////////////////////////////////////////////////////////////////
        #region FormFunctions
        ///<summary>
        /// Maintains a fresh list
        /// </summary>
        private List<ServiceController> GetAllServices()
        {
            List<ServiceController> allservices = ServiceController.GetServices().ToList();
            allservices.AddRange(ServiceController.GetDevices().ToList());
            return allservices.OrderBy(ServiceController => ServiceController.ServiceName).ToList();
        }
        /// <summary>
        /// Exposes click event 
        /// </summary>
        /// <param name="tnode"></param>
        private void QueryServicesByClick(TreeNode tnode)
        {
            // if (tnode.Tag == null) /// ????
            //     return;

            // this gets ALL Process Services from allservices
            if (tnode.Name == "nodeServicesAll")
            {
                GroupMode = false;
                var services = from service in GetAllServices()
                               where ProcessTypes.Contains(service.ServiceType)
                               select service;
                AddTreeViewNodes(services.ToList());
                tsslMain.Text = String.Format("{0} {1}", services.Count(), tnode.Text);
            }
            else if (tnode.Name == "nodeDevicesAll")
            {
                GroupMode = false;
                var services = from service in GetAllServices()
                               where DeviceTypes.Contains(service.ServiceType)
                               select service;
                AddTreeViewNodes(services.ToList());
                tsslMain.Text = String.Format("{0} {1}", services.Count(), tnode.Text);
            }
            else // any other
            {
                if (tnode.Text == "My Service Groups")
                {
                    tnode.Expand();
                    AddTreeViewNodes(new List<ServiceController>());
                    tsslMain.Text = String.Empty;
                }
                else if (tnode.Parent != null && tnode.Parent.Text == "My Service Groups")
                {
                    LoadServiceGroup(tnode);
                    GroupMode = true;
                }
                else
                {
                    GroupMode = false;
                    var services = from type in GetAllServices()
                                   where type.ServiceType == (ServiceType)(Enum.Parse(typeof(ServiceType), tnode.Tag.ToString()))
                                   select type;
                    AddTreeViewNodes(services.ToList());
                    tsslMain.Text = String.Format("{0} {1}", services.Count(), tnode.Text);
                }
            }
        }

        /// <summary>
        /// populates the services tree view from main tree view selection
        /// </summary>
        private void AddTreeViewNodes(List<ServiceController> selectedServices)
        {
            tvServices.Nodes.Clear();
            
            if (showRunningServicesOnly.Checked)
            {
                selectedServices = (List<ServiceController>) selectedServices.Where(service => service.Status == ServiceControllerStatus.Running).ToList();
            }
            foreach (ServiceController service in selectedServices)
            {
                TreeNode node = tvServices.Nodes.Add(service.ServiceName, service.DisplayName);
                SetNodeInfo(node, service);
                AddDependentServices(node, service.DependentServices);
            }
            SetToolStrip();
        }

        /// <summary>
        /// Manages the selected nodes in the main tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="service"></param>
        private void SetNodeInfo(TreeNode node, ServiceController service)
        {
            service.Refresh();
            switch (service.ServiceType)
            {
                case ServiceType.Adapter:
                case ServiceType.FileSystemDriver:
                case ServiceType.InteractiveProcess:
                case ServiceType.KernelDriver:
                case ServiceType.RecognizerDriver:
                    node.ImageKey = service.Status.Equals(ServiceControllerStatus.Running) ? "DriverRunning32.png" : "DriverStopped32.png";
                    node.SelectedImageKey = service.Status.Equals(ServiceControllerStatus.Running) ? "DriverRunning32.png" : "DriverStopped32.png";

                    break;
                case ServiceType.Win32OwnProcess:
                case ServiceType.Win32ShareProcess:
                    node.ImageKey = service.Status.Equals(ServiceControllerStatus.Running) ? "ServiceRunning.png" : "ServiceStop.png";
                    node.SelectedImageKey = service.Status.Equals(ServiceControllerStatus.Running) ? "ServiceRunning.png" : "ServiceStop.png";
                    break;
                default:
                    break;
            }

            if (GroupMode && node.Parent is null)
            {
                node.ContextMenuStrip = deleteServiceContextMenu; //allows delete of root node only
            }
        }

        /// <summary>
        /// recursive call to go down the service dependency chain, creating the corresponding TreeView layout
        /// this needs to be made smarter
        /// NO service object parts in treeview please! Always get freshy from SelectedServices...
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="services"></param>
        private void AddDependentServices(TreeNode parent, ServiceController[] services)
        {
            foreach (ServiceController service in services)
            {
                TreeNode node = parent.Nodes.Add(service.ServiceName, service.DisplayName); // no objects in node!!!
                SetNodeInfo(node, service);
                AddDependentServices(node, service.DependentServices);
            }
        }

        /// <summary>
        /// Manages selected Node in Services TreeView
        /// </summary>
        /// <param name="node"></param>
        private void SetSelectedService()
        {
            ServiceController service = GetAllServices().Find(services => services.ServiceName == tvServices.SelectedNode.Name);
            service.Refresh();
            tsslMain.Text = String.Format("Selected Service: {0}, {1} dependents.", service.DisplayName, service.DependentServices.Count());
            SetToolStrip();
            SetDetail(service);
        }

        /// <summary>
        /// update the details panel
        /// </summary>
        /// <param name="service"></param>
        private void SetDetail(ServiceController service)
        {
            lblServiceName.Text = service.ServiceName;
            //lblMachineName.Text = service.MachineName;
            lblDisplayName.Text = service.DisplayName;
            lblServiceStatus.Text = service.Status.ToString();
            lblServiceType.Text = service.ServiceType.ToString();
            lblServiceStartType.Text = service.StartType.ToString();

            chkCanStop.Checked = service.CanStop;
            chkCanShutDown.Checked = service.CanShutdown;
            chkCanPauseContinue.Checked = service.CanShutdown;

            try
            {
                using (ManagementObject mobject = new ManagementObject(new ManagementPath(string.Format("Win32_Service.Name='{0}'", service.ServiceName))))
                {
                    txtDescription.Text = mobject["Description"].ToString();
                }
            }
            catch (Exception)
            {
                txtDescription.Text = String.Format("Not immplemented for Service Type: {0}", service.ServiceType.ToString());
            }
           

        }

        /// <summary>
        /// Updates the main toolstrip
        /// </summary>
        private void SetToolStrip()
        {
            //tsslMain.Text = String.Empty;
            Cursor.Current = Cursors.Default;

            // tool-bar fun
            if (tvServices.SelectedNode == null)
            {
                //tsslMain.Text = "No tvServices.SelectedNode";
                tsbDetails.Enabled = false;
                Application.DoEvents();
                return;
            }

            ServiceController service = GetAllServices().Find(services => services.ServiceName == tvServices.SelectedNode.Name);
            service.Refresh();
            tsbDetails.Enabled = true;
            switch (service.Status)
            {
                case ServiceControllerStatus.Running:
                    tsbStart.Enabled = false;
                    tsbStop.Enabled = true;
                    break;
                case ServiceControllerStatus.Stopped:
                    tsbStart.Enabled = true;
                    tsbStop.Enabled = false;
                    break;
                case ServiceControllerStatus.Paused:
                    break;
                case ServiceControllerStatus.StartPending:
                    break;
                case ServiceControllerStatus.ContinuePending:
                    break;
                case ServiceControllerStatus.PausePending:
                    break;
                case ServiceControllerStatus.StopPending:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Starts a service
        /// auto start parents
        /// cascade start children option
        /// </summary>
        private void StartService(ServiceController service, bool cascadestart)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            try
            {
                if (tvServices.SelectedNode != null)
                {
                    //ServiceController service = GetAllServices().Find(services => services.ServiceName == tvServices.SelectedNode.Name);
                    service.Refresh();
                    List<TreeNode> nodes;
                   
                    WriteConsole(String.Format("Veryfying service dependencies...", service.DisplayName), ConsoleTextColor.Normal);
                    Application.DoEvents();

                    ////////////////////////////////////////////////////////////////////////////////
                    // are there any services this service depends on, they must be started as well
                    // don't recursive call parents ????
                    ////////////////////////////////////////////////////////////////////////////////
                    service.Refresh();
                    if (service.ServicesDependedOn.Count() > 0)
                    {
                        WriteConsole(String.Format("Processing service {0} parents...", service.ServiceName), ConsoleTextColor.Normal);
                        // how are these ordered???
                        foreach (ServiceController parentservice in service.ServicesDependedOn)
                        {
                            // now get service from SelectedService, this parent could be anywhere, anytype!!!??
                            //ServiceController parentservice = GetAllServices().Find(services => services.ServiceName == parentservicename);
                            Application.DoEvents();
                            parentservice.Refresh();

                            try
                            {
                                if (!parentservice.Status.Equals(ServiceControllerStatus.Running))
                                {
                                    WriteConsole(String.Format("Parent service:{0} not running....", parentservice.ServiceName), ConsoleTextColor.Notify);
                                    StartService(parentservice, false);

                                }
                                else
                                {
                                    WriteConsole(String.Format("Parent service:{0} running....", parentservice.ServiceName), ConsoleTextColor.Notify);

                                }
                            }
                            catch (Exception ex)
                            {
                                WriteConsole(String.Format("Exception processing service:{0} process(s)/n {1}", service.ServiceName, ex.Message), ConsoleTextColor.Exception);
                            }
                        }
                    }

                    service.Refresh();
                    
                    WriteConsole(String.Format("Processing service: {0}...", service.DisplayName),ConsoleTextColor.Normal);
                    try
                    {
                        if (!service.Status.Equals(ServiceControllerStatus.Running))
                        {
                            WriteConsole(String.Format("Executing Start request..", service.ServiceName), ConsoleTextColor.Normal);
                            SetServiceStartUp(service.ServiceName, service.ServiceType, "Automatic");
                            service.Refresh();
                            service.Start();
                            service.WaitForStatus(ServiceControllerStatus.Running);
                            service.Refresh();
                            WriteConsole(String.Format("Service {0} started!", service.ServiceName), ConsoleTextColor.Normal);
                        }
                        else
                        {
                            WriteConsole(String.Format("Service:{0}, already running!!! start request terminated...", service.ServiceName), ConsoleTextColor.Notify);
                        }

                        //update my status everywhere in tree
                        nodes = tvServices.Nodes.Find(service.ServiceName, true).ToList<TreeNode>();
                       
                        WriteConsole(String.Format("Started service: {0}...", service.DisplayName), ConsoleTextColor.Normal);
                        Application.DoEvents();

                        foreach (TreeNode node in nodes)
                        {
                            SetNodeInfo(node, service);
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteConsole(String.Format("Exception processing service:{0} process(s)/n {1}", service.ServiceName, ex.Message), ConsoleTextColor.Exception);
                    }

                    // start dependents if option selected, otherwise just start the service
                    if (service.DependentServices.Count() > 0 && cascadestart) 
                    {
                        WriteConsole(String.Format("Cascade processing service:{0} children...", service.ServiceName), ConsoleTextColor.Normal);
                        //how are these ordered, need to start from lowest in tree, let linq deal with it?
                        foreach (ServiceController childservice in service.DependentServices)
                        {
                            Application.DoEvents();
                            childservice.Refresh();
                            StartService(childservice,true);
                        }
                    }
                }

                SetToolStrip();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                WriteConsole(String.Format("Exception processing service:{0} process(s)/n {1}", service.ServiceName, ex.Message), ConsoleTextColor.Exception);
            }
        }

        /// <summary>
        /// Tries to shut down entire shared proccess. 
        /// This is iffy at best and can have many undesired consequences!!!
        /// TODO - Needs option and warning 
        /// </summary>
        /// <param name="servicename"></param>
        /// <param name="type"></param>
        /// <param name="state"></param>
        private void SetServiceStartUp(string servicename, ServiceType type, string state)
        {
            if (type != ServiceType.Win32OwnProcess)
            {
                WriteConsole(String.Format("Service: {0}, Share Host Process!!!! , setting startup: {1}", servicename, state), ConsoleTextColor.Notify);
                try
                {
                    string path = "Win32_Service.Name='" + servicename + "'";
                    ManagementPath p = new ManagementPath(path);
                    //construct the management object
                    ManagementObject ManagementObj = new ManagementObject(p);
                    //we will use the invokeMethod method of the ManagementObject class
                    object[] parameters = new object[1];
                    parameters[0] = state;
                    ManagementObj.InvokeMethod("ChangeStartMode", parameters);
                }
                catch (Exception ex)
                {
                    WriteConsole(String.Format("Exception!!! Message: {0} \n Inner Exception: {1}", ex.Message, ex.InnerException.ToString()), ConsoleTextColor.Exception);
                }
            }


        }

        /// <summary>
        /// Stops a Service and all dependents as default
        /// Recursive call children should check first as windows10 service manager now cascade starts and stops.
        /// TODO - work into the autostop and SetServiceStartup call
        /// </summary>
        private void StopService(ServiceController service)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            try
            {
                if (tvServices.SelectedNode != null)
                {
                    List<TreeNode> nodes;
                   
                    WriteConsole(String.Format("Stopping service: {0}, and dependencies...", service.ServiceName), ConsoleTextColor.Normal);
                    Application.DoEvents();

                    // recursive call for child services
                    if (service.DependentServices.Count() > 0)
                    {
                        foreach (ServiceController child in service.DependentServices)
                        {
                            StopService(child);
                        }
                    }

                    service.Refresh();
                    WriteConsole(String.Format("Processing service: {0}...", service.DisplayName), ConsoleTextColor.Normal);
                    try
                    {
                        if (service.Status.Equals(ServiceControllerStatus.Running))
                        {
                            WriteConsole(String.Format("Stop service: {0}, request terminate end procssess(s)...", service.ServiceName), ConsoleTextColor.Normal);
                            if (StopServiceAndWaitForExit(service) != true) //we couldn't wait for proc, so try to shut it down
                            {
                                WriteConsole(String.Format("Executing direct {0} stop request..", service.ServiceName), ConsoleTextColor.Normal);
                                SetServiceStartUp(service.ServiceName, service.ServiceType, "Disabled");
                                service.Refresh();
                                service.Stop();
                                service.WaitForStatus(ServiceControllerStatus.Stopped);
                                service.Refresh();
                                WriteConsole(String.Format("Service {0} stopped!", service.ServiceName), ConsoleTextColor.Normal);

                            }
                            else
                            {
                                WriteConsole(String.Format("Service:{0}, not running!!! stop request terminated...", service.ServiceName), ConsoleTextColor.Notify);
                            }

                            //update my status everywhere in tree
                            nodes = tvServices.Nodes.Find(service.ServiceName, true).ToList<TreeNode>();
                            
                            WriteConsole(String.Format("Stopped service: {0}...", service.DisplayName), ConsoleTextColor.Normal);
                            Application.DoEvents();

                            foreach (TreeNode node in nodes)
                            {
                                SetNodeInfo(node, service);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteConsole(String.Format("Exception processing service:{0} process(s)/n {1}", service.ServiceName, ex.Message), ConsoleTextColor.Exception);
                    }
                }

                SetToolStrip();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                WriteConsole(String.Format("Exception!!! Message: {0} \n Inner Exception: {1}", ex.Message, ex.InnerException.ToString()), ConsoleTextColor.Exception);
            }
        }
      
        /// <summary>
        /// Loads a service group from tvmain selection
        /// </summary>
        /// <param name="nodeGroup"></param>
        private void LoadServiceGroup(TreeNode nodeGroup)
        {
            List<ServiceController> services = new List<ServiceController>();

            try
            {
                //get list of service names from node
                List<string> servicenames = (List<string>)nodeGroup.Tag;

                if (servicenames.Count() > 0)
                {
                    //build a ServiceController[] list
                    foreach (string servicename in servicenames)
                    {
                        var service = from name in GetAllServices()
                                      where name.ServiceName == servicename
                                      select name;

                        services.Add((ServiceController)service.First());
                    }
                }

                AddTreeViewNodes(services);
                tsslMain.Text = String.Format("{0} {1} Group", services.Count(), nodeGroup.Text);
                tvMain.LabelEdit = true;
                tvServices.ContextMenuStrip = deleteServiceContextMenu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// removes a service from the group
        /// </summary>
        private void RemoveServiceFromGroup()
        {
            if (tvServices.SelectedNode != null)
            {
                ((List<string>)tvMain.SelectedNode.Tag).Remove(tvServices.SelectedNode.Name);
                tvServices.Nodes.Remove(tvServices.SelectedNode);
                tvServices.SelectedNode = null;
                WriteXML();
            }
        }

        /// <summary>
        /// removes the selected group
        /// </summary>
        private void RemoveGroup()
        {
            if (tvMain.SelectedNode != null)
            {
                tvMain.Nodes.Find("serviceGroups", false).First().Nodes.Remove(tvMain.SelectedNode);
                tvMain.SelectedNode = tvMain.Nodes.Find("serviceGroups", false).First();
                AddTreeViewNodes(new List<ServiceController>());
                WriteXML();
            }
        }
        
        /// <summary>
        /// am I running as administrator
        /// </summary>
        /// <returns></returns>
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                    .IsInRole(WindowsBuiltInRole.Administrator);
        }

        /// <summary>
        /// Here I am using ??? . Although not to its full potential, or even close.
        /// After some investigation I realized I could hook it into the application process
        /// But it ended up being easier just to use as an output window, for now
        /// TODO - hook console itno app proc.
        /// </summary>
        private enum ConsoleTextColor { Normal, Notify, Exception }
        private const string prompt = ">\\ ";
        /// <summary>
        /// Write messages to the console
        /// </summary>
        /// <param name="message"></param>
        /// <param name="textcolor"></param>
        private void WriteConsole(string message, ConsoleTextColor textcolor)
        {
            Color color;
            switch (textcolor)
            {
                case ConsoleTextColor.Normal:
                    color = Color.White;
                    break;
                case ConsoleTextColor.Notify:
                    color = Color.Yellow;
                    break;
                case ConsoleTextColor.Exception:
                    color = Color.Red;
                    break;
                default:
                    color = Color.Pink;
                    break;
            }

            consoleDebug.WriteInput(String.Format(" >\\  ", message), Color.White, true);
            consoleDebug.WriteInput(String.Format("{0}\r\n",message), color, true);
        }

        /// <summary>
        /// Read the serialized xml file of group definitions
        /// </summary>
        private void ReadXML()
        {
            SerializableDictionary<string, List<string>> groups = new SerializableDictionary<string, List<string>>();
            TreeNode rootGroup = tvMain.Nodes.Find("serviceGroups", false).First();

            try
            {
                if (File.Exists(XMLFILE))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(SerializableDictionary<string,List<string>>));
                    FileStream fs = File.OpenRead(XMLFILE);

                    groups = (SerializableDictionary<string,List<string>>)reader.Deserialize(fs);
                    fs.Close();

                    // now load up the group nodes with contents of dictionary, key=groupname, value=list of services
                    foreach (KeyValuePair<string,List<string>> group in groups)
                    {
                        TreeNode newgroup = rootGroup.Nodes.Add(group.Key);
                        newgroup.Tag = group.Value;
                        newgroup.ContextMenuStrip = deleteGroupContextMenu;
                        //LoadServiceGroup(newgroup);
                    }
                }
            }
            catch (Exception ex) ///TODO
            {
                throw ex;
            }
        }

        /// <summary>
        /// serializes the group definitions to an xml file.
        /// </summary>
        private void WriteXML()
        {
            SerializableDictionary<string, List<string>> dict = new SerializableDictionary<string, List<string>>();

            foreach (TreeNode node in tvMain.Nodes.Find("serviceGroups",false).First().Nodes)
            {
                dict.Add(node.Name, (List<string>)node.Tag);    
            }

            XmlSerializer writer = new XmlSerializer(typeof(SerializableDictionary<string, List<string>>));
            TextWriter tw = new StreamWriter(XMLFILE);
            writer.Serialize(tw, dict);
            tw.Close();

            //XmlWriter writeXML = XmlWriter.Create(file);
            //writeXML.WriteStartDocument(false);
            //writeXML.WriteComment("This is a comment");

            //writeXML.WriteStartElement("GROUPS");

            //writeXML.Flush();
            //writeXML.Close();
        }

        #endregion

        /// <summary>
        /// A pop-up draggable service details panel
        /// </summary>
        //private void ServiceDetails()
        //{
        //    ServiceController service = GetAllServices().Find(services => services.ServiceName == tvServices.SelectedNode.Name);
        //    service.Refresh();
        //    ctrlServiceDetails.SetDetails(service);
        //    ctrlServiceDetails.Visible = true;
        //Panel panel = new Panel();
        //ctrlServiceDetails details = new ctrlServiceDetails();
        //details.SetDetails(service);
        //details.Location = new System.Drawing.Point(61, 17);
        //details.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //details.Name = "ctrlServiceDetails1";
        //details.Size = new System.Drawing.Size(585, 313);
        //details.TabIndex = 1;
        //details.Visible = true;
        //this.splitContainer1.Panel1.Controls.Add(details);
        //details.Show();
        //}

        /// <summary>
        /// depricated process to manually stop child services
        /// </summary>
        //private void StopChildServices(ServiceController service)
        //{
        //if (ProcessedChildren.Where(item => item.Contains(service.ServiceName)).Count() > 0)
        //{
        //    Debug.Print(String.Format("Service: {0} already processed..", service.ServiceName));
        //    return;
        //}

        //Debug.Print(String.Format("Processing children.../n service: {0} and {1} dependent children...", service.ServiceName, service.DependentServices.Count()));

        //List<TreeNode> nodes;
        ////foreach (string childservicename in service.DependentServices.Select(item => item.ServiceName).ToList())
        //foreach (ServiceController childservice in service.DependentServices)
        //{
        //    //ProcessedChildren.Add(childservice.ServiceName);
        //    //ServiceController childservice = GetAllServices().Find(services => services.ServiceName == childservicename);
        //    if (childservice.DependentServices.Count() > 0)
        //    {
        //        StopChildServices(childservice);  //recursive
        //    }

        //    childservice.Refresh();
        //    try
        //    {
        //        if (childservice.Status.Equals(ServiceControllerStatus.Running))
        //        {
        //            Debug.Print("[pc] Stop service: {0} terminate end procssess request...", childservice.ServiceName);

        //            if (StopServiceAndWaitForExit(childservice) != true) //we couldn't wait for proc, so try to shut it down
        //            {
        //                Debug.Print("[pc]Executing {0} stop request..", childservice.ServiceName);

        //                childservice.Refresh();
        //                childservice.Stop();
        //                childservice.WaitForStatus(ServiceControllerStatus.Stopped);
        //                childservice.Refresh();

        //                Debug.Print("Service {0} stopped!", childservice.ServiceName);
        //            }
        //            else
        //            {
        //                Debug.Print("[pc]Service:{0} service not running!!! stop request terminated...", childservice.ServiceName);
        //            }


        //            //find all occurences of nodes with this service...
        //            nodes = tvServices.Nodes.Find(childservice.ServiceName, true).ToList<TreeNode>();
        //            tsslMain.Text = String.Format("[pc]Stopped service: {0}...", childservice.DisplayName);
        //            Application.DoEvents();

        //            foreach (TreeNode node in nodes)
        //            {
        //                SetNodeInfo(node, childservice);
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Print("Exception processing service:{0} process(s)/n {1}", childservice.ServiceName, ex.Message);
        //        return;
        //    }
        //}
        //}

    }
}
