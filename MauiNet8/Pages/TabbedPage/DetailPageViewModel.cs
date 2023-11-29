using System.Windows.Input;
using Microsoft.Maui.Controls;
using Prism.Navigation;

namespace MauiNet8;

public class DetailPageViewModel : BindableObject
{
    private INavigationService _navigationService;
    
    public ICommand OnNextClick { get; set; }
    
    public DetailPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        OnNextClick = new Command(()=> _navigationService.NavigateAsync(nameof(DetailPage)));
    }
}