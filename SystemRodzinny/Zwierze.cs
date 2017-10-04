using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRodzinny
{
    abstract class Zwierze : CzlonekRodziny
    {
        public Zwierze(string imie):base(imie)
        { 
        }
        string umaszczenie;
        int wysokoscwklebie;
        string rodowod;
        bool oczyjestoswojony;
        bool czymapysk;
        bool czymalapy;

        void glaskanie()
        {

        }

        EventHandler reagujenakomendy; //przechwytywacz metody; zdarzenie reagujenakomendy może wywolac okreslone metody


    }
}
