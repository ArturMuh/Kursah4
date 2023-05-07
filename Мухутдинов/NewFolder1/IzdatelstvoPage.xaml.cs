using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
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

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для IzdatelstvoPage.xaml
    /// </summary>
    public partial class IzdatelstvoPage : System.Windows.Controls.Page
    {
        public IzdatelstvoPage()
        {
            InitializeComponent();
            ReloadIzdatelstvo();
        }

        public void ReloadIzdatelstvo()
        {
            var query = (from o in App.DB.Izdatelstvo select o);

            if (!string.IsNullOrWhiteSpace(IzdatelstvoNameSearchField.Text))
            {
                var q = IzdatelstvoNameSearchField.Text;
                query = (from i in App.DB.Izdatelstvo
                         where i.Nazvanie.Contains(q)
                         select i);
            }
            IzdatelstvoDataGrid.ItemsSource = query.ToList();
            IzdatelstvoDataGrid.Items.Refresh();
        }

        private void IzdatelstvoSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadIzdatelstvo();
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
                    xlWorkSheet.Cells[1, 1] = "ID Издательство";
                    xlWorkSheet.Cells[1, 2] = "Название";


                    var izdatelstvo = (from Izdatelstvo in App.DB.Izdatelstvo
                                  select Izdatelstvo).ToList();
                    int i = 1;
                    foreach (Izdatelstvo Izdatelstvo in izdatelstvo)
                    {
                        xlWorkSheet.Cells[i + 1, 1] = Izdatelstvo.ID_izdatelstva.ToString();
                        xlWorkSheet.Cells[i + 1, 2] = Izdatelstvo.Nazvanie;

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

        private void IzdatelstvoTable_Click(object sender, RoutedEventArgs e)
        {
            IzdatelstvoDataGrid.ItemsSource = (from IzdatelstvoPage in App.DB.Izdatelstvo
                                               select IzdatelstvoPage).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var Izdatelstvo = new Izdatelstvo();

                Izdatelstvo.ID_izdatelstva = App.DB.Izdatelstvo.Local.Last().ID_izdatelstva + 1;
                Izdatelstvo.Nazvanie = NazvanieyaField.Text;
                App.DB.Izdatelstvo.Add(Izdatelstvo);
                App.DB.SaveChanges();
                ReloadIzdatelstvo();
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
                var id = (IzdatelstvoDataGrid.SelectedItem as Izdatelstvo).ID_izdatelstva; // Первчный ключ
                Izdatelstvo izdatelstvo = (from i in App.DB.Izdatelstvo
                                           where i.ID_izdatelstva == id
                                           select i).First();
                izdatelstvo.Nazvanie = NazvanieyaField.Text;
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
            Izdatelstvo IzdatelstvoRow = IzdatelstvoDataGrid.SelectedItem as Izdatelstvo;
            Izdatelstvo izdatelstvi = (from i in App.DB.Izdatelstvo
                             where i.ID_izdatelstva == IzdatelstvoRow.ID_izdatelstva
                             select i).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Izdatelstvo.Remove(izdatelstvi);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadIzdatelstvo();
            }
        }

        private void IzdatelstvoDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            Мухутдинов.NewFolder1.Izdatelstvo Grid_Row = IzdatelstvoDataGrid.SelectedItem as Мухутдинов.NewFolder1.Izdatelstvo;
            if (IzdatelstvoDataGrid.SelectedItem is Мухутдинов.NewFolder1.Izdatelstvo)
            {
                IDizdatelstvayaField.Text = Grid_Row.ID_izdatelstva.ToString();
                NazvanieyaField.Text = Grid_Row.Nazvanie.ToString();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadIzdatelstvo();
        }
    }
}
