using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinama_Final
{
    public partial class Kayıt_Ol : Form
    {
        public Kayıt_Ol()
        {
            InitializeComponent();
        }

        

        //Form üzerinde dolaşıp textboxları temizlememize yarayan metod
        private void btn_temizle_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox text = (TextBox)item;
                    text.Text = "";
                }

            }
        }

        //Kayıt olacağı zaman boş textboxlar var ise
        // kayıta izin vermez eğer yoksa
        //tekrar kayıta bakar sonra kayıt yapar
        private void btn_kayit_Click_1(object sender, EventArgs e)
        {

            bool kontrol = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox text = (TextBox)item;
                    if (String.IsNullOrEmpty(text.Text))
                    {
                        kontrol = false;
                        break;
                    }
                }

            }

            if (!kontrol)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            else
            {
                if (txt_parola.Text.Trim() == txt_tekrar.Text.Trim())
                {
                    txt_ad.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txt_ad.Text);
                    txt_soyad.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txt_soyad.Text);
                    Users u = new Users();
                    u.Ad = txt_ad.Text.Trim();
                    u.Soyad = txt_soyad.Text.Trim();
                    u.KullaniciAdi = txt_kullanici.Text.Trim();
                    u.Parola = txt_parola.Text.Trim();

                    if (Db_Connection.baglanti().kayit(u))
                    {
                        MessageBox.Show("Kayıt başarılı");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("kayıt işlemi başarısız lütfen kontrol edin");
                    }

                }
                else
                {
                    MessageBox.Show("şifreler farklı");
                }

            }
        }
    }
}
