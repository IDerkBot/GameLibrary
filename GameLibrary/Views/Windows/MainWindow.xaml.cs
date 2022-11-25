using System.ComponentModel;
using System.Windows;
using GameLibrary.Views.Pages;

namespace GameLibrary.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _fullSize;
        
        public MainWindow()
        {
            InitializeComponent();
            ManagerPage.Frame = MainFrame;
            ManagerPage.Frame.Navigate(new HomePage());
        }

        private void BtnBars_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnHome_OnClick(object sender, RoutedEventArgs e)
        {
            ManagerPage.Frame.Navigate(new HomePage());
        }

        private void BtnGames_OnClick(object sender, RoutedEventArgs e)
        {
            ManagerPage.Frame.Navigate(new GamesPage());
        }

        private void BtnPrograms_OnClick(object sender, RoutedEventArgs e)
        {
            ManagerPage.Frame.Navigate(new ProgramsPage());
        }

        private void BtnAccount_OnClick(object sender, RoutedEventArgs e)
        {
            ManagerPage.Frame.Navigate(new ProfilePage());
        }

        private void BtnSettings_OnClick(object sender, RoutedEventArgs e)
        {
            ManagerPage.Frame.Navigate(new SettingsPage());
        }

        private void BtnExit_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnResize_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = _fullSize ? WindowState.Normal : WindowState.Maximized;
            _fullSize = !_fullSize;
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}