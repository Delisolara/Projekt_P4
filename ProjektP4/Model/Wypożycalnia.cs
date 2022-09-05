using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Model
{
    public class Wypożycalnia
    {
        private readonly LisatRezerwacji _lisatRezerwacji;
        public string Nazwa { get; }

        public Wypożycalnia(string nazwa)
        {
            Nazwa = nazwa;
            _lisatRezerwacji = new LisatRezerwacji();
        }

        public IEnumerable<Rezerwacja> WszystkieRezerwacje()
        {
            return _lisatRezerwacji.WszystkieRezerwacje();
        }

        public void WyponajRezerwacje(Rezerwacja rezerwacja)
        {
            _lisatRezerwacji.DodajRezerwacja(rezerwacja);
        }

        public void RzerygnujZRezerwacje(Rezerwacja rezerwacja)
        {
            _lisatRezerwacji.UsunRezerwacja(rezerwacja);
        }

    }
}
