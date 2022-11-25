using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GameLibrary.Views.Pages;

public partial class GamesPage : Page
{
    public GamesPage()
    {
        InitializeComponent();
        
        var count = Global.Database.Apps.Count();
        var apps = new List<Models.Entity.App>();
        if(count == 0) return;
        apps.AddRange(Global.Database.Apps.Where(x => x.TypeId == 1).ToList());
        LvApps.ItemsSource = apps;

        // if (Global.Access >= 3) BtnEdit.Visibility = Visibility.Visible;
    }

    private void BtnDownload_OnClick(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}