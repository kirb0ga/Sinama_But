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
    public partial class Sec : Form
    {

        public static bool listele = false;
        public Sec()
        {
            InitializeComponent();
        }
        List<Project> my_Projects = new List<Project>();
       

        //seçilen projeyi açar
        private void btn_mevcut_Click_1(object sender, EventArgs e)
        {
            Yeni_Projem yp = new Yeni_Projem(my_Projects[Kullanici_Ekrani.index_list]);
            yp.ShowDialog();
            listele = true;

        }

        //yeni görev ekleme modül
        private void btn_yeniGorev_Click_1(object sender, EventArgs e)
        {
            Yeni_Görev yg = new Yeni_Görev(my_Projects[Kullanici_Ekrani.index_list]);

            yg.ShowDialog();
            listele = true;
        }

        //seçilen projee kişi eklemeye yarar.
        private void btn_kisi_Click_1(object sender, EventArgs e)
        {
            Proje_Kisi_Ekle ke = new Proje_Kisi_Ekle(my_Projects[Kullanici_Ekrani.index_list]);
            ke.ShowDialog();
            listele = true;
            this.Close();
        }

        private void Sec_Load_1(object sender, EventArgs e)
        {
            my_Projects = Db_Connection.baglanti().ProjectListele();
        }
    }
}
