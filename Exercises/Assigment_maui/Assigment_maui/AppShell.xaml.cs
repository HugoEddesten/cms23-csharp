using Assigment_maui.MVVM.Views;

namespace Assigment_maui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registers the routing of all pages
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));
        Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
        Routing.RegisterRoute(nameof(FavouritesPage), typeof(FavouritesPage));

    }
}