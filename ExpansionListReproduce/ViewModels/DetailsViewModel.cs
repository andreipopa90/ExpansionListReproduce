using CommunityToolkit.Mvvm.ComponentModel;

namespace ExpansionListReproduce.ViewModels;

public partial class DetailsViewModel : ObservableObject
{
	[ObservableProperty] public string _title;
	[ObservableProperty] public string _text;
	[ObservableProperty] public Image _image;
	[ObservableProperty] public string _subText;
	
}