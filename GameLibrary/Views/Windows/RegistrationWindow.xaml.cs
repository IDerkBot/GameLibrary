using System.Windows;
using GameLibrary.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Views.Windows;

public partial class RegistrationWindow
{
    public RegistrationWindow()
    {
        InitializeComponent();
    }

    private void BtnBack_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private async void BtnRegistration_OnClick(object sender, RoutedEventArgs e)
    {
        var login = TbLogin.Text;
        var password = PbPassword.Password;
        var confirmPassword = PbConfirmPassword.Password;
        if (await Global.Database.Users.AnyAsync(x => x.Login == login))
            MessageBox.Show("Такой пользователь уже существует!");
        else
        {
            if (password == confirmPassword)
            {
                await Global.Database.Users.AddAsync(new User
                {
                    Login = login,
                    Password = password,
                    Access = 0
                });
                await Global.Database.SaveChangesAsync();
                MessageBox.Show("Вы успешно зарегистрированы!");
                Close();
            }
            else MessageBox.Show("Пароли не совпадают");
        }
    }
}