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

namespace zadanie
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

        private void styczen_2023_Click(object sender, RoutedEventArgs e)
        {
            sty2023 window = new sty2023();
            window.ShowDialog();
            this.Close();

        }
        private void stycznen_2024_Click(object sender, RoutedEventArgs e)
        {
            sty2024 window = new sty2024();
            window.Show();
            this.Close();

        }

        private void czerwiec_2023_Click(object sender, RoutedEventArgs e)
        {
            czerw2023 window = new czerw2023();
            window.Show();
            this.Close();

        }

        private void czwarty_plik_Click(object sender, RoutedEventArgs e)
        {
            czwarty window = new czwarty();
            window.Show();
            this.Close();

        }

        
    }
}
