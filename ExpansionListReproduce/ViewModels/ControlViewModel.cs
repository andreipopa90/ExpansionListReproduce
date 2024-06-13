using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExpansionListReproduce.ViewModels;
using System.Collections.ObjectModel;


namespace ExpansionListReproduce.ViewModels
{
    public partial class ControlViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _controlName;

        public ObservableCollection<ExpandableItemViewModel> Items { get; } = [];

        public ControlViewModel()
        {
            Items.Add(new ExpandableItemViewModel());
            Items.Add(new ExpandableItemViewModel());
            Items.Add(new ExpandableItemViewModel());
            Items.Add(new ExpandableItemViewModel());
            Items.Add(new ExpandableItemViewModel());
            Items.Add(new ExpandableItemViewModel());
            Items.Add(new ExpandableItemViewModel());
        }
    }
}
