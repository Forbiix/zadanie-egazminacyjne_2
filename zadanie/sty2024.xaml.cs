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
using System.Windows.Shapes;

namespace zadanie
{
    /// <summary>
    /// Logika interakcji dla klasy sty2024.xaml
    /// </summary>
    public partial class sty2024 : Window
    {
        public sty2024()
        {
            InitializeComponent();
        }
        private void powrot_click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void numer_LostFocus(object sender, RoutedEventArgs e)
        {

            string photo_numer = "111";
            if(numer.Text =="111" || numer.Text =="222" || numer.Text == "333")
            {
                face.Visibility = Visibility.Visible;
                train.Visibility = Visibility.Visible;
                photo_numer = numer.Text;
            }
            else
            {
                face.Visibility = Visibility.Collapsed;
                train.Visibility = Visibility.Collapsed;
                MessageBox.Show("Niepoprawny numer");
            }
            face.Source = new BitmapImage(new Uri($"C:/Users/student/Documents/3ip/git/zadanie-egazminacyjne_2/zadanie/zdjecia/{photo_numer}.jpg"));
            train.Source = new BitmapImage(new Uri($"C:\\Users\\student\\Documents\\3ip\\git\\zadanie-egazminacyjne_2\\zadanie\\zdjecia\\{photo_numer}-pocaig.png"));

        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string IMIE = imie.Text;
            string NAZWISKO = nazwisko.Text;
            string KOLOR = "";
            if (rd1.IsChecked == true)
            {
                KOLOR = "niebieskie";
            }
            if (rd2.IsChecked == true)
            {
                KOLOR = "zielone";
            }
            if (rd3.IsChecked == true)
            {
                KOLOR = "piwne";
            }
            MessageBox.Show($"Oto {IMIE} {NAZWISKO}. Jego oczy są {KOLOR}");

        }
    }
}
