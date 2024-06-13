using System.Collections.ObjectModel;

namespace ExpansionListReproduce.ViewModels
{
    public class ListViewModel
    {
        public ListViewModel()
        {
            Items = new ObservableCollection<ListItemViewModel>();

            for (int i=1;i<=10;i++)
            {
                Items.Add(new ListItemViewModel()
                {
                    Text1 = $"Item #{i}",
                    Text2 = $"Hello this is row number {i}.",
                    ShowExpandedView = i == 1
                });
            }

            Items[0].Items.Add(new ControlViewModel() { ControlName = "a" });
            Items[0].Items.Add(new ControlViewModel() { ControlName = "b" });
            Items[2].Items.Add(new ControlViewModel() { ControlName = "c" });
            Items[4].Items.Add(new ControlViewModel() { ControlName = "d" });
            Items[4].Items.Add(new ControlViewModel() { ControlName = "e" });
            Items[4].Items.Add(new ControlViewModel() { ControlName = "f" });
            Items[6].Items.Add(new ControlViewModel() { ControlName = "g" });
            Items[6].Items.Add(new ControlViewModel() { ControlName = "h" });
            Items[6].Items.Add(new ControlViewModel() { ControlName = "i" });
            Items[6].Items.Add(new ControlViewModel() { ControlName = "j" });
            Items[6].Items.Add(new ControlViewModel() { ControlName = "k" });
            
            Items[0].Details.Add(new DetailsViewModel() { Title = "title", Text = "text", SubText = "subtext"});
            Items[2].Details.Add(new DetailsViewModel() { Title = "title", Text = "text", SubText = "subtext"});
            Items[4].Details.Add(new DetailsViewModel() { Title = "title", Text = "text", SubText = "subtext"});
            Items[6].Details.Add(new DetailsViewModel() { Title = "title", Text = "text", SubText = "subtext"});
        }

        public ObservableCollection<ListItemViewModel> Items { get; private set; }
    }
}
