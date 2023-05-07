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
    /// Логика взаимодействия для ZaivkaknigPage.xaml
    /// </summary>
    public partial class ZaivkaknigPage : Page
    {
        public ZaivkaknigPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var helper = new WordHelper("blankzakaza.doc");

            var items = new Dictionary<string, string>
            {
                {"<Avtory>", textBox1.Text },
                {"<Nazvanieknigi>", textBox2.Text },
                {"<Godizdanie>", textBox3.Text },
                {"<Mesto>", textBox4.Text },
                {"<Tom>", textBox5.Text },
                {"<Stranisa>", textBox6.Text },
                {"<FIO>", textBox7.Text },
                {"<Email>", textBox8.Text },
            };
            helper.Process(items);
            MessageBox.Show("Заявка сформирована на рабочем столе");
        }
    }
}
