using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class CLehrer
    {
        private string Name;
        private string Vorname;
        private CKlasse Kls;

        public void set_Name(string n) { Name=n; }
        public void set_Vorname(string v) { Vorname = v; }

        public void set_Klasse(CKlasse K) { Kls = K; }
        public string get_Name() { return Name; }
        public string get_Vorname() { return Vorname; }

        public CKlasse get_Klasse() { return Kls; }
    }
}
