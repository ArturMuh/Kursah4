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
using Xceed.Wpf.Toolkit;

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для PostavchikPage.xaml
    /// </summary>
    public partial class PostavchikPage : System.Windows.Controls.Page
    {
        public PostavchikPage()
        {
            InitializeComponent();
            ReloadPostavchik();
        }

        public void ReloadPostavchik()
        {
            var query = (from o in App.DB.Postavshik select o);

            if (!string.IsNullOrWhiteSpace(PostavchikNameSearchField.Text))
            {
                var q = PostavchikNameSearchField.Text;
                query = (from p in App.DB.Postavshik
                         where p.Nazvanie.Contains(q) ||
                         p.Telefon.Contains(q)
                         select p);
            }
            PostavshikDataGrid.ItemsSource = query.ToList();
            PostavshikDataGrid.Items.Refresh();
        }

        private void PostavchikSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadPostavchik();
        }

        private void PostavshikDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            Мухутдинов.NewFolder1.Postavshik Grid_Row = PostavshikDataGrid.SelectedItem as Мухутдинов.NewFolder1.Postavshik;
            if (PostavshikDataGrid.SelectedItem is Мухутдинов.NewFolder1.Postavshik)
            {
                IDpostavshikayaField.Text = Grid_Row.ID_postavshika.ToString();
                NazvanieyaField.Text = Grid_Row.Nazvanie.ToString();
                AdressField.Text = Grid_Row.Adress.ToString();
                maskedtextboxPhoneNumber.Text = Grid_Row.Telefon.ToString();
                maskedtextboxEmailNumber.Text = Grid_Row.Email.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                var sfd = new SaveFileDialog()
                {
                    Filter = "Excel (.xls)|*.xls |Excel (.xlsx)|*.xlsx |All files (*.*)|*.*\"",
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
                    xlWorkSheet.Cells[1, 1] = "ID поставщика";
                    xlWorkSheet.Cells[1, 2] = "Название";
                    xlWorkSheet.Cells[1, 3] = "Адрес";
                    xlWorkSheet.Cells[1, 4] = "Телефон";
                    xlWorkSheet.Cells[1, 5] = "Email";



                    var postavshik = (from Postavshik in App.DB.Postavshik
                                  select Postavshik).ToList();
                    int i = 1;
                    foreach (Postavshik postavchik in postavshik)
                    {
                        xlWorkSheet.Cells[i + 1, 1] = postavchik.ID_postavshika.ToString();
                        xlWorkSheet.Cells[i + 1, 2] = postavchik.Nazvanie;
                        xlWorkSheet.Cells[i + 1, 3] = postavchik.Adress;
                        xlWorkSheet.Cells[i + 1, 4] = postavchik.Telefon;

                        i++;
                    }
                    xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);

                    Xceed.Wpf.Toolkit.MessageBox.Show("Созданный файл Excel , вы можете найти файл на рабочем столе");
                }
            }
        }

        private void PostavchikTable_Click(object sender, RoutedEventArgs e)
        {
            PostavshikDataGrid.ItemsSource = (from PostavchikPage in App.DB.Postavshik
                                              select PostavchikPage).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var Postavchik = new Postavshik();

                Postavchik.ID_postavshika = App.DB.Postavshik.Local.Last().ID_postavshika + 1;
                Postavchik.Nazvanie = NazvanieyaField.Text;
                Postavchik.Adress = AdressField.Text;
                Postavchik.Telefon = $@"{maskedtextboxPhoneNumber.Text}";
                Postavchik.Email = $@"{maskedtextboxEmailNumber.Text}";
                App.DB.Postavshik.Add(Postavchik);
                App.DB.SaveChanges();
                ReloadPostavchik();
                Xceed.Wpf.Toolkit.MessageBox.Show("Поле добавлено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Произошла ошибка", "Ошибка добавления");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (PostavshikDataGrid.SelectedItem as Postavshik).ID_postavshika; // Первчный ключ
                Postavshik postavshik = (from p in App.DB.Postavshik
                                         where p.ID_postavshika == id
                                         select p).First();
                postavshik.Nazvanie = NazvanieyaField.Text;
                postavshik.Adress = AdressField.Text;
                postavshik.Telefon = $@"{maskedtextboxPhoneNumber.Text}";
                postavshik.Email = $@"{maskedtextboxEmailNumber.Text}";
                App.DB.SaveChanges();
                Xceed.Wpf.Toolkit.MessageBox.Show("Изменение прошло успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Ошибка");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Postavshik PostavshikRow = PostavshikDataGrid.SelectedItem as Postavshik;
            Postavshik postavshik = (from p in App.DB.Postavshik
                                     where p.ID_postavshika == PostavshikRow.ID_postavshika
                                     select p).Single();

            MessageBoxResult result = Xceed.Wpf.Toolkit.MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Postavshik.Remove(postavshik);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadPostavchik();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadPostavchik();
        }

        private void TelefonField_priviewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
