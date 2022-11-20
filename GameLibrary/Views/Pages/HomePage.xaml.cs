using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Views.Pages;

public partial class HomePage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void HomePage_OnLoaded(object sender, RoutedEventArgs e)
    {
        var count = Global.Database.Apps.Count();
        var random = new Random();
        var apps = new List<Models.Entity.App>();

        for (var i = 0; i < 20; i++)
        {
            apps.Add(await Global.Database.Apps.FirstAsync(x => x.Id == random.Next(1, count)));
        }

        LvApps.ItemsSource = apps;
    }
}