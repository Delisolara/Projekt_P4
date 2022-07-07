using Projekt.WPF.Stores;
using Projekt.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.WPF.Commands
{
    public class NavigatCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationStore;

        public NavigatCommand(NavigationService<TViewModel> navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.Navigate();
        }
    }
}
