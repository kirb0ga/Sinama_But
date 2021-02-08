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
    public partial class Proje_Kisi_Ekle : Form
    {
        private Project _proje;

        List<string> _users = new List<string>();
        public Proje_Kisi_Ekle(Project p)
        {
            _proje = p;

            InitializeComponent();
        }

        //kişileri aradığımız metod
        void Kisi_Arama()  // kişi arama metodu veritabanında işlemleri yapar
        {
            list_Tumkisiler.Items.Clear();
            foreach (Users item in Db_Connection.baglanti().kisiAra(txt_kisiara.Text.Trim(), _proje.Id))
            {
                list_Tumkisiler.Items.Add(item.KullaniciAdi + " - (" + item.Ad + " " + item.Soyad + ")");
            }
        }

        //proje ismini getirmek ve diğer metodlar
        private void Proje_Kisi_Ekle_Load_1(object sender, EventArgs e)
        {

            txt_proje.Text = _proje.ProjeIsmi;
            Kisi_Arama();
            gorevli_Ekle();
        }
       
        //gorevlileri ekler combobox'a
        void gorevli_Ekle()
        {
            foreach (Users item in _proje.User)
            {
                list_gorevli.Items.Add(item.KullaniciAdi + " - (" + item.Ad + " " + item.Soyad + ")");  //Projedeki görevlileri gösterir.
            }
        }

       

      

       

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {

            if (list_gorevli.Items.Count > 0)
            {
                foreach (string item in list_gorevli.Items)
                {
                    _users.Add(item.Substring(0, item.IndexOf("-")).Trim());  // tire - işareti ile ismi alıyoruz bu önemli. -'e kadar substring
                }
                Db_Connection.baglanti().Kisi_ekle_Gorev(_users, _proje.Id);  // burada ise göreve o kişileri ekliyoruz
                MessageBox.Show("Projeye Yeni Kişiler Başarıyla dahil Edildi");
                gorevli_Ekle();
                this.Close();
            }
            else
            {
                MessageBox.Show("Projede en az 1 kişi olmalı.");   //projemize en az 1 kişi katılması zorunluuuuu
            }
        }

        private void txt_kisiara_TextChanged_1(object sender, EventArgs e)
        {
            Kisi_Arama();// Her text içerisindeki değer değiştiğinde bu metodu çağır ve kişi getir.
        }


        //drag eventi
        private void list_Tumkisiler_DragEnter_1(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        //drag eventi
        private void list_Tumkisiler_DragDrop_1(object sender, DragEventArgs e)
        {
            if (!list_Tumkisiler.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                list_Tumkisiler.Items.Add(e.Data.GetData(DataFormats.Text));
                list_gorevli.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }
        //drag eventi için
        private void list_gorevli_MouseDown_1(object sender, MouseEventArgs e)
        {

            if (list_gorevli.SelectedItem != null)
            {
                list_Tumkisiler.DoDragDrop(list_gorevli.SelectedItem.ToString(), DragDropEffects.Copy);

            }
        }
        //drag eventi için 
        private void list_Tumkisiler_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (list_Tumkisiler.SelectedItem != null)
            {
                list_gorevli.DoDragDrop(list_Tumkisiler.SelectedItem.ToString(), DragDropEffects.Copy);

            }
        }
        
        //drag eventi

        private void list_gorevli_DragDrop_1(object sender, DragEventArgs e)
        {
            if (!list_gorevli.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                list_gorevli.Items.Add(e.Data.GetData(DataFormats.Text));
                list_Tumkisiler.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        //drag eventi
        private void list_gorevli_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

       
    }
}
