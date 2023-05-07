using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для VidizdaniePage.xaml
    /// </summary>
    public partial class VidizdaniePage : System.Windows.Controls.Page
    {
        public VidizdaniePage()
        {
            InitializeComponent();
            ReloadVidizdanie();
        }

        public void ReloadVidizdanie()
        {
            var query = (from o in App.DB.Vid_izdanie select o);

            if (!string.IsNullOrWhiteSpace(VidizdanieNameSearchField.Text))
            {
                var q = VidizdanieNameSearchField.Text;
                query = (from v in App.DB.Vid_izdanie
                         where v.Vidizdanie.Contains(q)
                         select v);
            }
            VidizdanieDataGrid.ItemsSource = query.ToList();
            VidizdanieDataGrid.Items.Refresh();
        }


        private void VidizdanieSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadVidizdanie();
        }

        private void VidizdanieDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            Мухутдинов.NewFolder1.Vid_izdanie Grid_Row = VidizdanieDataGrid.SelectedItem as Мухутдинов.NewFolder1.Vid_izdanie;
            if (VidizdanieDataGrid.SelectedItem is Мухутдинов.NewFolder1.Vid_izdanie)
            {
                idizdanieyaField.Text = Grid_Row.id.ToString();
                VidizdanieyaField.Text = Grid_Row.Vidizdanie.ToString();
            }
        }

        private void VidizdanieTable_Click(object sender, RoutedEventArgs e)
        {
            VidizdanieDataGrid.ItemsSource = (from VidizdaniePage in App.DB.Vid_izdanie
                                              select VidizdaniePage).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Vidizdanie = new Vid_izdanie();

                Vidizdanie.id = App.DB.Vid_izdanie.Local.Last().id + 1;
                Vidizdanie.Vidizdanie = VidizdanieyaField.Text;
                App.DB.Vid_izdanie.Add(Vidizdanie);
                App.DB.SaveChanges();
                ReloadVidizdanie();
                MessageBox.Show("Поле добавлено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Ошибка добавления");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (VidizdanieDataGrid.SelectedItem as Vid_izdanie).id; // Первчный ключ
                Vid_izdanie Vidizdanie = (from v in App.DB.Vid_izdanie
                                          where v.id == id
                                          select v).First();
                Vidizdanie.Vidizdanie = VidizdanieyaField.Text;
                MessageBox.Show("Изменение прошло успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                App.DB.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Vid_izdanie VidizdanieRow = VidizdanieDataGrid.SelectedItem as Vid_izdanie;
            Vid_izdanie vidizdanie = (from v in App.DB.Vid_izdanie
                                      where v.id == VidizdanieRow.id
                                      select v).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Vid_izdanie.Remove(vidizdanie);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadVidizdanie();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadVidizdanie();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
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
                    xlWorkSheet.Cells[1, 1] = "ID издания";
                    xlWorkSheet.Cells[1, 2] = "Вид издания";

                    var vidizdanie = (from Vidizdanie in App.DB.Vid_izdanie
                                  select Vidizdanie).ToList();
                    int i = 1;
                    foreach (Vid_izdanie Vidizdanie in vidizdanie)
                    {
                        xlWorkSheet.Cells[i + 1, 1] = Vidizdanie.id.ToString();
                        xlWorkSheet.Cells[i + 1, 2] = Vidizdanie.Vidizdanie;
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
    }
}
