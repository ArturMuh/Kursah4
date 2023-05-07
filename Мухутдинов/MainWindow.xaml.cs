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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AvtoryPage Avtory;
        public KnigiPage Knigi;
        public IzdatelstvoPage Izdatelstvo;
        public RazdeliPage Razdeli;
        public ZakazPage Zakaz;
        public PostavchikPage Postavchik;
        public VidizdaniePage Vidizdanie;
        public ZvizPage Zviz;
        public ZaivkaWindow Zaivka;
        public ZaivkaknigPage Zaivkaknig;
        public MainWindow()
        {
            InitializeComponent();
            Avtory = new AvtoryPage();
            Knigi = new KnigiPage();
            Izdatelstvo = new IzdatelstvoPage();
            Razdeli = new RazdeliPage();
            Zakaz = new ZakazPage();
            Postavchik= new PostavchikPage();
            Vidizdanie = new VidizdaniePage();
            Zviz = new ZvizPage();
            Zaivka = new ZaivkaWindow();
            Zaivkaknig = new ZaivkaknigPage();

            App.hearder = new NewFolder1.HearderPage();
            HeaderFrame.Navigate(App.hearder);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно закрыть программу?", "Подтверждение", MessageBoxButton.YesNo,
                 MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new AvtoryPage();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Main.Content = new KnigiPage();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Мухутдинов Артур Ришатович Тема: Учет поступление книг в библиотеку", "Сведения о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Main.Content = new IzdatelstvoPage();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Main.Content = new RazdeliPage();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Main.Content = new ZakazPage();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            Main.Content = new PostavchikPage();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
           
                Window1 Window1 = new Window1();
                Window1.Show();
                this.Close();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            Main.Content = new VidizdaniePage();
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            Main.Content = new RegistrPage();
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            Main.Content = new ZvizPage();
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            ZaivkaWindow Zaivka = new ZaivkaWindow();
            Zaivka.Show();
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            Main.Content = new ZaivkaknigPage();
        }
    }
}
