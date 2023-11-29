using Microsoft.Maui.Controls;
using Prism.Ioc;

namespace MauiNet8;

public class TaabbedPage : TabbedPage
{
    public TaabbedPage()
    {
        NavigationPage.SetHasNavigationBar(this, false);
        InitTabs();
    }

    private void InitTabs()
    {
        var tabaPageA = new NavigationPage(new HomeDashboardTabePage()){Title = "Home"};
        Children.Add(tabaPageA);

        var tabaPageB = new NavigationPage(new SettingsTabPage()){Title = "Settings"};
        Children.Add(tabaPageB);
        
    }
}