using System;
using Microsoft.Maui.Controls;
using Prism.Ioc;

namespace MauiNet8;

public partial class HomeDashboardTabePage : ContentPage
{
    public HomeDashboardTabePage()
    {
        InitializeComponent();
        
        BindingContext = ContainerLocator.Container.Resolve<HomeDashboardTabeViewModel>();
        NavigationPage.SetHasNavigationBar(this, false);
    }
}