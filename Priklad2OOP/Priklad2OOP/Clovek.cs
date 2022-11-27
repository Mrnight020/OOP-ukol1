using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad2OOP
{
    class Clovek
    {
        string jmeno;
        string narozen;

        public Clovek(string jmeno,string narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
        }

        public void NastavJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public string VypisJmeno()
        {
            return jmeno;
        }
        public double Vek()
        {
            DateTime dnes = DateTime.Now;
            DateTime narozeni = DateTime.Parse(narozen);
            TimeSpan vek = dnes - narozeni;
            
            return (vek.TotalDays / 365);
        }
        public bool Plnolety()
        {
            double vek = Vek();
            if(vek < 18)return false;
            else return true;
        }

        public override string ToString()
        {
            return String.Format("{0} má {1} let a {2}", VypisJmeno(), (int)Vek(), Plnolety()? "je plnoletý" : "není plnoletý");
        }
        public string Starsi(Clovek clovek1,Clovek clovek2)
        {            
            double vek1 = clovek1.Vek();
            double vek2 = clovek2.Vek();
            if(vek1 > vek2) {
                return "starsi je " + clovek1.jmeno;
            }else{
                return "starsi je " + clovek2.jmeno;
            }
        }


    }
}
