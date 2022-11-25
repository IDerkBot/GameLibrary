using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GameLibrary.Views.Windows;
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

        if(count == 0) return;

        apps.AddRange(Global.Database.Apps.ToList());

        LvApps.ItemsSource = apps;
    }

    private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
    {
        new AddNewAppWindow().ShowDialog();
    }

    private void BtnDownload_OnClick(object sender, RoutedEventArgs e)
    {
        if ((sender as Button)?.DataContext is Models.Entity.App app)
        {
            var wc = new WebClient();
            var name = app.Link.Split("//")[^1].Substring(0, app.Link.Split("//")[^1].Length - 4);
            var path = $"C://Users//{Environment.UserName}//{Environment.SpecialFolder.Desktop}//{app.Link.Split("//")[^1]}";
            if(File.Exists(path))
                wc.DownloadFile(new Uri(app.Link), $"C://Users//{Environment.UserName}//{Environment.SpecialFolder.Desktop}//{name}(1).exe");
            wc.DownloadFile(new Uri(app.Link), $"C://Users//{Environment.UserName}//{Environment.SpecialFolder.Desktop}//{name}.exe");
        }
    }
}