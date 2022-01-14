using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CSchuler
    {
        private string Name;
        private string Vorname;
        private bool istdrin=false;
        public void set_Name(string n) { Name = n; }
        public void set_Vorname(string v) { Vorname = v; }

        public void set_Status(bool id) { istdrin = id; }
        public bool get_Status() { return istdrin; }

        
        public string get_Name() { return Name; }
        public string get_Vorname() { return Vorname; }
    }
}
