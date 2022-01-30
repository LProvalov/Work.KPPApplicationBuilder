namespace KPPApplicationBuilder.WPF.ViewModels
{
    public class ListViewDragAndDropItemViewModel : ViewModelBase
    {
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public ListViewDragAndDropItemViewModel(string description)
        {
            Description = description;
        }
    }
}
