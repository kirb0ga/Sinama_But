using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinama_Final
{
    public class Project
    {
        private int _id;
        private string _projeIsmi;
        private int _musteri;
        private string _aciklama;
        private List<Users> _user = new List<Users>();
        private List<Tasks> _task = new List<Tasks>();


        public int Id { get { return _id; } set { _id = value; } }
        public string ProjeIsmi { get { return _projeIsmi; } set { _projeIsmi = value; } }
        public int Musteri { get { return _musteri; } set { _musteri = value; } }
        public string Aciklama { get { return _aciklama; } set { _aciklama = value; } }
        public List<Users> User { get { return _user; } set { _user = value; } }
        public List<Tasks> _Task { get { return _task; } set { _task = value; } }
    }
}
