using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinama_Final
{
    public class Users
    {
        public static Users _sistemdeki_Kullanici;


        private int _id;
        private string _ad;
        private string _soyad;
        private string _kullaniciAdi;
        private string _parola;


        public int Id { get { return _id; } set { _id = value; } }
        public string Ad { get { return _ad; } set { _ad = value; } }
        public string Soyad { get { return _soyad; } set { _soyad = value; } }
        public string KullaniciAdi { get { return _kullaniciAdi; } set { _kullaniciAdi = value; } }
        public string Parola { get { return _parola; } set { _parola = value; } }

    }
}
