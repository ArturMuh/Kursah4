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
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для AvtoryPage.xaml
    /// </summary>
    public partial class AvtoryPage : System.Windows.Controls.Page
    {
        public AvtoryPage()
        {
            InitializeComponent();
            ReloadAvtory();
        }

        public void ReloadAvtory()
        {
            var query = (from o in App.DB.Avtory select o);

            if (!string.IsNullOrWhiteSpace(AvtoryNameSearchField.Text))
            {
                var q = AvtoryNameSearchField.Text;
                query = (from a in App.DB.Avtory
                         where a.FIO.Contains(q)
                         select a);
            }
            AvtoryDataGrid.ItemsSource = query.ToList();
            AvtoryDataGrid.Items.Refresh();
        }

        private void AvtorySearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadAvtory();
        }

        private void AvtoryDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            Мухутдинов.NewFolder1.Avtory Grid_Row = AvtoryDataGrid.SelectedItem as Мухутдинов.NewFolder1.Avtory;
            if (AvtoryDataGrid.SelectedItem is Мухутдинов.NewFolder1.Avtory)
            {
                IDavtoryyaField.Text = Grid_Row.ID_avtory.ToString();
                FamiliayaField.Text = Grid_Row.FIO.ToString();
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
                    xlWorkSheet.Cells[1, 1] = "ID Автора";
                    xlWorkSheet.Cells[1, 2] = "ФИО";

                    var Avtori = (from Avtory in App.DB.Avtory
                                  select Avtory).ToList();
                    int i = 1;
                    foreach (Avtory avtory in Avtori)
                    {
                        xlWorkSheet.Cells[i + 1, 1] = avtory.ID_avtory.ToString();
                        xlWorkSheet.Cells[i + 1, 2] = avtory.FIO;
                        




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

        private void AvtoryTable_Click(object sender, RoutedEventArgs e)
        {
            AvtoryDataGrid.ItemsSource = (from AvtoryPage in App.DB.Avtory
                                          select AvtoryPage).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            try
            {
                var Avtory = new Avtory();

                Avtory.ID_avtory = App.DB.Avtory.Local.Last().ID_avtory + 1;
                Avtory.FIO = FamiliayaField.Text;
                App.DB.Avtory.Add(Avtory);
                App.DB.SaveChanges();
                ReloadAvtory();
                MessageBox.Show("Поле добавлено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла ошибка", "Ошибка добавления");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (AvtoryDataGrid.SelectedItem as Avtory).ID_avtory; // Первчный ключ
                Avtory avtory = (from a in App.DB.Avtory
                                           where a.ID_avtory == id
                                           select a).First();
                avtory.FIO = FamiliayaField.Text;
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
            Avtory AvtoryRow = AvtoryDataGrid.SelectedItem as Avtory;
            Avtory avtory = (from a in App.DB.Avtory
                             where a.ID_avtory == AvtoryRow.ID_avtory
                             select a).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Avtory.Remove(avtory);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadAvtory();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadAvtory();
        }
    }
}
