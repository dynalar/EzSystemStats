namespace EzSystemStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // application starts minimized, and runs in the background.
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}