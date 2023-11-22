using System.Windows.Input;
using Microsoft.Maui.Controls;
using Prism.Navigation;

namespace MauiNet8;

public class MainPageViewModel : BindableObject
{
    private INavigationService _navigationService;
    public ICommand OnTabClick { get; set; }
    
    public MainPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        OnTabClick = new Command(()=> _navigationService.NavigateAsync(nameof(TaabbedPage)));
    }
}