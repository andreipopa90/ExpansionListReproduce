using ExpansionListReproduce.ViewModels;

namespace ExpansionListReproduce;

public partial class MainPage : ContentPage
{

	public MainPage(ListViewModel listViewModel)
	{
		BindingContext = listViewModel;
		InitializeComponent();
	}

	public void ExpansionDetails_Tapped(object sender, EventArgs e)
	{
		// This event handler is needed so the touch event for the item
		// is not fired when clicking in the expansion details pane.
	}
}