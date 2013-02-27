using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace PointOfSale.Start
{
    public partial class StartScreen : Form
    {
        //Process for a POSCLIENT
        private Process clientProcess = new Process();

        public StartScreen()
        {
            InitializeComponent();
        }


        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startPOSButton_Click(object sender, EventArgs e)
        {
            Process[] myProcesses = Process.GetProcessesByName
                                            ("PointOfSale.Client.exe");
            if (myProcesses.Length == 0)
            {
                clientProcess.StartInfo.FileName = "PointOfSale.Client.exe";
                clientProcess.EnableRaisingEvents = true;
                clientProcess.Exited += new EventHandler(clientProcess_Exited);
                clientProcess.StartInfo.UseShellExecute = false;
                clientProcess.StartInfo.RedirectStandardError = true;
                startPOSButton.Enabled = false;
                clientProcess.Start();
            }
        }

        private void clientProcess_Exited(object sender, System.EventArgs e)
        {
            startPOSButton.Invoke(new MethodInvoker(delegate { startPOSButton.Enabled = true; }));
            
        }

    }
}
