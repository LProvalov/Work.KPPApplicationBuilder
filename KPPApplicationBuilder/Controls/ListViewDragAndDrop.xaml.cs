using KPPApplicationBuilder.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KPPApplicationBuilder.WPF.Controls
{
    /// <summary>
    /// Interaction logic for ListViewDragAndDrop.xaml
    /// </summary>
    public partial class ListViewDragAndDrop : UserControl
    {
        private readonly ObservableCollection<ListViewDragAndDropItemViewModel> _listItemViewModels;
        public IEnumerable<ListViewDragAndDropItemViewModel> ListItemViewModels => _listItemViewModels;

        public ListViewDragAndDrop()
        {
            InitializeComponent();
            _listItemViewModels = new ObservableCollection<ListViewDragAndDropItemViewModel>();
        }

        public void AddOrderItem(ListViewDragAndDropItemViewModel item)
        {
            if (!_listItemViewModels.Contains(item))
            {
                _listItemViewModels.Add(item);
            }
        }

        public void InsertOrderItem(ListViewDragAndDropItemViewModel insertedListItem, ListViewDragAndDropItemViewModel targetListItem)
        {
            if (insertedListItem == targetListItem)
            {
                return;
            }

            int oldIndex = _listItemViewModels.IndexOf(insertedListItem);
            int nextIndex = _listItemViewModels.IndexOf(targetListItem);

            if (oldIndex != -1 && nextIndex != -1)
            {
                _listItemViewModels.Move(oldIndex, nextIndex);
            }
        }

        public void RemoveOrderItem(ListViewDragAndDropItemViewModel item)
        {
            _listItemViewModels.Remove(item);
        }
    }
}
