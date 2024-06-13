using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;


namespace ExpansionListReproduce.ViewModels
{
    public partial class ListItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _text1;

        [ObservableProperty]
        private string? _text2;
        public ObservableCollection<ControlViewModel> Items { get; } = new ObservableCollection<ControlViewModel>();
        public ObservableCollection<DetailsViewModel> Details { get; private set; } = new ObservableCollection<DetailsViewModel>();

        [ObservableProperty]
        public bool _showExpandedView;
        
        [ObservableProperty]
        public bool _visible;

        public bool ExpandList => Items.Count > 0 && Details.Count > 0;

        [RelayCommand]
        private Task ItemTouch()
        {
            ShowExpandedView = !ShowExpandedView && Items.Count > 0;
            return Task.CompletedTask;
        }

        [RelayCommand]
        private Task Expand()
        {
            ShowExpandedView = !ShowExpandedView && Items.Count > 0;
            return Task.CompletedTask;
        }
        
        [RelayCommand]
        public void Toggle()
        {
            Visible = !Visible;
        }
    }
}
