using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRodzinny
{
    enum poziomWykszalcenia
        {
        podstawowe,
        srednie,
        wyzsze
    }
    enum pogladyPolityczne
    {
        prawica, 
        lewica,
        korwinizm
    }
    class Dorosly : Czlowiek
    {
        public Dorosly(string imie):base(imie)
        {

        }
        public Dorosly(bool wartosc1, poziomWykszalcenia wartosc2, pogladyPolityczne wartosc3, int wzrost, string kolor_skory, string nazwisko, string imie):base(wzrost, kolor_skory,nazwisko, imie) 
        {
            czyposiadaprace = wartosc1;
            wyksztalcenie = wartosc2;
            pogladyPolityczne = wartosc3;



        }
        private bool czyposiadaprace;
        public poziomWykszalcenia wyksztalcenie;
        public pogladyPolityczne pogladyPolityczne;
        public override string ToString()
        {
            string informacjeODoroslym = base.ToString()+"\nCzy posiada prace " +czyposiadaprace  + "\nCecha szczegolna: " + cechaSzczegolna + "\nPoglady polityczne: " + pogladyPolityczne;
            return informacjeODoroslym;
        }


    }
}
