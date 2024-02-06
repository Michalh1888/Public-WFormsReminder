using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upominac
{
    
    public class Osoba
    {
        public string Jmeno { get; private set; } = "";
        public DateTime Narozeniny { get; private set;}

        public string DalsiUdaje { get; private set; } = "";

        
        public Osoba() 
        { 
        }
        public Osoba(string jmeno, DateTime narozeniny, string udaje):this()
        {
            Jmeno = jmeno;
            Narozeniny = narozeniny;
            DalsiUdaje = udaje;
        }

        public int SpoctiVek()
        {
            DateTime dnes = DateTime.Today;
            int vek = dnes.Year - Narozeniny.Year;
            if (dnes < Narozeniny.AddYears(vek))
                vek--;
            return vek;
        }
        public int ZbyvaDni(bool dalsiNaroz)
        {
            int a;
            if (dalsiNaroz) a = 1;
            else a = 0; 
            DateTime dalsiNarozeniny = Narozeniny.AddYears(SpoctiVek() + a);
            TimeSpan rozdil = dalsiNarozeniny - DateTime.Today;
            return Convert.ToInt32(rozdil.TotalDays);
        }
        public override string ToString()
        {
            return Jmeno;
        }

    }
}
