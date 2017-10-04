using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRodzinny
{
    class Dziecko: Czlowiek
    {
        public Dziecko(bool czyjestsamodzielne, string imie):base(imie)
        {
            this.czyjestsamodzielne = czyjestsamodzielne;
        }
        public Dziecko(bool czyjestsamodzielne, int wzrost, string kolor_skory, string nazwisko, string imie):base(wzrost, kolor_skory, nazwisko, imie)
        {
            this.czyjestsamodzielne = czyjestsamodzielne;
        }
        bool? czyjestsamodzielne; //zmienna nulowalna czyli nic do niej nie zostanie przypisane

        void rosnie ()
        {

        }
        public override string ToString()
        {
            string informacjODzieciach = base.ToString()+"\nCzy jest samodzielne?: "+czyjestsamodzielne;
            return informacjODzieciach;
        }


    }
}
