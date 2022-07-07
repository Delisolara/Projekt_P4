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
    public class WypozViewModel : ViewModelBase
    {
        //private string _search;
        //public string Search
        //{
        //    get { return _search; }
        //    set { _search = value; OnPropertyChanged(nameof(Search)); }
        //}

        //public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public WypozViewModel(NavigationStore navigationStore)
        {
            CancelCommand = new NavigatCommand<HomeViewModel>(new NavigationService<HomeViewModel>(navigationStore,
                () => new HomeViewModel(navigationStore)));
        }

    }
}
