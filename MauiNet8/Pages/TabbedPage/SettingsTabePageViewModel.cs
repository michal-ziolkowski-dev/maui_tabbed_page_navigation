using Microsoft.Maui.Controls;
using Prism.Ioc;
using Prism.Navigation;

namespace MauiNet8;

public class SettingsTabePageViewModel : BindableObject
{
    private INavigationService _navigationService;
    
    public SettingsTabePageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        // NavigationPage.SetHasNavigationBar(this, false);
        // BindingContext = ContainerLocator.Container.Resolve<SettingsTabePageViewModel>();
    }
}