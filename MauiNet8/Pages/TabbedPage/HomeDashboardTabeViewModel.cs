using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Prism.Navigation;

namespace MauiNet8;

public class HomeDashboardTabeViewModel : BindableObject
{
    private INavigationService _navigationService;
    
    public ICommand OnNextClick { get; set; }
    
    public HomeDashboardTabeViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        NavigationPage.SetHasNavigationBar(this, false);
        OnNextClick = new Command(()=> _navigationService.NavigateAsync(nameof(DetailPage)));
    }
}