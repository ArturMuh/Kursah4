using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для ZaivkaWindow.xaml
    /// </summary>
    public partial class ZaivkaWindow : Window
    {
        public ZaivkaWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fromUser = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text; ; // Получим комментарий пользователя
            string orgName = orgName_TextBox.Text;
            string unitName = unitName_TextBox.Text;
            DateTime dataZayav = DateTime.Now;
            string contPers = contactPerson_TextBox.Text;
            string emailTo = textBox1.Text;
            string uemail = "mukhutdinov66@gmail.com"; // Получим Email пользователя
            string upassword = "qbmnxejxaqzwkgxz"; // Нам понадобится и пароль от Email пользователя
                                                    // Как Вы понимаете, рассылать что-то от имени
                                                    // чужого аккаунта просто так не получится,
                                                    // Так что без авторизации никуда!
            try
            {
                MailAddress from = new MailAddress(uemail);
                MailAddress to = new MailAddress(emailTo);
                MailMessage message = new MailMessage(from, to) // Формируем сообщение с нужными заголовками
                                                                // Заголовок "от кого" ныне часто игнорируется,
                                                                // и на его место ставится реальный адрес отправителя,
                                                                
                {
                    Subject = "Заявка на заказ книг",
                    IsBodyHtml = true,
                    Body = $"<h1>Заявка на заказ книг<h1>" + $"<h2>Дата: {dataZayav}<h2>" + $"<h2>Название поставщика: {orgName}<h2>" + $"<h2>Название книг и количество в шт: {unitName}<h2>" + $"<h2>Описание заказа: {fromUser}<h2>" + $"<h2>Дата покупки книг: {dataZakaz}<h2>" + $"<h2>Контактное лицо: {contPers}<h2>"
                };
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(uemail, upassword),
                    EnableSsl = true
                };
                smtp.Send(message); // Отправляем наше письмо
                MessageBox.Show("Сообщение успешно отправлено. Спасибо!");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат электронной почты. Почта должна иметь окончания - @gmail/yandex/mail/bk/list и другие");
                textBox1.Clear();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Строка с адресом не должна быть пуста");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HelpLink);
            }
        }
    }
}
