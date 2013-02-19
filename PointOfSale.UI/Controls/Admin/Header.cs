using System;
using System.Windows.Forms;

namespace PointOfSale.UI.Controls.Admin
{
    public partial class Header : UserControl
    {
        private Timer timeTimer;

        public Header()
        {
            InitializeComponent();

            Load += HeaderLoad;
        }

        void HeaderLoad(object sender, EventArgs e)
        {
            timeTimer = new Timer { Interval = 1000 };
            timeTimer.Tick += (s, a) => TimeLabel.Text = DateTime.Now.ToString();
            timeTimer.Start();
        }
    }
}
