using KPPApplicationBuilder.WPF.State.Navigators;
using KPPApplicationBuilder.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace KPPApplicationBuilder.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            if (navigator == null) throw new ArgumentNullException("Navigator");
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                _navigator.CurrentViewModel = _navigator.MapViewByViewType(viewType);
            }
        }
    }
}
