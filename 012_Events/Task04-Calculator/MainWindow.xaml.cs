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

namespace Task04_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler btnNClick = null;
        public event EventHandler btnClearClick = null;
        public event EventHandler btnOperationClick = null;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void bN_Click(object sender, RoutedEventArgs e)
        {
            btnNClick.Invoke(sender, e);
        }

        private void bOperation_Click(object sender, RoutedEventArgs e)
        {
            btnOperationClick.Invoke(sender, e);
        }

        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            btnClearClick.Invoke(sender, e);
        }
    }
}
