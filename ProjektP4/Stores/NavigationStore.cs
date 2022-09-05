using ProjektP4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public event Action CurrentViewModelChanged;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set 
            { 
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            } 
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
