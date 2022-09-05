using ProjektP4.Exceptions;
using ProjektP4.Model;
using ProjektP4.Services;
using ProjektP4.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjektP4.Commands
{
    internal class WykonajRezerwCommand: CommandBase
    {
        private readonly RezerwViewModel _rezerwViewModel;
        private readonly Wypożycalnia _wypożycalnia;
        private readonly NavigationService _rezerwacjaViewNavigationService;

        public WykonajRezerwCommand(RezerwViewModel rezerwViewModel, Wypożycalnia wypożycalnia,
            NavigationService rezerwacjaViewNavigationService)
        {
            _rezerwViewModel = rezerwViewModel;
            _wypożycalnia = wypożycalnia;
            _rezerwacjaViewNavigationService = rezerwacjaViewNavigationService;
            _rezerwViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_rezerwViewModel.Rodzaj) &&
                !string.IsNullOrEmpty(_rezerwViewModel.Firma) &&
                base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Rezerwacja rezerwacja = new Rezerwacja(
                new Sprzęt(_rezerwViewModel.Rodzaj, _rezerwViewModel.Nazwa, _rezerwViewModel.Firma),
                _rezerwViewModel.Data_pocz,
                _rezerwViewModel.Data_kon);

            try 
            {
                _wypożycalnia.WyponajRezerwacje(rezerwacja);
                MessageBox.Show("Wybrany sprzęt został dla ciebie zarezerwowany!", "",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                _rezerwacjaViewNavigationService.Navigate();
            }
            catch (ConfliktRezerwacji)
            {
                MessageBox.Show("Ten sprzęt jest już wypożyczony!","Error", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(RezerwViewModel.Rodzaj) || 
                (e.PropertyName == nameof(RezerwViewModel.Firma)))
            {
                OnCanExecutedChanged();
            }
        }
    }
}
