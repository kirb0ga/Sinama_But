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
    public partial class Yeni_Musteri_Karti : Form
    {
        private Customer cs;

        public Yeni_Musteri_Karti()
        {
            InitializeComponent();
        }
        public Yeni_Musteri_Karti(Customer customer)
        {
            cs = customer;
            InitializeComponent();            
        }
        private void Yeni_Musteri_Karti_Load_1(object sender, EventArgs e)
        {
            if (cs != null)
            {
                txt_musteri.Text = cs.Ad;
                txt_adres.Text = cs.Adres;
                txt_telefon.Text = cs.Telefon;
                txt_vergiDaire.Text = cs.VergiDaire;
                txt_vergiNo.Text = cs.VergiNo;
                txt_mail.Text = cs.Email;
                txt_yetkili.Text = cs.Yetkili;
            }
        }
      

       

        //eğer cs null ise bu yeni kayıt
        //demektir ama değilse
        //bu bir güncelleme işlemidir.
        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
            bool onay = true;
            foreach (Control item in this.Controls)
            {
                if (String.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız!...");
                    onay = false;
                    break;
                }
            }

            if (onay)
            {
                Customer c = new Customer();
                if (cs != null)
                    c = cs;
                c.Ad = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txt_musteri.Text.Trim());
                c.Adres = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txt_adres.Text.Trim());
                c.Telefon = txt_telefon.Text;
                c.Email = txt_mail.Text;
                c.VergiDaire = txt_vergiDaire.Text;
                c.VergiNo = txt_vergiNo.Text;
                c.Yetkili = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txt_yetkili.Text.Trim());

                if (cs == null)
                {
                    if ((Db_Connection.baglanti().Ekle_Musteri(c)))
                    {
                        MessageBox.Show("Yeni Kayıt İşlemi başarılı...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aynı isimde müşteri veya vergi kimlik numarası bulunmaktadır. Lütfen bilgileri kontrol edip tekrar deneyiniz...");
                    }
                }
                else
                {
                    if ((Db_Connection.baglanti().Guncelle_Musteri(c)))
                    {
                        MessageBox.Show("Güncelleme İşlemi başarılı...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aynı isimde müşteri veya vergi kimlik numarası bulunmaktadır. Lütfen bilgileri kontrol edip tekrar deneyiniz...");
                    }
                }
            }

        }

       
    }
}
