using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinama_Final
{
    public class Tasks
    {
        private int _id;
        private string _aciklama;
        private string _baslik;
        private int _gorevliID;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Baslik
        {
            get { return _baslik; }
            set { _baslik = value; }
        }
        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        public int Gorevli
        {
            get { return _gorevliID; }
            set { _gorevliID = value; }
        }
        
    }
}
