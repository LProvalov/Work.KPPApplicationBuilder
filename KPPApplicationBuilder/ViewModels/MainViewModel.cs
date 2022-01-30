using KPPApplicationBuilder.WPF.State.Navigators;
using System.Collections.Generic;

namespace KPPApplicationBuilder.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; };


        public MainViewModel()
        {
            var mapViewModel = new Dictionary<ViewType, ViewModelBase>();

            var orderItemsViewModel = new OrderItemsViewModel();
            var filesNavigatorItemsViewModel = new FilesNavigatorItemsViewModel();
            var assemblyBuilderViewModel = new AssemblyBuilderViewModel(orderItemsViewModel, filesNavigatorItemsViewModel);
            mapViewModel.Add(ViewType.AssemblyBuilder, assemblyBuilderViewModel);

            var settingsViewModel = new SettingsViewModel();
            mapViewModel.Add(ViewType.Settings, settingsViewModel);

            Navigator = new Navigator(mapViewModel);
        }
    }
}
