using ProjektP4.Model;
using ProjektP4.Services;
using ProjektP4.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly NavigationService _logowanieViewNavigationService;
        private readonly LoginViewModel _loginViewModel;

        public LoginCommand(LoginViewModel loginViewMode, NavigationService logowanieViewNavigationService)
        {
            _loginViewModel = loginViewMode;
            _logowanieViewNavigationService = logowanieViewNavigationService;
            _loginViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_loginViewModel.Login) &&
               !string.IsNullOrEmpty(_loginViewModel.Password) &&
               base.CanExecute(parameter);
        }


        public override void Execute(object? parameter)
        {
            Klienci klienci = new Klienci(_loginViewModel.Login, _loginViewModel.Password);
            _logowanieViewNavigationService.Navigate();
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(LoginViewModel.Login) ||
                (e.PropertyName == nameof(LoginViewModel.Password)))
            {
                OnCanExecutedChanged();
            }
        }
    }
}
