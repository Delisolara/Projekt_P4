using ProjektP4.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Model
{
    public class LisatRezerwacji
    {
        private readonly List<Rezerwacja> _rezerwacja;
        public LisatRezerwacji()
        {
            _rezerwacja = new List<Rezerwacja>();
        }

        public IEnumerable<Rezerwacja> WszystkieRezerwacje()
        {
            return _rezerwacja;
        }

        public void DodajRezerwacja(Rezerwacja rezerwacja)
        {
            foreach (Rezerwacja sprawdzenieRezerwacji in _rezerwacja)
            {
                if (sprawdzenieRezerwacji.Conflicts(rezerwacja))
                { 
                    throw new ConfliktRezerwacji(sprawdzenieRezerwacji, rezerwacja); 
                }
            }

            _rezerwacja.Add(rezerwacja);
        }

        public void UsunRezerwacja(Rezerwacja rezerwacja)
        {
            _rezerwacja.Remove(rezerwacja);
        }
    }
}
