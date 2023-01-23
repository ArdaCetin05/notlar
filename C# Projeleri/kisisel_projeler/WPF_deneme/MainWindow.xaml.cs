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

namespace WPF_deneme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        string yazi1 = "buraya yaklaşın";
        string yazi2 = "buradan uzaklaşın";
        private void fonsiyon(object sender, MouseEventArgs e)
        {
            label1.Content = yazi2;
        }

        private void fonksiyon2(object sender, MouseEventArgs e)
        {
            label1.Content = yazi1;
        }
    }
}
