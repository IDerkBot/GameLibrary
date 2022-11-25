using System;
using System.Linq;
using System.Windows;
using GameLibrary.Models.Utilities.Image;

namespace GameLibrary.Views.Windows;

public partial class AddNewAppWindow : Window
{
    private Models.Entity.App _currentApplication;
    public AddNewAppWindow()
    {
        InitializeComponent();
        _currentApplication = new Models.Entity.App();
        CbTypeApp.ItemsSource = Global.Database.TypeApps.ToList();
        CbPlatform.ItemsSource = Global.Database.Platforms.ToList();
        DataContext = _currentApplication;
    }

    private void MainImage_OnDrop(object sender, DragEventArgs e)
    {
        if (e.Data.GetData(DataFormats.FileDrop) is not string[] filePath) return;
        
        var source = ImageManager.CroppedToBitmapImage(filePath[0]);
        _currentApplication.Image = ImageManager.CroppedToBytes(source);
        //var ms = new MemoryStream(_currentType.Image);
        //var source = new BitmapImage();
        //source.BeginInit();
        //source.StreamSource = ms;
        //source.EndInit();
        MainImage.Source = source;

    }

    private async void BtnAdd_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            await Global.Database.Apps.AddAsync(_currentApplication);
            await Global.Database.SaveChangesAsync();
            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show($"{exception.Message}\n{exception.InnerException}");
        }
    }
}