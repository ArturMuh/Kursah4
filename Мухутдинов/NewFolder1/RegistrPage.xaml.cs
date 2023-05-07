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

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для RegistrPage.xaml
    /// </summary>
    public partial class RegistrPage : Page
    {
        public RegistrPage()
        {
            InitializeComponent();
            ReloadRegistr();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (
                Login.Text != "" &&
                Password.Text != "" &&
                FIO.Text != "")
            {
                try
                {
                    var User = new Biblioteka();
                    User.Login = Login.Text;
                    User.Password = Password.Text;
                    User.FIO = FIO.Text;
                    App.DB.Biblioteka.Add(User);
                    App.DB.SaveChanges();
                    MessageBox.Show("Пользователь добавлен");
                     Window1 Window1 = new Window1();
                    Window1.Show();
                    


                }
                catch
                {
                    MessageBox.Show("Ошибка авторизации");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadRegistr();
        }

        private void ReloadRegistr()
        {
        }
    }
}
