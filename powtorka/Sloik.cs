using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorka
{
    class Sloik
    {

        public string Kształt { get; set; }

        public string Kolor { get; set; }

        public double Srednica { get; set; }

        public bool CzySzklany { get; set; }



        public Sloik(string ksztalt, string kolor, double srednica, bool czyszklany)
        {
            Kształt = ksztalt;
            Kolor = kolor;
            Srednica = srednica;
            CzySzklany = czyszklany;
        }





        public override string ToString()
        {
            return $"Kolor = {Kolor}, Srednica = {Srednica}, Ksztalt = {Kształt}, Czy szklany = {CzySzklany}";
        }



    }
}
