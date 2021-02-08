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
    public partial class Yeni_Projem : Form
    {
        //nesneleri yarattık
        public static bool listele = false;
        public Project projem = new Project();
        List<Customer> _customerLİst = new List<Customer>();

        public Yeni_Projem()
        {
            InitializeComponent();
            musteriGetir();
        }

        public Yeni_Projem(Project Projemi_getir)
        {
            InitializeComponent();
            projem = Projemi_getir;
            musteriGetir();
        }

        private void btn_yeniMusteri_Click_1(object sender, EventArgs e)
        {
            Yeni_Musteri_Karti yeni_musteri_karti = new Yeni_Musteri_Karti();  //yeni müşteri ekleme modül
            yeni_musteri_karti.ShowDialog();
            musteriGetir();

        }
        

        //müşterileri getiren metod
        void musteriGetir()
        {
            _customerLİst.Clear();
            cmb_musteri.Items.Clear();
            _customerLİst = Db_Connection.baglanti().getir_Musteri();
            foreach (Customer item in _customerLİst)
            {
                cmb_musteri.Items.Add(item.Ad);
            }
        }


        //bu form yüklenirken olacaklar
        private void Yeni_Projem_Load_1(object sender, EventArgs e)
        {
            musteriGetir();
            if (projem.Id > 0)
            {
                // btn_yeniMusteri.Enabled = false;
                txt_projeisim.Text = projem.ProjeIsmi;
                string musteriAdi = null;
                foreach (Customer item in _customerLİst)
                {
                    if (item.Id == projem.Musteri)
                    {
                        musteriAdi = item.Ad;
                        break;
                    }
                }
                cmb_musteri.SelectedItem = musteriAdi;
                txt_Aciklama.Text = projem.Aciklama;

                int tahminiSure = 0;
                int gecenSure = 0;
                foreach (Tasks item in projem._Task)
                {
                    tahminiSure += Db_Connection.baglanti().Kisi_Ortalama(item.Gorevli);
                    gecenSure += Db_Connection.baglanti().GecenSure(item.Id);
                }


                lbl_tahmin.Text = (tahminiSure / 60) + " saat, " + (tahminiSure % 60) + " dakika";
                lbl_gecen.Text = (gecenSure / 60) + " saat, " + (gecenSure % 60) + " dakika";
            }
        }
        

        //kaydet butonu ile kontrol ardından işlemler
        private void btn_kaydet_Click_1(object sender, EventArgs e)
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

            // kontrol true dönerse aşağıdaki adımları yapıyoruz
            if (kontrol)
            {
                projem.ProjeIsmi = txt_projeisim.Text.Trim();
                projem.Musteri = _customerLİst[cmb_musteri.SelectedIndex].Id;
                projem.Aciklama = txt_Aciklama.Text.Trim();
                if (projem.Id <= 0)
                {
                    Db_Connection.baglanti().yeniProject(projem);
                    MessageBox.Show("Proje Başarıyla Oluşturuldu.");
                }
                else
                {
                    Db_Connection.baglanti().Duzenle_Proje(projem);
                    MessageBox.Show("Proje Bilgileri Güncellendi..");
                }
                listele = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın.");
            }

        }

        
    }
}
