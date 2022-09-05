using ProjektP4.Model;
using ProjektP4.Services;
using ProjektP4.Stores;
using ProjektP4.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProjektP4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Wypożycalnia _wypożycalnia;
        private readonly NavigationStore _navigationStore;
        public App()
        {
            _wypożycalnia = new Wypożycalnia("Projekt na p4");
            _navigationStore = new NavigationStore();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateLoginViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private RezerwViewModel CreateRezerwViewModel()
        {
            return new RezerwViewModel(_wypożycalnia, new NavigationService(_navigationStore, CreateHomeViewModel));
        }

        private HomeViewModel CreateHomeViewModel()
        {
            return new HomeViewModel(_wypożycalnia, new NavigationService(_navigationStore, CreateRezerwViewModel));
        }

        private LoginViewModel CreateLoginViewModel()
        {
            return new LoginViewModel(new NavigationService(_navigationStore, CreateHomeViewModel));
        }
    }
}
