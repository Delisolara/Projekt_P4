using ProjektP4.Commands;
using ProjektP4.Model;
using ProjektP4.Services;
using ProjektP4.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjektP4.ViewModels
{
    public class HomeViewModel: ViewModelBase
    {
        private readonly ObservableCollection<ListaRezerwViewModel> _rezerwacja;
        public IEnumerable<ListaRezerwViewModel> Rezerwacja => _rezerwacja;

        public ICommand NavigateRezerwCommand { get; }

        private readonly Wypożycalnia _wypożycalnia;

        //public ICommand DeleteCommand { get; }

        public HomeViewModel(Wypożycalnia wypożycalnia, NavigationService wyoknajRezerwacjeNavigationServices)
        {
            NavigateRezerwCommand = new NavigateCommand(wyoknajRezerwacjeNavigationServices);

            _wypożycalnia = wypożycalnia;
            _rezerwacja = new ObservableCollection<ListaRezerwViewModel>();

            AktualizujRezerwacje();
        }

        private void AktualizujRezerwacje()
        {
            _rezerwacja.Clear();

            foreach (Rezerwacja rezerwacja in _wypożycalnia.WszystkieRezerwacje())
            {
                ListaRezerwViewModel listaRezerwViewModel = new ListaRezerwViewModel(rezerwacja);
                _rezerwacja.Add(listaRezerwViewModel);
            }
        }
    }
}
