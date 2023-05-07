using Microsoft.Win32;
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
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для ZakazPage.xaml
    /// </summary>
    public partial class ZakazPage : System.Windows.Controls.Page
    {
        public ZakazPage()
        {
            InitializeComponent();
            ReloadZakaz();
            ReloadKnigi();
        }

        public delegate void RefreshList();
        public event RefreshList RefreshListEvent;
        public void ReloadKnigi()
        {
            comboboxLocality24.ItemsSource = App.DB.Knigi.ToList();
            comboboxLocality24.Items.Refresh();
        }

        public void ReloadZakaz()
        {
            var query = (from o in App.DB.Zakaz select o);

            if (!string.IsNullOrWhiteSpace(ZakazNameSearchField.Text))
            {
                var q = ZakazNameSearchField.Text;
                query = (from z in App.DB.Zakaz
                             where z.Nazvanie_knigi.Contains(q)
                         select z);
            }
            ZakazDataGrid.ItemsSource = query.ToList();
            ZakazDataGrid.Items.Refresh();
        }

        private void ZakazSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadZakaz();
        }

        private void ZakazDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            Мухутдинов.NewFolder1.Zakaz Grid_Row = ZakazDataGrid.SelectedItem as Мухутдинов.NewFolder1.Zakaz;
            if (ZakazDataGrid.SelectedItem is Мухутдинов.NewFolder1.Zakaz)
            {
                IDzakazayaField.Text = Grid_Row.ID_zakaza.ToString();
                comboboxLocality24.Text = Grid_Row.Nazvanie_knigi.ToString();
                DatezakazayaField.Text = Grid_Row.Date_zakaza.ToString();
                PriceField.Text = Grid_Row.Price.ToString();
                KolichestvoField.Text = Grid_Row.Kolichestvo.ToString();




            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "Файл *.xls | *.xls",
                ValidateNames = true
            };

            var result = sfd.ShowDialog();
            if (result == true)
            {
                Microsoft.Office.Interop.Excel.Application xlApp;
                Workbook xlWorkBook;
                Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //xlWorkSheet.Cells[1, 1] = "http://csharp.net-informations.com";
                xlWorkSheet.Cells[1, 1] = "ID Заказа";
                xlWorkSheet.Cells[1, 2] = "Название книги";
                xlWorkSheet.Cells[1, 3] = "Дата заказа";
                xlWorkSheet.Cells[1, 4] = "Цена";
                xlWorkSheet.Cells[1, 5] = "Количество";



                var Zakazi = (from Zakaz in App.DB.Zakaz
                              select Zakaz).ToList();
                int i = 1;
                foreach (Zakaz Zakaz in Zakazi)
                {
                    xlWorkSheet.Cells[i + 1, 1] = Zakaz.ID_zakaza.ToString();
                    xlWorkSheet.Cells[i + 1, 2] = Zakaz.Nazvanie_knigi;
                    xlWorkSheet.Cells[i + 1, 3] = Zakaz.Date_zakaza;
                    xlWorkSheet.Cells[i + 1, 4] = Zakaz.Price;
                    xlWorkSheet.Cells[i + 1, 2] = Zakaz.Kolichestvo;






                    i++;
                }
                xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                MessageBox.Show("Созданный файл Excel , вы можете найти файл на рабочем столе");
            }
        }

        private void ZakazTable_Click(object sender, RoutedEventArgs e)
        {
            ZakazDataGrid.ItemsSource = (from ZakazPage in App.DB.Zakaz
                                         select ZakazPage).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var Zakaz = new Zakaz();

                Zakaz.ID_zakaza = App.DB.Zakaz.Local.Last().ID_zakaza + 1;
                Zakaz.Nazvanie_knigi = $@"{comboboxLocality24.Text}";
                Zakaz.Date_zakaza = DatezakazayaField.SelectedDate.Value;
                Zakaz.Price = PriceField.Text;
                Zakaz.Kolichestvo = KolichestvoField.Text;

                App.DB.Zakaz.Add(Zakaz);
                App.DB.SaveChanges();
                ReloadZakaz();
                MessageBox.Show("Поле добавлено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Ошибка добавления");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (ZakazDataGrid.SelectedItem as Zakaz).ID_zakaza; // Первчный ключ
                Zakaz zakaz = (from z in App.DB.Zakaz
                                           where z.ID_zakaza == id
                                           select z).First();
                zakaz.Nazvanie_knigi = $@"{comboboxLocality24.Text}";
                zakaz.Date_zakaza = DatezakazayaField.SelectedDate.Value;
                zakaz.Price = PriceField.Text;
                zakaz.Kolichestvo = KolichestvoField.Text;

                MessageBox.Show("Изменение прошло успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                App.DB.SaveChanges();

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            Zakaz ZakazRow = ZakazDataGrid.SelectedItem as Zakaz;
            Zakaz zakaz = (from z in App.DB.Zakaz
                           where z.ID_zakaza == ZakazRow.ID_zakaza
                           select z).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Zakaz.Remove(zakaz);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadZakaz();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadZakaz();
        }

        private void PriceField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void KolichestvoField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
