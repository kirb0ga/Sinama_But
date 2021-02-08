using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinama_Final
{
    public class Customer
    {
        private int _id;
        private string _ad;
        private string _adres;
        private string _telefon;
        private string _email;
        private string _vergiDaire;
        private string _vergiNo;
        private string _yetkiliKisi;


        public int Id { get { return _id; } set { _id = value; } }
        public string Ad { get { return _ad; } set { _ad = value; } }
        public string Adres { get { return _adres; } set { _adres = value; } }
        public string Telefon { get { return _telefon; } set { _telefon = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string VergiDaire { get { return _vergiDaire; } set { _vergiDaire = value; } }
        public string VergiNo { get { return _vergiNo; } set { _vergiNo = value; } }
        public string Yetkili { get { return _yetkiliKisi; } set { _yetkiliKisi = value; } }
    }
}
