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
            if (usernameTbox.Text.Trim() != "")
            {
                if (userpassword1Tbox.Text.Trim() != "" || userpassword2Tbox.Text.Trim() != "")
                {
                    if (userpassword1Tbox.Text.Trim() == userpassword2Tbox.Text.Trim())
                    {
                        if (users.userRegister(usernameTbox.Text.Trim(), userpassword1Tbox.Text.Trim()) == 0)
                        {
                            MessageBox.Show("Kayıt Başarılı!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt başarısız!");
                        }
                    }
                    else
                    {
                        messageTxt.Text = "Kullanıcı şifreleri eşleşmiyor!";
                    }
                }
                else
                {
                    messageTxt.Text = "Kullanıcı şifresi boş bırakılamaz!";
                }
            }
            else
            {
                messageTxt.Text = "Kullanıcı adı boş bırakılamaz!";
            }
        }
    }
}
