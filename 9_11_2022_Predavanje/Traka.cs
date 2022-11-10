using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11_2022_Predavanje
{
    internal class Traka
    {
        public double Duljina { get; set; }

        public double Sirina { get; set; }

        public override string ToString()
        {
            return (GetType().Name + " - Širina: " + Sirina + " - Duljina: " + Duljina);
        }
    }
    class FilmskaTraka : Traka
    {
        public int Trajanje { get; set; }
    }

    class LjepljivaTraka : Traka
    {
        private int ljepljivost;

        public int Ljepljivost
        {
            get { return ljepljivost; }
            set 
            {
                if (value >= 1 && value <= 10)
                    ljepljivost = value;
                else
                    ljepljivost = 1;
            }
        }
        public new string ToString()
        {
            return (GetType().Name + " - Širina: " + Sirina + " - Duljina: " + Duljina + " - Ljepljivost: " + Ljepljivost);
        }

    }
}
