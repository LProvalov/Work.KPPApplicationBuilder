
namespace KPPApplicationBuilder.WPF.ViewModels
{
    public class OrderItemsViewModel : ViewModelBase
    {
        public ListViewDragAndDropItemViewModel OrderItemListingViewModel { get; }

        public OrderItemsViewModel(ListViewDragAndDropItemViewModel orderItemListingViewModel)
        {
            OrderItemListingViewModel = orderItemListingViewModel;
        }
    }
}
