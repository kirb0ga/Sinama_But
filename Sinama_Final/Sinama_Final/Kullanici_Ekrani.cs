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
    public partial class Kullanici_Ekrani : Form
    {
        public static int index_list = -1;


        List<Project> my_Projects = new List<Project>();
        public Kullanici_Ekrani()
        {
            InitializeComponent();
        }
             

        

       

       
        //projeleri listediğimiz metodumuz 3 farklı yerde referans var
        void projeListele()
        {
            lst_projem.Items.Clear();
            my_Projects = Db_Connection.baglanti().ProjectListele();

            foreach (Project item in my_Projects)
            {
                lst_projem.Items.Add(item.ProjeIsmi);
            }

        }



        
       //taskı görüntülediğimiz metod
        private void Tasks_Goruntule(string baslik, int durum = 1)
        {
            int index = lst_projem.SelectedIndex;
            Tasks t = Db_Connection.baglanti().Task_id_Ogren(my_Projects[index].Id, baslik);
            Yeni_Görev yg = new Yeni_Görev(my_Projects[index], t);
            yg.durum = durum;
            yg.ShowDialog();
            projeListele();
            lst_projem.SelectedIndex = index;
        }


        private void btn_YeniProje_Click_1(object sender, EventArgs e)
        {
            Yeni_Projem yeniprojem = new Yeni_Projem();  //yeni proje modülü
            yeniprojem.ShowDialog();
        }

        private void btn_Musteri_Click_1(object sender, EventArgs e)
        {
            MusteriKarti musteriK = new MusteriKarti();   //müşteri kartı modülü
            musteriK.ShowDialog();
        }

        private void lst_projem_DoubleClick_1(object sender, EventArgs e)
        {
            index_list = lst_projem.SelectedIndex;
            Sec s = new Sec();                           //Sec modülü
            s.ShowDialog();

        }

        private void Kullanici_Ekrani_Load_1(object sender, EventArgs e)
        {

            label6.Text = Db_Connection.Hesap.Ad;               //kullanıcı adı
            projeListele();

        }
        //Sürükle bırak işlemlerim
        int suruklenen = 0;

        // sağ ve sol tıklama ile yapılacaklar..
        private void list_toDo_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (list_toDo.SelectedItem != null)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    Tasks_Goruntule(list_toDo.SelectedItem.ToString());
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    list_Inprog.DoDragDrop(list_toDo.SelectedItem.ToString(), DragDropEffects.Copy);
                }
            }
        }


        //surukle bırak mantığı için enter eventi
        private void list_toDo_MouseEnter_1(object sender, EventArgs e)
        {
            suruklenen = 0;

        }

        //ın progress için sağ ve sol tıklama eventleri
        private void list_Inprog_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (list_Inprog.SelectedItem != null)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    Tasks_Goruntule(list_Inprog.SelectedItem.ToString(), 2);
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    list_Done.DoDragDrop(list_Inprog.SelectedItem.ToString(), DragDropEffects.Copy);
                }
            }
        }

        //ın progress drag işlemleri
        private void list_Inprog_DragEnter_1(object sender, DragEventArgs e)
        {
            string deger = e.Data.GetData(DataFormats.Text).ToString();
            if (!list_Inprog.Items.Contains(e.Data.GetData(DataFormats.Text))) //birdaha liste  eklememsi için kontrol yapıyoruz
            {
                list_Inprog.Items.Add(e.Data.GetData(DataFormats.Text));
                list_Done.Items.Remove(e.Data.GetData(DataFormats.Text));
                Db_Connection.baglanti().gorevDurumDegistir(my_Projects[lst_projem.SelectedIndex].Id, deger, 2);
            }

        }

        //surkle bırak için gereken event
        private void list_Inprog_MouseEnter_1(object sender, EventArgs e)
        {
            suruklenen = 1;
        }

        //event kontrolü
        private void list_Done_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (list_Done.SelectedItem != null)  // eğer bir değer seçildiyse
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)  // ve sağ tıklama yapıldıysa
                {
                    Tasks_Goruntule(list_Done.SelectedItem.ToString(), 3);
                }
            }
        }

        private void list_Done_DragDrop_1(object sender, DragEventArgs e)
        {
            string deger = e.Data.GetData(DataFormats.Text).ToString();
            if (!list_Done.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                list_Done.Items.Add(e.Data.GetData(DataFormats.Text));
                list_Inprog.Items.Remove(e.Data.GetData(DataFormats.Text));

                Db_Connection.baglanti().gorevDurumDegistir(my_Projects[lst_projem.SelectedIndex].Id, deger, 3);
            }
        }

        private void list_Done_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && suruklenen == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        //Projeye ait verileri gösteren metod
        private void lst_projem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            list_toDo.Items.Clear();
            list_Inprog.Items.Clear();
            list_Done.Items.Clear();


            if (lst_projem.SelectedItem != null)
            {
                int index = lst_projem.SelectedIndex;
                foreach (Tasks t in my_Projects[index]._Task)
                {
                    int durum = Db_Connection.baglanti().Task_Durum_Ogren(t.Id);
                    switch (durum)
                    {
                        case 1:
                            list_toDo.Items.Add(t.Baslik);
                            break;
                        case 2:
                            list_Inprog.Items.Add(t.Baslik);
                            break;
                        case 3:
                            list_Done.Items.Add(t.Baslik);
                            break;
                        default: break;
                    }
                }
            }
        }

        //kullanıcı formu üzerine gelindiğinde
        //olacaklar
        private void Kullanici_Ekrani_MouseEnter_1(object sender, EventArgs e)
        {

            if (Sec.listele || Yeni_Projem.listele)
            {
                projeListele();
                lst_projem.SelectedIndex = index_list;
            }

        }
    }
}
