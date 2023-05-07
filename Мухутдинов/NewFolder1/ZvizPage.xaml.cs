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
    /// Логика взаимодействия для ZvizPage.xaml
    /// </summary>
    public partial class ZvizPage : Page
    {
        public ZvizPage()
        {
            InitializeComponent();
            ReloadZviz();
        }

        public void ReloadZviz()
        {

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadZviz();
        }

        private void Logo4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/nmk_nsk?ysclid=lfme9rh178898835641");
        }

        private void Logo5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/NMKNeftekamsk");
        }

        private void Logo6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ok.ru/profile/585935963541");
        }
    }
}
