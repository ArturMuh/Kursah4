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
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Word;

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для KnigiPage.xaml
    /// </summary>
    public partial class KnigiPage : System.Windows.Controls.Page
    {
        public KnigiPage()
        {
            InitializeComponent();
            ReloadKnigi();
            ReloadIzdatelstvo();
            ReloadRazdeli();
            ReloadAvtory();
            ReloadVidizdanie();
        }

        public delegate void RefreshList();
        public event RefreshList RefreshListEvent;
        public void ReloadIzdatelstvo()
        {
            comboboxLocality.ItemsSource = App.DB.Izdatelstvo.ToList();
            comboboxLocality.Items.Refresh();
        }

        public void ReloadRazdeli()
        {
            comboboxLocality1.ItemsSource = App.DB.Razdeli.ToList();
            comboboxLocality1.Items.Refresh();
        }

        public void ReloadAvtory()
        {
            comboboxLocality22.ItemsSource = App.DB.Avtory.ToList();
            comboboxLocality22.Items.Refresh();
        }

        public void ReloadVidizdanie()
        {
            comboboxLocality23.ItemsSource = App.DB.Vid_izdanie.ToList();
            comboboxLocality23.Items.Refresh();
        }
        public void ReloadKnigi()
        {
            var query = (from o in App.DB.Knigi select o);

            if (!string.IsNullOrWhiteSpace(KnigiNameSearchField.Text))
            {
                var q = KnigiNameSearchField.Text;
                query = (from k in App.DB.Knigi
                         where k.Nazvanie_knigi.Contains(q) ||
                         k.Kolichestvo.Contains(q)
                         select k);
            }
            KnigiDataGrid.ItemsSource = query.ToList();
            KnigiDataGrid.Items.Refresh();
        }

        private void KnigiSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadKnigi();
        }

        private void KnigiDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            Мухутдинов.NewFolder1.Knigi Grid_Row = KnigiDataGrid.SelectedItem as Мухутдинов.NewFolder1.Knigi;
            if (KnigiDataGrid.SelectedItem is Мухутдинов.NewFolder1.Knigi)
            {
                IDknigiyaField.Text = Grid_Row.ID_knigi.ToString();
                NazvanieknigiyaField.Text = Grid_Row.Nazvanie_knigi.ToString();
                comboboxLocality22.Text = Grid_Row.Nameavtory.ToString();
                comboboxLocality1.Text = Grid_Row.Razdel.ToString();
                KolichestvoField.Text = Grid_Row.Kolichestvo.ToString();
                comboboxLocality23.Text = Grid_Row.Vidizdanie.ToString();
                comboboxLocality.Text = Grid_Row.Izdatelstvo.ToString();
                ISBNField.Text = Grid_Row.ISBN.ToString();
                ChinaField.Text = Grid_Row.Price.ToString();
                Date_postavkiyaField.Text = Grid_Row.Date_postavki.ToString();

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
                    xlWorkSheet.Cells[1, 1] = "ID Книги";
                    xlWorkSheet.Cells[1, 2] = "Название книги";
                    xlWorkSheet.Cells[1, 3] = "Автор";
                    xlWorkSheet.Cells[1, 4] = "Вид издания";
                    xlWorkSheet.Cells[1, 5] = "ISBN";
                    xlWorkSheet.Cells[1, 6] = "Количество";
                    xlWorkSheet.Cells[1, 7] = "Цена";
                    xlWorkSheet.Cells[1, 8] = "Дата поставки";
                    xlWorkSheet.Cells[1, 9] = "Издательство";
                    xlWorkSheet.Cells[1, 10] = "Раздел";

                    var knigis = (from Knigi in App.DB.Knigi
                                  select Knigi).ToList();
                    int i = 1;
                    foreach (Knigi knigi in knigis)
                    {
                        xlWorkSheet.Cells[i + 1, 1] = knigi.ID_knigi.ToString();
                        xlWorkSheet.Cells[i + 1, 2] = knigi.Nazvanie_knigi;
                        xlWorkSheet.Cells[i + 1, 3] = knigi.Nameavtory;
                        xlWorkSheet.Cells[i + 1, 4] = knigi.Vid_izdanie;
                        xlWorkSheet.Cells[i + 1, 5] = knigi.ISBN;
                        xlWorkSheet.Cells[i + 1, 6] = knigi.Kolichestvo;
                        xlWorkSheet.Cells[i + 1, 7] = knigi.Price;
                        xlWorkSheet.Cells[i + 1, 8] = knigi.Date_postavki;
                        xlWorkSheet.Cells[i + 1, 9] = knigi.Izdatelstvo;
                        xlWorkSheet.Cells[i + 1, 10] = knigi.Razdel;

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

        private void KnigiTable_Click(object sender, RoutedEventArgs e)
        {
            KnigiDataGrid.ItemsSource = (from KnigiPage in App.DB.Knigi
                                          select KnigiPage).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                Avtory Avtor = new Avtory();
                Razdeli Razdeli = new Razdeli();
                Vid_izdanie vid_Izdanie = new Vid_izdanie();
                Izdatelstvo izdatelstvo = new Izdatelstvo();
                try
                {
                    Avtor = App.DB.Avtory.First(a => a.FIO == comboboxLocality22.Text);
                    Razdeli = App.DB.Razdeli.First(r => r.Razdel == comboboxLocality1.Text);
                    vid_Izdanie = App.DB.Vid_izdanie.First(v => v.Vidizdanie == comboboxLocality23.Text);
                    izdatelstvo = App.DB.Izdatelstvo.First(i => i.Nazvanie == comboboxLocality.Text);
                }
                catch
                {
                    try
                    {
                        Avtor.ID_avtory = App.DB.Avtory.Local.Last().ID_avtory + 1;
                        Avtor.FIO = $@"{comboboxLocality22.Text}";
                        Razdeli.ID_razdela = App.DB.Razdeli.Local.Last().ID_razdela + 1;
                        Razdeli.Razdel = $@"{comboboxLocality1.Text}";
                        vid_Izdanie.id = App.DB.Vid_izdanie.Local.Last().id + 1;
                        vid_Izdanie.Vidizdanie = $@"{comboboxLocality23.Text}";
                        izdatelstvo.ID_izdatelstva = App.DB.Izdatelstvo.Local.Last().ID_izdatelstva + 1;
                        izdatelstvo.Nazvanie = $@"{comboboxLocality.Text}";
                        App.DB.Izdatelstvo.Add(izdatelstvo);
                        App.DB.Vid_izdanie.Add(vid_Izdanie);
                        App.DB.Razdeli.Add(Razdeli);
                        App.DB.Avtory.Add(Avtor);
                        App.DB.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка", "Ошибка добавлении");
                        return;
                    }
                }
                
                var Knigi = new Knigi();
                Knigi.ID_knigi = App.DB.Knigi.Local.Last().ID_knigi + 1;
                Knigi.Nazvanie_knigi = NazvanieknigiyaField.Text;
                Knigi.Nameavtory = Avtor.FIO;
                Knigi.Razdel = Razdeli.Razdel;
                Knigi.Kolichestvo = KolichestvoField.Text;
                Knigi.Vidizdanie = vid_Izdanie.Vidizdanie;
                Knigi.ISBN = ISBNField.Text;
                Knigi.Izdatelstvo = izdatelstvo.Nazvanie;
                Knigi.Price = ChinaField.Text;
                Knigi.Date_postavki = Date_postavkiyaField.SelectedDate.Value;
                App.DB.Knigi.Add(Knigi);
                App.DB.SaveChanges();
                ReloadKnigi();
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
                var id = (KnigiDataGrid.SelectedItem as Knigi).ID_knigi; // Первчный ключ
                Knigi knigi = (from k in App.DB.Knigi
                               where k.ID_knigi == id
                               select k).First();
                knigi.Nazvanie_knigi = NazvanieknigiyaField.Text;
                knigi.Nameavtory = $@"{comboboxLocality22.Text}";
                knigi.Razdel = $@"{comboboxLocality1.Text}";
                knigi.Kolichestvo = KolichestvoField.Text;
                knigi.Vidizdanie = $@"{comboboxLocality23.Text}";
                knigi.ISBN = ISBNField.Text;
                knigi.Izdatelstvo = $@"{comboboxLocality.Text}";
                knigi.Price = ChinaField.Text;
                knigi.Date_postavki = Date_postavkiyaField.SelectedDate.Value;
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
            Knigi KnigiRow = KnigiDataGrid.SelectedItem as Knigi;
            Knigi knigi = (from k in App.DB.Knigi
                             where k.ID_knigi == KnigiRow.ID_knigi
                             select k).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Knigi.Remove(knigi);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadKnigi();
            }
        }

        private void comboboxLocality_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.hearder.HeaderText.Text = this.Title;
            ReloadKnigi();
        }

        private void PriceField_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled= new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void KolichestvoField_priviewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(grid1, "Печать");
            }
        }

        private void ChinaField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void NazvanieknigiyaField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, @"^[аА-яА-Я]+$");
        }
    }
}
