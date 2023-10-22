using Assigment_maui.MVVM.ViewModels;
using Assignment_maui.MVVM.Models;

namespace Assigment_maui.MVVM.Views;



public partial class DetailsPage : ContentPage
{
    public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

	}
   
}