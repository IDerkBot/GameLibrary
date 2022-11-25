using System;
using System.Linq;
using System.Windows;
using GameLibrary.DataAccessLayer;
using GameLibrary.Models;

namespace GameLibrary.Views.Windows;

public partial class AuthorizationWindow : Window
{
    public AuthorizationWindow()
    {
        InitializeComponent();
        Global.Database = new ApplicationDbContext();
    }

    private async void BtnLogin_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            var login = TbLogin.Text;
            var password = Crypt.Encrypt(PbPassword.Password);

            if (Global.Database.Users.ToList().Any(x => x.Login == login))
            {
                var user = Global.Database.Users.First(x => x.Login == login);
            
                if (user.Password == password)
                {
                    Hide();
                    Global.Access = user.Access;
                    new MainWindow().Show();
                    Close();
                }
                else MessageBox.Show("Пароль не верный");
            }
            else MessageBox.Show("Пользователь не найден");
        }
        catch (Exception exception)
        {
            MessageBox.Show($"{exception.Message}\n{exception.InnerException}");
        }
    }

    private void BtnRegistration_OnClick(object sender, RoutedEventArgs e)
    {
        Hide();
        new RegistrationWindow().ShowDialog();
        Show();
    }

    private void BtnClose_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}