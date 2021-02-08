using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sinama_Final
{
    public class Db_Connection
    {
        private static Db_Connection _baglan;

        public static Users Hesap;

        
        //SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-Q04EB8O;Initial Catalog=Yazilim_Sinama;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Yazilim_Sinama.mdf;Integrated Security=True");
        //SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Yazilim_Sinama.mdf;Integrated Security=True");
        


        // Singleton tasarım deseni mantığı kullanıldığından örnek yaratılmaması için kurucu metot private yapılmıştır
        private Db_Connection()
        {
            //
        }




        // Tek nesne(Singleton) dolayı static 
        public static Db_Connection baglanti()
        {
            if (_baglan == null)
                _baglan = new Db_Connection();
            return _baglan;
        }


        // bağlantının durumunu kontrol eden metod
        void baglantiKontrol()
        {
            if (baglan.State == System.Data.ConnectionState.Closed)
                baglan.Open();
        }


     
        // Yeni kullanıcı kayıt işlemini yapan metod
        public bool kayit(Users kullanici)
        {
            bool onay = false;

            if (Tekrar_Kayit_Kontrolu(kullanici.KullaniciAdi))
            {
                baglantiKontrol();
                SqlCommand sql = new SqlCommand("insert into tbl_Users (kullaniciAdi,ad,soyad,parola) values (@klnc,@isim,@soyisim,@sifre)", baglan);
                sql.Parameters.AddWithValue("@klnc", kullanici.KullaniciAdi);
                sql.Parameters.AddWithValue("@isim", kullanici.Ad);
                sql.Parameters.AddWithValue("@soyisim", kullanici.Soyad);
                sql.Parameters.AddWithValue("@sifre", kullanici.Parola);

                sql.ExecuteNonQuery();
                baglan.Close();
                onay = true;
            }
            return onay;
        }


        // Tekrar kayıt önleme
        private bool Tekrar_Kayit_Kontrolu(string kullanciAdi)
        {
            bool kontrol = true;
            baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select * from tbl_Users where kullaniciAdi=@kullanıcıAD", baglan);
            cmd.Parameters.AddWithValue("@kullanıcıAD", kullanciAdi);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kontrol = false;
            }
            baglan.Close();
            return kontrol;
        }
       


        
        // giriş yapılan kullanıcı adı ve sifreyi kontrol eden metod
        public bool Kullanici_Giris_Kontrol(string kullaniciAdi, string sifre)
        {
            bool kontrol = false;
            baglantiKontrol();
            SqlCommand sql = new SqlCommand("select * from tbl_Users where kullaniciAdi=@kullaniciAD and parola=@sifre", baglan);
            sql.Parameters.AddWithValue("@kullaniciAD", kullaniciAdi);
            sql.Parameters.AddWithValue("@sifre", sifre);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                kontrol = true;
                Giris_yap(Convert.ToInt16(dr["ID"]), dr["ad"].ToString(), dr["soyad"].ToString(), dr["kullaniciAdi"].ToString());
            }
            baglan.Close();
            return kontrol;
        }


        // girişi yapıldığında kullanıcı bilgilerini static nesneye aktaran metot
        private void Giris_yap(int id, string isim, string soyisim, string kullanici_AD)
        {
            if (Hesap == null)
            {
                Hesap = new Users();
            }
            Hesap.Id = id;
            Hesap.Ad = isim;
            Hesap.Soyad = soyisim;
            Hesap.KullaniciAdi = kullanici_AD;
        }
        


        
        // yeni Project oluşturulan metot
        public void yeniProject(Project yeniProject)
        {
            baglantiKontrol();
            SqlCommand cmd = new SqlCommand("insert into tbl_Project (projeIsmi, musteri, aciklama) values (@pIsim, @musteri, @aciklama)", baglan);
            cmd.Parameters.AddWithValue("@pIsim", yeniProject.ProjeIsmi);
            cmd.Parameters.AddWithValue("@musteri", yeniProject.Musteri);
            cmd.Parameters.AddWithValue("@aciklama", yeniProject.Aciklama);
            cmd.ExecuteNonQuery();
            baglan.Close();

            //Tekrar Bağlantı
            baglantiKontrol();
            cmd = new SqlCommand("select IDENT_CURRENT('tbl_Project')", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yeniProject.Id = Convert.ToInt32(dr[0]);
            }
            baglan.Close();

            //Tekrar Bağlantı
            baglantiKontrol();
            cmd = new SqlCommand("insert into tbl_Project_Kisiler (projeId, kullaniciId) values (@projeId, @kullaniciId)", baglan);
            cmd.Parameters.AddWithValue("@projeId", yeniProject.Id);
            cmd.Parameters.AddWithValue("@kullaniciId", Hesap.Id);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }


        // Projenin bilgilerini güncelleyen(Düzenleyen) metodumuz
        public void Duzenle_Proje(Project mevcutProject)
        {
            baglantiKontrol();
            SqlCommand cmd = new SqlCommand("update tbl_Project set projeIsmi=@ProjectIsmi, musteri=@musteri, aciklama=@aciklama where ID=@id", baglan);
            cmd.Parameters.AddWithValue("@ProjectIsmi", mevcutProject.ProjeIsmi);
            cmd.Parameters.AddWithValue("@musteri", mevcutProject.Musteri);
            cmd.Parameters.AddWithValue("@aciklama", mevcutProject.Aciklama);
            cmd.Parameters.AddWithValue("@id", mevcutProject.Id);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }


        // kullanıcın dahil olduğu Projectleri liste içine alan metodumuz
        public List<Project> ProjectListele()
        {
            List<Project> Projectlerim = new List<Project>();
            baglantiKontrol();
            SqlCommand sql = new SqlCommand("select tbl_Project.ID, tbl_Project.projeIsmi, tbl_Project.Musteri,tbl_Project.Aciklama from tbl_Project inner join tbl_Project_Kisiler on tbl_Project.ID=tbl_Project_Kisiler.projeId where kullaniciId = @kullaniciId order by tbl_Project.ID", baglan);
            sql.Parameters.AddWithValue("@kullaniciId", Hesap.Id);
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                Project p = new Project();
                p.Id = Convert.ToInt32(dr["ID"]);
                p.ProjeIsmi = dr["projeIsmi"].ToString();
                p.Musteri = Convert.ToInt32(dr["Musteri"]);
                p.Aciklama = dr["Aciklama"].ToString();
                Projectlerim.Add(p);
            }
            baglan.Close();

            int i = 0;
            foreach (Project proje in Projectlerim)
            {
                baglantiKontrol();
                sql = new SqlCommand("select * from tbl_Project_Kisiler inner join tbl_Users on tbl_Project_Kisiler.kullaniciID = tbl_Users.ID where projeId = @pr1", baglan);
                sql.Parameters.AddWithValue("@pr1", proje.Id);
                dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Users u = new Users();
                    u.Id = Convert.ToInt16(dr["kullaniciID"]);
                    u.Ad = dr["ad"].ToString();
                    u.Soyad = dr["soyad"].ToString();
                    u.KullaniciAdi = dr["kullaniciAdi"].ToString();
                    Projectlerim[i].User.Add(u);
                }
                baglan.Close();

                baglantiKontrol();
                sql = new SqlCommand("select * from tbl_Task where projeId = @pr2", baglan);
                sql.Parameters.AddWithValue("@pr2", proje.Id);
                dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Tasks t = new Tasks();
                    t.Id = Convert.ToInt32(dr["ID"]);
                    t.Baslik = dr["gorevBaslik"].ToString();
                    t.Gorevli = Convert.ToInt32(dr["gorevliID"]);
                    t.Aciklama = dr["aciklama"].ToString();
                    Projectlerim[i]._Task.Add(t);
                }
                baglan.Close();
                i++;
            }
            return Projectlerim;
        }


        // Project'e kişi ataması için db'deki tüm kişileri çeker ve kişi arar
        public List<Users> kisiAra(string aranan, int projeId)
        {
            List<Users> k = new List<Users>();
            baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select * from tbl_Users where ID not in (select kullaniciId from tbl_Project_Kisiler where projeId = @prId) and (ad like '%" + aranan + "%' or soyad like '%" + aranan + "%' or kullaniciAdi like '%" + aranan + "%')", baglan);
            cmd.Parameters.AddWithValue("@prId", projeId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Users u = new Users();
                u.Id = Convert.ToInt16(dr["ID"]);
                u.Ad = dr["ad"].ToString();
                u.Soyad = dr["soyad"].ToString();
                u.KullaniciAdi = dr["kullaniciAdi"].ToString();
                k.Add(u);
            }
            baglan.Close();
            return k;
        }

      


        
        //Yeni task işlevi yapan ve ekleyen
        public bool gorevEkle(Tasks Add_Task, int projeId)
        {
            bool onay = false;
            if (Tekrar_kayıt_kontrolet(projeId, Add_Task.Baslik))
            {
                baglantiKontrol();
                SqlCommand cmd = new SqlCommand("insert into tbl_Task (projeId, gorevBaslik, gorevliId, aciklama) values (@prId, @bslk, @grvli, @ack)", baglan);
                cmd.Parameters.AddWithValue("@prId", projeId);
                cmd.Parameters.AddWithValue("@bslk", Add_Task.Baslik);
                cmd.Parameters.AddWithValue("@grvli", Add_Task.Gorevli);
                cmd.Parameters.AddWithValue("@ack", Add_Task.Aciklama);
                cmd.ExecuteNonQuery();
                baglan.Close();

                int gorevID = 0;
                baglantiKontrol();
                cmd = new SqlCommand("select IDENT_CURRENT('tbl_Task')", baglan);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gorevID = Convert.ToInt32(dr[0]);
                }
                baglan.Close();

                baglantiKontrol();
                cmd = new SqlCommand("insert into tbl_Tasks_Situations (gorevID, durumID, kullaniciID, tarih) values (@gr, @dr, @ka, @tr)", baglan);
                cmd.Parameters.AddWithValue("@gr", gorevID);
                cmd.Parameters.AddWithValue("@dr", 1);
                cmd.Parameters.AddWithValue("@ka", Hesap.Id);
                cmd.Parameters.AddWithValue("@tr", DateTime.Now);
                cmd.ExecuteNonQuery();
                baglan.Close();

                
                onay = true;
            }
            return onay;
        }


        // Taskın görevlerini güncelleyen metodumuz 
        public bool Duzenle_Gorev(Tasks Update_Taks, int ProjectId)
        {
            bool onay = false;
            if (Tekrar_kayıt_kontrolet(ProjectId, Update_Taks.Baslik, Update_Taks.Id, false))
            {
                baglantiKontrol();
                SqlCommand cmd = new SqlCommand("update tbl_Task set gorevBaslik = @bslk, gorevliID = @grvli, aciklama=@ack where ID = @grId", baglan);
                cmd.Parameters.AddWithValue("@grId", Update_Taks.Id);
                cmd.Parameters.AddWithValue("@bslk", Update_Taks.Baslik);
                cmd.Parameters.AddWithValue("@grvli", Update_Taks.Gorevli);
                cmd.Parameters.AddWithValue("@ack", Update_Taks.Aciklama);
                cmd.ExecuteNonQuery();
                baglan.Close();

                baglantiKontrol();
                cmd = new SqlCommand("delete from tbl_Control_List where gorevID = @grId", baglan);
                cmd.Parameters.AddWithValue("@grId", Update_Taks.Id);
                cmd.ExecuteNonQuery();
                baglan.Close();

                
                onay = true;
            }
            return onay;
        }


        // girilen task başlığının aynı projede kullanılmamasını engelleyen ve kontrol eden metod
        private bool Tekrar_kayıt_kontrolet(int projeId, string baslik, int gorevId = 0, bool yenikayit = true)
        {
            bool kontrol = true;
            string sorgu_metni = "";
            baglantiKontrol();
            if (yenikayit)
                sorgu_metni = "select * from tbl_Task where projeId = @pr and gorevBaslik = @gb";
            else
                sorgu_metni = "select * from tbl_Task where projeId = @pr and gorevBaslik = @gb and ID <> @grId";
            SqlCommand sql = new SqlCommand(sorgu_metni, baglan);
            sql.Parameters.AddWithValue("@grId", gorevId);
            sql.Parameters.AddWithValue("@pr", projeId);
            sql.Parameters.AddWithValue("gb", baslik);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                kontrol = false;
            }
            baglan.Close();
            return kontrol;
        }


        // task'a sorumlu kişi ataması yapan metod
        public void Kisi_ekle_Gorev(List<string> kisiler, int Projectid)
        {
            baglantiKontrol();
            SqlCommand sql = new SqlCommand("delete from tbl_Project_Kisiler where projeId = @prID", baglan);
            sql.Parameters.AddWithValue("@prID", Projectid);
            sql.ExecuteNonQuery();
            baglan.Close();

            List<int> gorevliId = new List<int>();

            foreach (string item in kisiler)
            {
                baglantiKontrol();
                sql = new SqlCommand("select ID from tbl_Users where kullaniciAdi = @kullaniciAdi", baglan);
                sql.Parameters.AddWithValue("@kullaniciAdi", item);
                SqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    gorevliId.Add(Convert.ToInt16(dr[0]));
                }
                baglan.Close();
            }


            foreach (int item in gorevliId)
            {
                baglantiKontrol();
                sql = new SqlCommand("insert into tbl_Project_Kisiler (projeId, kullaniciId) values (@projeID, @kullanici)", baglan);
                sql.Parameters.AddWithValue("@projeID", Projectid);
                sql.Parameters.AddWithValue("@kullanici", item);
                sql.ExecuteNonQuery();
                baglan.Close();
            }
        }


        // taskın durumunu öğrenen metod
        public int Task_Durum_Ogren(int gorevID)
        {
            int durum = 0;
            baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select top 1 * from tbl_Tasks_Situations where gorevID = @gr order by ID desc", baglan);
            cmd.Parameters.AddWithValue("@gr", gorevID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = Convert.ToInt32(dr["durumID"]);
            }
            baglan.Close();
            return durum;
        }


        // Task bilgilerininin atayan(ve id öğrenen) metot
        public Tasks Task_id_Ogren(int ProjectId, string baslik)
        {
            Tasks t = new Tasks();
            baglantiKontrol();
            SqlCommand sql = new SqlCommand("select * from tbl_Task where projeId = @prID and gorevBaslik = @bslk", baglan);
            sql.Parameters.AddWithValue("@prID", ProjectId);
            sql.Parameters.AddWithValue("@bslk", baslik);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                t.Id = Convert.ToInt32(dr["ID"]);
                t.Baslik = dr["gorevBaslik"].ToString();
                t.Gorevli = Convert.ToInt32(dr["gorevliID"]);
                t.Aciklama = dr["aciklama"].ToString();
            }
            baglan.Close();

           
            return t;
        }


        //Görevin durumunu günceller
        
        public void gorevDurumDegistir(int ProjectId, string baslik, int durum)
        {
            Tasks t = new Tasks();
            t = Task_id_Ogren(ProjectId, baslik);

            baglantiKontrol();
            SqlCommand sql = new SqlCommand("insert into tbl_Tasks_Situations (gorevID, durumID, kullaniciID, tarih) values (@grv, @drID, @klncID, @trh)", baglan);
            sql.Parameters.AddWithValue("@grv", t.Id);
            sql.Parameters.AddWithValue("@drID", durum);
            sql.Parameters.AddWithValue("@klncID", Hesap.Id);
            sql.Parameters.AddWithValue("@trh", DateTime.Now);
            sql.ExecuteNonQuery();
            baglan.Close();

            if (durum != 0)
            {
                baglantiKontrol();
                string sorgu = "";
                if (durum == 2)
                    sorgu = "update tbl_Task set baslama = @tr where ID = @gr";
                else if (durum == 3)
                    sorgu = "update tbl_Task set bitirme = @tr where ID = @gr";
                sql = new SqlCommand(sorgu, baglan);
                sql.Parameters.AddWithValue("@gr", t.Id);
                sql.Parameters.AddWithValue("@tr", DateTime.Now);
                sql.ExecuteNonQuery();
                baglan.Close();
            }
        }


        // görev hareketlerini listeleyen metot
        public DataTable Task_Hareketleri(int gorevId)
        {
            DataTable dt = new DataTable();
            baglantiKontrol();
            SqlDataAdapter da = new SqlDataAdapter("select tarih [TARİH], durumAdi [DURUM_ADI], ad+' '+soyad [İŞLEMI_YAPAN] from tbl_Tasks_Situations inner join tbl_Users on tbl_Tasks_Situations.kullaniciID=tbl_Users.ID inner join tbl_Situations on tbl_Tasks_Situations.durumID=tbl_Situations.ID where gorevID = @gr", baglan);
            da.SelectCommand.Parameters.AddWithValue("@gr", gorevId);
            da.Fill(dt);
            return dt;
        }


        
       
       


      
        //Seçilen görevin
        //Ortalama olarak ne zaman biteceğini hesaplar kişi bazlı
        public int Kisi_Ortalama(int UsersId)
        {
            int ortalamaSure = 0;
            baglantiKontrol();
            SqlCommand sql = new SqlCommand("select avg(DATEdiff(MINUTE, baslama, bitirme)) from tbl_Task where bitirme is not null and gorevliID = @gr group by gorevliID", baglan);
            sql.Parameters.AddWithValue("@gr", UsersId);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                ortalamaSure = Convert.ToInt16(dr[0]);
            }
            baglan.Close();
            return ortalamaSure;
        }


        // Geçen süreyi
        //hesapladığımız metod
        public int GecenSure(int gorevId, int durum = 1)
        {
            baglantiKontrol();
            SqlCommand sql = new SqlCommand("select top 1 durumId from tbl_Tasks_Situations where gorevId = @gid order by tarih desc", baglan);
            sql.Parameters.AddWithValue("@gid", gorevId);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                durum = Convert.ToInt16(dr[0]);
            }
            baglan.Close();

            int gecenSure = 0;
            if (durum > 1)
            {
                string sorgu_metni = "";
                baglantiKontrol();
                if (durum == 2)
                {
                    sorgu_metni = "select datediff(minute, baslama, getdate()) from tbl_Task where ID = @id";
                }
                else if (durum == 3)
                {
                    sorgu_metni = "select DATEDIFF(MINUTE, baslama, bitirme) from tbl_Task where ID = @id";
                }

                sql = new SqlCommand(sorgu_metni, baglan);
                sql.Parameters.AddWithValue("@id", gorevId);
                SqlDataReader dr2 = sql.ExecuteReader();
                if (dr2.Read())
                {
                    gecenSure = Convert.ToInt16(dr2[0]);
                }

                baglan.Close();
            }
            return gecenSure;
        }

       
        //musteri getirme metod

       
        public List<Customer> getir_Musteri()
        {
            List<Customer> c = new List<Customer>();
            baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select * from tbl_Customer", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer c1 = new Customer();
                c1.Id = Convert.ToInt32(dr["ID"]);
                c1.Ad = dr["musteriAdi"].ToString();
                c1.Adres = dr["adres"].ToString();
                c1.Telefon = dr["telefon"].ToString();
                c1.Email = dr["eMail"].ToString();
                c1.VergiDaire = dr["vergiDaire"].ToString();
                c1.VergiNo = dr["vergiNo"].ToString();
                c1.Yetkili = dr["yetkiliKisi"].ToString();
                c.Add(c1);
            }

            baglan.Close();
            return c;
        }



        //Yeni müsteri
        //ekleme metod
        public bool Ekle_Musteri(Customer musteri)
        {
            bool onay = false;
            if (tekrarMusteriKontrol(musteri))
            {
                baglantiKontrol();
                SqlCommand cmd = new SqlCommand("insert into tbl_Customer (musteriAdi, adres, telefon, eMail, vergiDaire, vergiNo, yetkiliKisi) values (@ad, @adres, @tlf, @mail, @vDaire, @vkn, @yetkili)", baglan);
                cmd.Parameters.AddWithValue("@ad", musteri.Ad);
                cmd.Parameters.AddWithValue("@adres", musteri.Adres);
                cmd.Parameters.AddWithValue("@tlf", musteri.Telefon);
                cmd.Parameters.AddWithValue("@mail", musteri.Email);
                cmd.Parameters.AddWithValue("@vDaire", musteri.VergiDaire);
                cmd.Parameters.AddWithValue("@vkn", musteri.VergiNo);
                cmd.Parameters.AddWithValue("@yetkili", musteri.Yetkili);
                cmd.ExecuteNonQuery();
                baglan.Close();
                onay = true;
            }
            return onay;
        }

        //musteri guncelleyen metod
        public bool Guncelle_Musteri(Customer musteri)
        {
            bool kontrol = false;
            if (tekrarMusteriKontrol(musteri))
            {
                baglantiKontrol();
                SqlCommand sql = new SqlCommand("update tbl_Customer set musteriAdi=@ad, adres=@adres, telefon=@tlf, eMail=@mail, vergiDaire=@vDaire, vergiNo=@vkn, yetkiliKisi=@yetkili where ID = @id", baglan);
                sql.Parameters.AddWithValue("@ad", musteri.Ad);
                sql.Parameters.AddWithValue("@adres", musteri.Adres);
                sql.Parameters.AddWithValue("@tlf", musteri.Telefon);
                sql.Parameters.AddWithValue("@mail", musteri.Email);
                sql.Parameters.AddWithValue("@vDaire", musteri.VergiDaire);
                sql.Parameters.AddWithValue("@vkn", musteri.VergiNo);
                sql.Parameters.AddWithValue("@yetkili", musteri.Yetkili);
                sql.Parameters.AddWithValue("@id", musteri.Id);
                sql.ExecuteNonQuery();
                baglan.Close();
                kontrol = true;
            }
            return kontrol;
        }


        //tekrar müşteri
        //kontrolü yaparak önüne geçen metod
        private bool tekrarMusteriKontrol(Customer _musteri)
        {
            bool kontrol = false;
            baglantiKontrol();
            string sorgu = "select * from tbl_Customer where musteriAdi = @musteri or vergiNo = @vkn";
            if (_musteri.Id != null)
                sorgu = "select * from tbl_Customer where (musteriAdi = @musteri or vergiNo = @vkn) and ID<>@id";
            SqlCommand cmd = new SqlCommand(sorgu, baglan);
            cmd.Parameters.AddWithValue("@musteri", _musteri.Ad);
            cmd.Parameters.AddWithValue("@vkn", _musteri.VergiNo);
            cmd.Parameters.AddWithValue("@id", _musteri.Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kontrol = false;
            }
            else
            {
                kontrol = true;
            }
            baglan.Close();
            return kontrol;
        }


        //Müşteri
        //listeleyen meotd
        public DataTable musteriListele()
        {
            DataTable dt = new DataTable();
            baglantiKontrol();
            SqlDataAdapter da = new SqlDataAdapter("select ID [Müşteri NO], musteriAdi [Müşteri Adı], adres [Adres], telefon [Telefon], eMail [e-Mail], vergiDaire [Vargi Dairesi], vergiNo [Vergi Numarası], yetkiliKisi [Yetkili Kişi] from tbl_Customer", baglan);
            da.Fill(dt);
            return dt;
        }

        

    }
}

