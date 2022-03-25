using NewProject.BL;
using NewProject.Prezenter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NewProject.MyWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static MainWindow window;


        [STAThread]
        static void Main()
        {
            window = new MainWindow();
            App app = new App();
            app.Run(window);
        }

        public App  ()
        {
            BLContent bLContent = new BLContent();
            MyMessage myMessage = new MyMessage(bLContent, window );
        }
    }
}
