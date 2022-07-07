using Projekt.WPF.Stores;
using Projekt.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projekt.WPF.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly NavigationService<HomeViewModel> _navigationService;


        public LoginCommand(LoginViewModel loginViewModel, NavigationService<HomeViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            //MessageBox.Show("Bravo! Zalogowałaś się i wyswietliłaś tą wiadomość!");
            _navigationService.Navigate();
        }

    }
}
