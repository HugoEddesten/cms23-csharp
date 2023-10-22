using Assigment_maui.MVVM.ViewModels;

namespace Assigment_maui.MVVM.Views;

public partial class FavouritesPage : ContentPage
{
	public FavouritesPage(FavouritesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}