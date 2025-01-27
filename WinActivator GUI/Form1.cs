using System.Diagnostics;
using System.IO.Pipes;
using System.Net;

namespace WinActivator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProcessStartInfo processInfo = new ProcessStartInfo();

        private void Activate_Click(object sender, EventArgs e)
        {

            WebClient web = new WebClient();
            var dir = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(dir);
            if (!File.Exists(dir + "\\Activator.cmd"))
            {
                web.DownloadFile("https://github.com/Spinchies/WinJump/releases/download/Release/Activation.cmd", dir + "\\Activator.cmd");
                processInfo.FileName = dir + "\\Activator.cmd";
                processInfo.Verb = "runas"; // Run as administrator
                Process.Start(processInfo);
            }
            else if (File.Exists(dir + "\\Activator.cmd"))
            {
                processInfo.FileName = dir + "\\Activator.cmd";
                processInfo.Verb = "runas"; // Run as administrator
                Process.Start(processInfo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
