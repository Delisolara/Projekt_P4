using Projekt.WPF.Commands;
using Projekt.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateWypozCommand { get; }
        //public ICommand DeleteCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateWypozCommand = new NavigatCommand<WypozViewModel>(new NavigationService<WypozViewModel>(navigationStore,
                () => new WypozViewModel(navigationStore)));
        }
    }
}
