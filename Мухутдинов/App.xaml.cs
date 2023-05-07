using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Мухутдинов.NewFolder1;

namespace Мухутдинов
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Post_BiblioEntities9 DB;
        public static Biblioteka currentUser;
        public static HearderPage hearder;
        public static Avtory avtory;
        public static Knigi knigi;
        public static MainWindow mainWindow;

        public static object CurrentUser { get; internal set; }
        public static object HeaderFrame { get; internal set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DB = new Post_BiblioEntities9();
        }
    }

}
