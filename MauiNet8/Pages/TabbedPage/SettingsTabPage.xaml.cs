using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiNet8;

public partial class SettingsTabPage : ContentPage
{
    public SettingsTabPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
}