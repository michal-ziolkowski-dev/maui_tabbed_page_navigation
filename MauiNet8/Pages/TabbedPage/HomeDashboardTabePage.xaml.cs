using Microsoft.Maui.Controls;

namespace MauiNet8;

public partial class HomeDashboardTabePage : ContentPage
{
    public HomeDashboardTabePage()
    {
        InitializeComponent();
        
        NavigationPage.SetHasNavigationBar(this, false);
    }
}