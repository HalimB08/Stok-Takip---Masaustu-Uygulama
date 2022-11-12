using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip___Masaustu_Uygulama
{
    public partial class userScreen : Form
    {
        public userScreen()
        {
            InitializeComponent();
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_registrationScreen registerScreen = new user_registrationScreen();
            registerScreen.ShowDialog();
        }
    }
}
