using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Prism.Commands;
using Prism.Navigation;

namespace MauiNet8;

public class TaabbedPageViewModel : BindableObject
{
    private INavigationService _navigationService;
    
    public TaabbedPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }
}