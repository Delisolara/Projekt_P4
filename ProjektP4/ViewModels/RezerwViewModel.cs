using ProjektP4.Commands;
using ProjektP4.Model;
using ProjektP4.Services;
using ProjektP4.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjektP4.ViewModels
{
    public class RezerwViewModel: ViewModelBase
    {
        private string _rodzaj;
        public string Rodzaj
        {
            get { return _rodzaj; }
            set
            {
                _rodzaj = value;
                OnPropertyChanged(nameof(Rodzaj));
            }
        }

        private string _nazwa;
        public string Nazwa
        {
            get { return _nazwa; }
            set
            {
                _nazwa = value;
                OnPropertyChanged(nameof(Nazwa));
            }
        }

        private string _firma;
        public string Firma
        {
            get { return _firma; }
            set
            {
                _firma = value;
                OnPropertyChanged(nameof(Firma));
            }
        }

        private DateTime _data_pocz = new DateTime(2022, 8, 1);
        public DateTime Data_pocz
        {
            get { return _data_pocz; }
            set
            {
                _data_pocz = value;
                OnPropertyChanged(nameof(Data_pocz));
            }
        }

        private DateTime _data_kon = new DateTime(2022, 8, 3);
        public DateTime Data_kon
        {
            get { return _data_kon; }
            set
            {
                _data_kon = value;
                OnPropertyChanged(nameof(Data_kon));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public RezerwViewModel(Wypożycalnia wypożycalnia, NavigationService rezerwacjaViewNavigationService)
        {
            SubmitCommand = new WykonajRezerwCommand(this, wypożycalnia, rezerwacjaViewNavigationService);
            CancelCommand = new NavigateCommand(rezerwacjaViewNavigationService);
        }
    }
}
