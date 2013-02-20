using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI.Dialogs
{
    public partial class LoginDialog : Form
    {
        private Color dialogTextColor;
        public LoginDialog()
        {
            dialogTextColor = dialogText.ForeColor;

            InitializeComponent();
        }

        public LoginDialog(string username, string message, bool isError)
        {
            dialogTextColor = dialogText.ForeColor;

            usernameField.Text = username;
            dialogText.Text = message;
            dialogText.ForeColor = isError ? Color.Red : dialogTextColor;
        }

        public void Show(string username, string message, bool isError)
        {
            usernameField.Text = username;
            dialogText.Text = message;
            dialogText.ForeColor = isError ? Color.Red : dialogTextColor;

            Show();
        }

        public void ShowDialog(string username, string message, bool isError)
        {
            usernameField.Text = username;
            dialogText.Text = message;
            dialogText.ForeColor = isError ? Color.Red : dialogTextColor;

            ShowDialog();
        }
    }
}
