using Stok_Takip___Masaustu_Uygulama.scripts;
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
    public partial class user_registrationScreen : Form
    {
        public user_registrationScreen()
        {
            InitializeComponent();
        }
        user users = new user();
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (usernameTbox.Text.Trim() == null)
            {
                messageTxt.Text = "Kullanıcı adı boş bırakılamaz!";
                return;
            }
            if (userpassword1Tbox.Text.Trim() == "" || userpassword2Tbox.Text.Trim() == "")
            {
                messageTxt.Text = "Kullanıcı şifresi boş bırakılamaz!";
                return;
            }
            if (userpassword1Tbox.Text.Trim() == userpassword2Tbox.Text.Trim())
            {
                messageTxt.Text = "Kullanıcı şifreleri eşleşmiyor!";
                return;
            }
            if (users.userRegister(usernameTbox.Text.Trim(), userpassword1Tbox.Text.Trim()) == 1)
            {
                MessageBox.Show("Kayıt Gerçekleşemedi! Hata Kodu 0");
                return;
            }
            MessageBox.Show("Kayıt Başarılı!");
            this.Close();
        }
    }
}
