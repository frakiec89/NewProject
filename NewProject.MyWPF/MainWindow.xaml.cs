using NewProject.Core;
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

namespace NewProject.MyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , IViewMessage
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public event EventHandler StartEvent;

        public void Print(string message)
        {
           MessageBox.Show(message);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(StartEvent != null)
             StartEvent(this, EventArgs.Empty);
        }
    }
}
