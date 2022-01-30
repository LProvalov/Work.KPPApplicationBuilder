using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPPApplicationBuilder.WPF.ViewModels
{
    public class AssemblyBuilderViewModel : ViewModelBase
    {
        public OrderItemsViewModel OrderItemsViewModel { get; }
        public FilesNavigatorItemsViewModel FilesNavigatorItemsViewModel { get; }

        public AssemblyBuilderViewModel(OrderItemsViewModel orderItemsViewModel, FilesNavigatorItemsViewModel filesNavigatorItemsViewModel)
        {
            OrderItemsViewModel = orderItemsViewModel;
            FilesNavigatorItemsViewModel = filesNavigatorItemsViewModel;
        }
    }
}
