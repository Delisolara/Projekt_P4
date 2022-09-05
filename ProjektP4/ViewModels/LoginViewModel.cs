using ProjektP4.Commands;
using ProjektP4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjektP4.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
        private string _login;
        public string Login
        {
            get { return _login; }
            set { _login = value; OnPropertyChanged(nameof(Login)); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel(NavigationService logowanieViewNavigationService)
        {
            LoginCommand = new LoginCommand(this,logowanieViewNavigationService);
        }
    }
}
