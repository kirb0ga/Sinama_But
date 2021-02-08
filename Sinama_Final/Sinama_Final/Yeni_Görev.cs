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
    public partial class Yeni_Görev : Form
    {

        private Project _projem;
        private Tasks _tasks;
        public int durum = 1;
        public Yeni_Görev(Project Projem)
        {
            _projem = Projem;
            InitializeComponent();
            kisilerim();

        }
        public Yeni_Görev(Project p, Tasks t)
        {

            _projem = p;
            _tasks = t;
            InitializeComponent();
            kisilerim();
            //gerekli yerleri doldurduk
            txt_gorevbasligi.Text = _tasks.Baslik;
            txt_Aciklama.Text = _tasks.Aciklama;
            GorevliKisi(); //asagidaki metodu cağırdık



        }
        void GorevliKisi()
        {
            int i = 0;
            foreach (Users item in _projem.User)
            {
                if (item.Id == _tasks.Gorevli)
                {
                    cmb_Gorevli_kisi.SelectedIndex = i;  //index'i Otomatik atıyoruz..
                    break;
                }
                i++;
            }
            dataGridView1.DataSource = Db_Connection.baglanti().Task_Hareketleri(_tasks.Id);  //tablomuza ekliyoruz gelen veriyi
        }
        void kisilerim()
        {
            foreach (Users u in _projem.User)
            {
                cmb_Gorevli_kisi.Items.Add(u.Ad + " " + u.Soyad + " - (" + u.KullaniciAdi + ")");

            }
        }





        private void Yeni_Görev_Load_1(object sender, EventArgs e)
        {
            txt_Projeismi.Text = _projem.ProjeIsmi;

            if (_tasks != null)
            {
                txt_tahmin.Text = Db_Connection.baglanti().Kisi_Ortalama(_tasks.Gorevli) + " dakika";

                if (durum == 3)
                {
                    txt_proje_durum.Text = "Done";
                    btn_kaydet.Enabled = false;
                    cmb_Gorevli_kisi.Enabled = false;
                    btn_kaydet.Enabled = false;
                    txt_gorevbasligi.Enabled = false;
                    txt_Aciklama.Enabled = false;

                }
                else if (durum == 2)
                {
                    txt_proje_durum.Text = "In Progress";
                }
                else
                {
                    txt_proje_durum.Text = "To Do";
                }
                txt_gecen.Text = Db_Connection.baglanti().GecenSure(_tasks.Id, durum) + " dakika";
            }
        }
       

      

        

        private void btn_kaydet_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_gorevbasligi.Text) && !String.IsNullOrEmpty(txt_Aciklama.Text) && cmb_Gorevli_kisi.SelectedIndex >= 0)
            {
                if (_tasks == null)
                {
                    Tasks ts = new Tasks();
                    ts.Baslik = System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.ToTitleCase(txt_gorevbasligi.Text);
                    ts.Aciklama = txt_Aciklama.Text.Trim();
                    ts.Gorevli = _projem.User[cmb_Gorevli_kisi.SelectedIndex].Id;

                    if (Db_Connection.baglanti().gorevEkle(ts, _projem.Id))
                    {
                        MessageBox.Show("Görev eklendi...");

                        txt_gorevbasligi.Text = null;
                        txt_Aciklama.Text = null;
                        cmb_Gorevli_kisi.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Bu başlık tekrar kullanılamaz...");
                    }
                }
                else
                {
                    _tasks.Baslik = System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.ToTitleCase(txt_gorevbasligi.Text);
                    _tasks.Aciklama = txt_Aciklama.Text.Trim();
                    _tasks.Gorevli = _projem.User[cmb_Gorevli_kisi.SelectedIndex].Id;
                    if (Db_Connection.baglanti().Duzenle_Gorev(_tasks, _projem.Id))
                    {
                        MessageBox.Show("Görev bilgileri güncellendi...");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz...");
            }

        }

        private void cmb_Gorevli_kisi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_Gorevli_kisi.SelectedIndex >= 0)
            {
                txt_tahmin.Text = Db_Connection.baglanti().Kisi_Ortalama(_projem.User[cmb_Gorevli_kisi.SelectedIndex].Id) + " dakika";
            }
        }

        
    }
}
