using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpansionListReproduce.ViewModels
{
    public partial class ExpandableItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _name;

        public ExpandableItemViewModel()
        {
            Name = "New Name";
        }
    }
}
