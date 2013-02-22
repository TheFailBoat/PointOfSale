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
            Process.Start("PointOfSale.Client.exe");
        }
    }
}
