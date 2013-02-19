using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.UI.Models;

namespace PointOfSale.Client.Pages
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            Load += MainPage_Load;
        }

        void MainPage_Load(object sender, EventArgs e)
        {
            itemPanel.Rows = 5;
            itemPanel.Columns = 2;

            for (var i = 0; i < 25; i++)
            {
                var locali = i;

                itemPanel.Actions.Add(new PredicateInputAction
                {
                    Name = "Item " + i,
                    Predicate = () => MessageBox.Show("You clicked item " + locali)
                });
            }
            
            categoryPanel.Rows = 8;
            categoryPanel.Columns = 1;

            for (var i = 0; i < 30; i++)
            {
                var locali = i;

                categoryPanel.Actions.Add(new PredicateInputAction
                {
                    Name = "Category " + i,
                    Predicate = () => MessageBox.Show("You clicked category " + locali)
                });
            }
        }
    }
}
