using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Мухутдинов.NewFolder1;

namespace Мухутдинов
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var password = GetPassword();
            if (string.IsNullOrWhiteSpace(LoginField.Text))
            {
                MessageBox.Show("Поле логин не должно быть пустым!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(GetPassword()))
            {
                MessageBox.Show("Поле пароль не должно быть пустым!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                App.currentUser = (from user in App.DB.Biblioteka where user.Login == LoginField.Text && user.Password == password select user).First();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не найдено пользователя с такими логином и паролем!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MessageBox
                .Show(
                    "Успешный вход!",
                    "Успех!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );
            App.mainWindow = new MainWindow();
            App.mainWindow.Show();
            Close();
        }

        private void chkbxShowPass_Click(object sender, RoutedEventArgs e)
        {
            if (chkbxShowPass.IsChecked.HasValue && chkbxShowPass.IsChecked.Value)
            {
                PasswordField.Visibility = Visibility.Collapsed;
                PasswordShowField.Visibility = Visibility.Visible;
                PasswordShowField.Text = PasswordField.Password;
            }
            else
            {
                PasswordField.Visibility = Visibility.Visible;
                PasswordShowField.Visibility = Visibility.Collapsed;
                PasswordField.Password = PasswordShowField.Text;
            }
        }

        private String GetPassword()
        {
            if (chkbxShowPass.IsChecked.HasValue && chkbxShowPass.IsChecked.Value)
            {
                return PasswordShowField.Text;
            }
            else
            {
                return PasswordField.Password;
            }
        }

        private void OpenHelpButton_Click(object sender, RoutedEventArgs e)
        {
            var currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

            System.Diagnostics.Process.Start("explorer", currentDirectory + @"help\Курс 4.html");
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {

           
        }
    }
}