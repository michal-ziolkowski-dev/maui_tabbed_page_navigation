using Microsoft.Maui.Controls;
using Prism.Ioc;

namespace MauiNet8;

public partial class DetailPage : ContentPage
{
    public DetailPage()
    {
        InitializeComponent();
        BindingContext = ContainerLocator.Container.Resolve<DetailPageViewModel>();
    }
}