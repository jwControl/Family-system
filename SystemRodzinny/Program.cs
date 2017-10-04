using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRodzinny
{
    class Program
    {

        static void Main(string[] args) 
        {
            #region dorosli
            Dorosly Asia = new Dorosly(false, poziomWykszalcenia.wyzsze, pogladyPolityczne.korwinizm, 155, "biala", "Walczak", "Asia");
            Dorosly Konrad = new Dorosly(true, poziomWykszalcenia.srednie, pogladyPolityczne.korwinizm, 190, "biala", "Cinkusz", "Konrad");
            Dorosly CiociaMonika = new Dorosly(false, poziomWykszalcenia.srednie, pogladyPolityczne.lewica, 155, "biala", "Czachor", "Monika");
            Dorosly mamaUrszula = new Dorosly("Urszula");
            Dorosly siostraMarta = new Dorosly("Marta");
            Dorosly mazMarty = new Dorosly("Marcin");
            Dorosly bratMarcin = new Dorosly("Marcin");
            Dorosly bratMichal = new Dorosly("Michal");
            Dorosly Korwin = new Dorosly("Korwin");
            Dorosly Kiszka = new Dorosly("Wiola");

            List<Dorosly> ListaDoroslych = new List<Dorosly>();
            ListaDoroslych.Add(Asia);
            ListaDoroslych.Add(Konrad);
            ListaDoroslych.Add(mamaUrszula);
            ListaDoroslych.Add(CiociaMonika);
            ListaDoroslych.Add(siostraMarta);
            ListaDoroslych.Add(mazMarty);
            ListaDoroslych.Add(bratMarcin);
            ListaDoroslych.Add(bratMichal);
            ListaDoroslych.Add(Korwin);
            ListaDoroslych.Add(Kiszka);
            #endregion
            #region dzieci
            Dziecko Nikodem = new Dziecko(false, "Nikodem");
            Nikodem.nazwisko = "Grabowski";
            List<Dziecko> ListaDzieci = new List<Dziecko>();
            ListaDzieci.Add(Nikodem);
            
            #endregion
            List<Czlowiek> ListaLudzi = new List<Czlowiek>();
            ListaLudzi.AddRange(ListaDoroslych);
            ListaLudzi.AddRange(ListaDzieci);

            //foreach (Czlowiek tymczasowa in ListaLudzi)
            //{
            //    if (tymczasowa is Dziecko) //jezeli zmienna tymczasowa jest typu dziecko
            //    {
            //        Dziecko tymczasowaDziecko = tymczasowa as Dziecko;
            //        Console.WriteLine(tymczasowaDziecko.ToString());
            //    }
            //}

            Pies piesBachus = new Pies("Bachus");
            Pies piesSara = new Pies("Sara");
            List<Pies> ListaPsow = new List<Pies>();
            ListaPsow.Add(piesBachus);
            ListaPsow.Add(piesSara);

            Kot kotNikodem = new Kot("Nikodem");
            Kot kotFelek = new Kot("Felek");
            List<Kot> ListaKotow = new List<Kot>();
            ListaKotow.Add(kotNikodem);
            ListaKotow.Add(kotFelek);

            List<Zwierze> ListaZwierzat = new List<Zwierze>();
            ListaZwierzat.AddRange(ListaPsow);
            ListaZwierzat.AddRange(ListaKotow);

            List<CzlonekRodziny> ListaCzlonkowRodziny = new List<CzlonekRodziny>();
            ListaCzlonkowRodziny.AddRange(ListaZwierzat);
            ListaCzlonkowRodziny.AddRange(ListaLudzi);

            //Asia.cechaSzczegolna = "niska";
            //Console.WriteLine(Asia.ToString());
            //Console.WriteLine(Konrad.ToString());
            //Console.WriteLine(Konrad.ToString());
            //Console.WriteLine(piesBachus.ToString());
            //Console.WriteLine(piesSara.ToString());
            //Console.WriteLine(kotNikodem.ToString());
            //Console.WriteLine(mamaUrszula.ToString());
            //Console.WriteLine(siostraMarta.ToString());
            //Console.WriteLine(mazMarty.ToString());
            Console.Read();
            //1. na podstawie reprezentacji obiektow wprowadzić hierarchie klas (architekture systemu)
            //2. na podstawie hierarchi klas utworzyć obiekty
            //3. wyekstrachowac funkcje tworzace obiekty oraz funkcje z logika oprogramowania
            //7. wyekstrahowac interfejsy
            //10. wyszukaj w tablicy przechowującej członkow rodziny tych czlonkow ktorzy maja na imie Nikodem i sprawdz ktory jest kotem (linku)

            //dla chetnych: napisac program, ktory zwroci maksymalne wartosci calkowitoliczbowe
            //na aktualnie uruchamianym systemie dla typow int, long int, float, double, byte
        }
    }
}
