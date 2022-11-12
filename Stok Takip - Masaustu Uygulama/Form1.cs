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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //değişkenler
        int sayac = 0;              //animasyon sayaç değişkeni
        int animasyonSuresi = 3;    //animasyon süresini belirten sayaç - saniye türünden
        private void Form1_Load(object sender, EventArgs e)
        {
            // Animasyon timer aktif etme
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac >= animasyonSuresi)
            {
                sayac++;
            }
            else
            {
                timer1.Enabled = false;
                userScreen uS = new userScreen();
                uS.Show();
                this.Hide();
            }
        }
    }
}
