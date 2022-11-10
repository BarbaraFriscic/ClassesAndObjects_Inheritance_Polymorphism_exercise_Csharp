using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _9_11_2022_Predavanje
{
    internal class Igra
    {
        public string ImeIgre { get; set; }
        public int BrojIgraca { get; set; }

        public override string ToString()
        {
            return (GetType().Name + " " + ImeIgre + " - Broj igrača: " + BrojIgraca);
        }
    
    }
    class IgraNaVrijeme : Igra
    {
        public int TrajanjeIgre { get; set; }

        public new string ToString()
        {
            base.ToString();
            return (GetType().Name + " " + ImeIgre + " - Broj igrača: " + BrojIgraca + " - Vrijeme: " + TrajanjeIgre);
        }
    }
}
