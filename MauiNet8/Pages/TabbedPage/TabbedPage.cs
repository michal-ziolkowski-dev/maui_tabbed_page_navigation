using Microsoft.Maui.Controls;
using Prism.Ioc;

namespace MauiNet8;

public class TaabbedPage : TabbedPage
{
    private TaabbedPageViewModel? ViewModel => BindingContext as TaabbedPageViewModel;
    
    public TaabbedPage()
    {
        BindingContext = ContainerLocator.Container.Resolve<TaabbedPageViewModel>();
        NavigationPage.SetHasNavigationBar(this, false);
         InitTabs();
    }

    private void InitTabs()
    {
        if (ViewModel == null)
        {
            return;
        }

        var tabaPageA = new NavigationPage(new HomeDashboardTabePage()){Title = "Home"};
        Children.Add(tabaPageA);

        var tabaPageB = new NavigationPage(new SettingsTabPage()){Title = "Settings"};
        Children.Add(tabaPageB);
        
    }
}