using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GameLibrary.Views.Pages;

public partial class ProgramsPage : Page
{
    public ProgramsPage()
    {
        InitializeComponent();
        
        var count = Global.Database.Apps.Count();
        var apps = new List<Models.Entity.App>();
        if(count == 0) return;
        apps.AddRange(Global.Database.Apps.Where(x => x.TypeId == 3).ToList());
        LvApps.ItemsSource = apps;
    }

    private void BtnDownload_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
}