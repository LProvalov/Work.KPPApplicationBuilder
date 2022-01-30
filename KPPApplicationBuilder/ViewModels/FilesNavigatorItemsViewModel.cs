
namespace KPPApplicationBuilder.WPF.ViewModels
{
    public class FilesNavigatorItemsViewModel : ViewModelBase
    {
        public ListViewDragAndDropItemViewModel FilesNavigatorItemListingViewModel { get; }

        public FilesNavigatorItemsViewModel(ListViewDragAndDropItemViewModel filesNavigatorItemListingViewModel)
        {
            FilesNavigatorItemListingViewModel = filesNavigatorItemListingViewModel;
        }
    }
}
