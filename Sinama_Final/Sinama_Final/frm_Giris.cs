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
    public partial class frm_Giris : Form
    {
        public frm_Giris()
        {
            InitializeComponent();
        }


        private void btn_Giris_Click_1(object sender, EventArgs e)
        {
            //Boş veya "" değermi girilmiş kontrolünü sağlıyoruz bu önemli bizim için
            if (!String.IsNullOrEmpty(txt_Kullanici.Text.Trim()) && !String.IsNullOrEmpty(txt_Sifre.Text.Trim()))
            {
                if (Db_Connection.baglanti().Kullanici_Giris_Kontrol(txt_Kullanici.Text.Trim(), txt_Sifre.Text.Trim()))
                {

                    Kullanici_Ekrani k = new Kullanici_Ekrani();
                    k.ShowDialog(); //Kullanıcı ekranını aç
                    this.Close(); // formu kapat



                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı ismi veya parola hatası");
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakılamaz lütfen kontrol ediniz");
            }
        }

        private void btn_Kayit_Click_1(object sender, EventArgs e)
        {
            Kayıt_Ol k = new Kayıt_Ol();  //Kayıt modülünü aç
            k.ShowDialog();

        }
    }
}
