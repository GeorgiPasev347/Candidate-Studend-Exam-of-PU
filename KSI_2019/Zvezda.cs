using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI2019
{
     class Zvezda
    {
        
        public string ImeNomer { get; set; }
        public decimal Razstoyanie { get; set; }
        public char Klasific { get; set; }
        public decimal Masa { get; set; }
        public string ImeNaSuzvezie { get; set; }

        public Zvezda(string imenomer,decimal razstoyanie,char klasif,decimal masa,string suzvezdie) 
        {
           ImeNomer= imenomer;
            Razstoyanie= razstoyanie;
            Klasific = klasif;
            Masa = masa;
            ImeNaSuzvezie = suzvezdie;
        }
        public override string ToString()
        {
            return $"{ImeNomer},{Razstoyanie},{Klasific},{Masa},{ImeNaSuzvezie}";
        }

    }
}
