using Assigment_maui.MVVM.ViewModels;

namespace Assigment_maui.MVVM.Views;

public partial class EditPage : ContentPage
{
	public EditPage(EditViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;



	}
}