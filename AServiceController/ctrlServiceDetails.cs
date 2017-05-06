using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace AServiceController
{
    public partial class ctrlServiceDetails : UserControl
    {
        public ctrlServiceDetails()
        {
            InitializeComponent();
        }

        private Point MouseDownLocation;

        public void SetDetails(ServiceController service)
        {
            this.txtServiceName.Text = service.ServiceName;
            this.txtMachineName.Text = service.MachineName;
            this.txtDisplayName.Text = service.DisplayName;
            //txtDescription.Text = service.
            //txtServiceType.Text = service.ServiceType;
            // txtStartType.Text = service.StartType;
            //txtStatus.Text = service.Status;

            bool chkCanPauseContinue=  service.CanPauseAndContinue;
            bool chkCanShutDown = service.CanShutdown;
            bool chkCanStop = service.CanStop;
        }

        private void ctrlServiceDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                MouseDownLocation = e.Location;
            }
        }

        private void panelDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.SizeAll;
                Left = e.X + Left - MouseDownLocation.X;
                Top = e.Y + Top - MouseDownLocation.Y;
            }
        }

        private void panelDetails_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
