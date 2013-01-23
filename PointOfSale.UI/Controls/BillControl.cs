using System;
using System.Windows.Forms;

namespace PointOfSale.UI.Controls
{
    public partial class BillControl : UserControl
    {
        private Timer timeTimer;

        public BillControl()
        {
            InitializeComponent();

            Load += BillControlLoad;
        }

        void BillControlLoad(object sender, EventArgs e)
        {
            timeTimer = new Timer { Interval = 1000 };
            timeTimer.Tick += (s, a) => TimeLabel.Text = DateTime.Now.ToString();
            timeTimer.Start();
        }
    }
}
