using Assigment_maui.MVVM.ViewModels;

namespace Assigment_maui.MVVM.Views;

public partial class AddPage : ContentPage
{
	public AddPage(AddViewModel addViewModel)
	{
		InitializeComponent();
		BindingContext = addViewModel;
	}
}