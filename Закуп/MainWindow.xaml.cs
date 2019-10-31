using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Закуп
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> buys;
        public MainWindow()
        {
            InitializeComponent();

            buys = new ObservableCollection<string> {""};
            buysList.ItemsSource = buys;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string buy = textBox1.Text;

            buys.Add(buy);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
