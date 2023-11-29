

using System;
using CommunityToolkit.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Prism;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Navigation;

namespace MauiNet8;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UsePrism(prism =>
                prism.ConfigureServices(services =>
                {
                    services.RegisterForNavigation<NavigationPage>();
                    services.RegisterForNavigation<MainPage, MainPageViewModel>();
                    
                    services.RegisterForNavigation<TaabbedPage, TaabbedPageViewModel>();
                    services.RegisterForNavigation<HomeDashboardTabePage, HomeDashboardTabeViewModel>();
                    services.RegisterForNavigation<SettingsTabPage, SettingsTabePageViewModel>();
                    services.RegisterForNavigation<DetailPage, DetailPageViewModel>();
                    
                    ViewModelLocationProvider.Register<MainPage, MainPageViewModel>();
                    ViewModelLocationProvider.Register<TaabbedPage, TaabbedPageViewModel>();
                    ViewModelLocationProvider.Register<HomeDashboardTabePage, HomeDashboardTabeViewModel>();
                    ViewModelLocationProvider.Register<SettingsTabPage, SettingsTabePageViewModel>();
                    ViewModelLocationProvider.Register<DetailPage, DetailPageViewModel>();
                })
                .OnAppStart(async (container, navigationService) => {
                    await navigationService.NavigateAsync("/NavigationPage/MainPage");
                }));

        return builder.Build();
    }

    private static void HandleNavigationError(Exception obj)
    {
        System.Diagnostics.Debug.WriteLine(obj.ToString());
    }
}