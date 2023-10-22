using Assigment_maui.MVVM.ViewModels;

namespace Assigment_maui.MVVM.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;

            
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Window.MinimumHeight = 600;
            this.Window.MinimumWidth = 350;
        }
    }
}