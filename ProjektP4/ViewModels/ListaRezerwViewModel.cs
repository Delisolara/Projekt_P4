using ProjektP4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.ViewModels
{
    public class ListaRezerwViewModel : ViewModelBase
    {
        private readonly Rezerwacja _rezerwacja;

        //public STRING KlienciID => _wypożyczalnia.KlienciID.ToString();
        public string? Sprzęt => _rezerwacja.Sprzęt.ToString();
        public string Data_wypożyczenia => _rezerwacja.Data_wypożyczenia.ToString("d");
        public string Data_oddania => _rezerwacja.Data_oddania.ToString("d");

        public ListaRezerwViewModel(Rezerwacja rezerwacja)
        {
            _rezerwacja = rezerwacja;
        }
    }
}
