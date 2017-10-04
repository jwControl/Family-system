using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRodzinny
{
    abstract class Czlowiek : CzlonekRodziny
    {
        public Czlowiek(string imie):base(imie)
        {

        }
        public Czlowiek(int wzrost, string kolor_skory, string nazwisko, string imie):base(imie)
        {
            this.wzrost = wzrost;
            this.kolor_skory = kolor_skory;
            this.nazwisko = nazwisko;
        }

        public int wzrost;
        public string kolor_skory;
        public string nazwisko;

        public void plakac()
        {

        }
        public void mowic()
        {

        }

        public void ksztalcic()
        {

        }
        public override string ToString()
        {
            string informacjeOCzlowieku;
            if (nazwisko == null)
            {
                informacjeOCzlowieku = base.ToString() + "\nWzrost: " + wzrost + "\nKolor skory: " + kolor_skory;
            }
            else
            {
                 informacjeOCzlowieku = base.ToString() + "\nWzrost: " + wzrost + "\nKolor skory: " + kolor_skory + "\nNazwisko: " + nazwisko;
                
            }
            return informacjeOCzlowieku;
        }
    }
}
