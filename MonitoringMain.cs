using System.Management;
using System.Threading;
using System.Windows.Forms;
using System;


namespace EzSystemStats
{
    public partial class MonitoringMain : Form
    {
        public NotifyIcon trayIcon;
        public Thread systemTelemetryWorker;

        public MonitoringMain()
        {
            trayIcon = new NotifyIcon
            {
                Icon = new Icon(this.GetType(), "monitor.ico")
            };

            InitializeComponent();

            // application starts minimized, and runs in the background.
            // suppresses the window from popping up
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            trayIcon.Visible = true;
        }

        private void OnIconMouseClick(object sender, MouseEventArgs e)
        {
            // Works for me
            trayIcon.ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}