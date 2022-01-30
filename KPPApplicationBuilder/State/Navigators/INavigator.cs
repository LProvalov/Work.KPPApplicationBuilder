using KPPApplicationBuilder.WPF.ViewModels;
using System.Windows.Input;

namespace KPPApplicationBuilder.WPF.State.Navigators
{
    public enum ViewType
    {
        AssemblyBuilder,
        Settings
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ViewModelBase MapViewByViewType(ViewType viewType);
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
