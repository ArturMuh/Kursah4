using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using Microsoft.Win32;

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для RazdeliPage.xaml
    /// </summary>
    public partial class RazdeliPage : System.Windows.Controls.Page
    {
        public RazdeliPage()
        {
            InitializeComponent();
            ReloadRazdeli();
        }

        public void ReloadRazdeli()
        {
            var query = (from o in App.DB.Razdeli select o);

            if (!string.IsNullOrWhiteSpace(RazdeliNameSearchField.Text))
            {
                var q = RazdeliNameSearchField.Text;
                query = (from r in App.DB.Razdeli
                         where
                         r.Razdel.Contains(q)
                         select r);
            }
            RazdeliDataGrid.ItemsSource = query.ToList();
            RazdeliDataGrid.Items.Refresh();
        }

        private void RazdeliSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadRazdeli();
        }

        private void RazdeliDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            Мухутдинов.NewFolder1.Razdeli Grid_Row = RazdeliDataGrid.SelectedItem as Мухутдинов.NewFolder1.Razdeli;
            if (RazdeliDataGrid.SelectedItem is Мухутдинов.NewFolder1.Razdeli)
            {
                ID_razdelayaField.Text = Grid_Row.ID_razdela.ToString();
                RazdelyaField.Text = Grid_Row.Razdel.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
                    xlWorkSheet.Cells[1, 1] = "ID Раздела";
                    xlWorkSheet.Cells[1, 2] = "Раздел";


                    var razdel = (from Razdel in App.DB.Razdeli
                                       select Razdel).ToList();
                    int i = 1;
                    foreach (Razdeli razdeli in razdel)
                    {
                        xlWorkSheet.Cells[i + 1, 1] = razdeli.ID_razdela.ToString();
                        xlWorkSheet.Cells[i + 1, 2] = razdeli.Razdel;

                        i++;
                    }
                    xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);

                    MessageBox.Show("Созданный файл Excel , вы можете найти файл на рабочем столе");
                }
            }
        }

        private void RazdeliTable_Click(object sender, RoutedEventArgs e)
        {
            RazdeliDataGrid.ItemsSource = (from RazdeliPage in App.DB.Razdeli
                                           select RazdeliPage).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var Razdeli = new Razdeli();

                Razdeli.ID_razdela = App.DB.Razdeli.Local.Last().ID_razdela + 1;
                Razdeli.Razdel = RazdelyaField.Text;
                App.DB.Razdeli.Add(Razdeli);
                App.DB.SaveChanges();
                ReloadRazdeli();
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
                var id = (RazdeliDataGrid.SelectedItem as Razdeli).ID_razdela; // Первчный ключ
                Razdeli razdeli = (from r in App.DB.Razdeli
                                   where r.ID_razdela == id
                                   select r).First();
                razdeli.Razdel = RazdelyaField.Text;
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
            Razdeli RazdeliRow = RazdeliDataGrid.SelectedItem as Razdeli;
            Razdeli razdeli = (from r in App.DB.Razdeli
                             where r.ID_razdela == RazdeliRow.ID_razdela
                             select r).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Razdeli.Remove(razdeli);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadRazdeli();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadRazdeli();
        }
    }
}
