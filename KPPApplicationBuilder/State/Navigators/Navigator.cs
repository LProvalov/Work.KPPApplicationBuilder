using KPPApplicationBuilder.WPF.Commands;
using KPPApplicationBuilder.WPF.Models;
using KPPApplicationBuilder.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace KPPApplicationBuilder.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }

            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        IDictionary<ViewType, ViewModelBase> _map;
        public Navigator(IDictionary<ViewType, ViewModelBase> map)
        {
            if (map == null)
            {
                throw new ArgumentNullException("Map");
            }
            _map = map;
        }

        public ViewModelBase MapViewByViewType(ViewType viewType)
        {
            if (_map.TryGetValue(viewType, out ViewModelBase viewModelBase))
            {
                return viewModelBase;
            }

            throw new Exception($"Can't map ViewType:({viewType.ToString()}) to ViewModel");
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
