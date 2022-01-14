using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CKlasse
    {
        private string Name;
        private CLehrer Klassenlehrer;
        private List<CSchuler> Schulers= new List<CSchuler>();

        public void set_Name(string n) { Name = n; }
        public void set_Klassenlehrer(CLehrer L1) { Klassenlehrer = L1; }
        public string get_Name() { return Name; }
        public void add_Schuler(CSchuler S) { Schulers.Add(S); }
        public CLehrer get_Lehrer() { return Klassenlehrer; }

        public string get_Schulerliste() 
        {
            string SL="";
            foreach(CSchuler S in Schulers) {if(S.get_Status()) SL += S.get_Name() + " " + S.get_Vorname() + "\n"; }
            return SL; 
        }
    }
}
