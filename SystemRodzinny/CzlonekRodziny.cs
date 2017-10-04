using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRodzinny //przestrzen nazw, zbiór klas
{
    abstract class CzlonekRodziny
    {
        public CzlonekRodziny(string imie)
        {
            this.imie = imie;
        }

        private string imie;
        public int wiek;
        public int waga;
        public string postawa;
        public int ilosc_zebow;
        public bool uzebienie;
        public string gatunek;
        public string lokalizacja;
        public string cechaSzczegolna;
        //string rodzic;
        //string dziecko;

        public void poruszanie()
        {

        }

        public void wydawanieDzwiekow()
        {

        }

        public void kochanie()
        {

        }

        public override string ToString()
        {
            string informacjeOCzlonkuRodziny = "\nImie: "+imie;
            return informacjeOCzlonkuRodziny;
        }


    }
}
