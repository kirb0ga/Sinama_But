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
    public partial class MusteriKarti : Form
    {
        public MusteriKarti()
        {
            InitializeComponent();
        }

      
        //müsterileri listele
        void musteriListele()
        {
            gridControl1.DataSource = Db_Connection.baglanti().musteriListele();
            gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 16f);
            gridView1.Appearance.Row.Font = new Font("Tahoma", 12f);
        }

        //double clikc ile müşteriyi düzenleme DEVEXPRESS aracı
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow rw = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (rw != null)
            {
                Customer c = new Customer();
                c.Id = Convert.ToInt32(rw[0]);
                c.Ad = rw[1].ToString();
                c.Adres = rw[2].ToString();
                c.Telefon = rw[3].ToString();
                c.Email = rw[4].ToString();
                c.VergiDaire = rw[5].ToString();
                c.VergiNo = rw[6].ToString();
                c.Yetkili = rw[7].ToString();

                Yeni_Musteri_Karti ymk = new Yeni_Musteri_Karti(c);
                ymk.ShowDialog();
                musteriListele();
            }
        }

        private void MusteriKarti_Load_1(object sender, EventArgs e)
        {
            musteriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yeni_Musteri_Karti ymk = new Yeni_Musteri_Karti();
            ymk.ShowDialog();
            musteriListele();
        }
    }
}

