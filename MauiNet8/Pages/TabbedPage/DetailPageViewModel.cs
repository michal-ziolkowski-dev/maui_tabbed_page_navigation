using Microsoft.Maui.Controls;
using Prism.Navigation;

namespace MauiNet8;

public class DetailPageViewModel : BindableObject
{
    private INavigationService _navigationService;
    
    public DetailPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;

    }
}