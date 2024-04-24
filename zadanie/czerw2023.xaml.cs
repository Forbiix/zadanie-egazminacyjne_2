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
    /// Logika interakcji dla klasy czerw2023.xaml
    /// </summary>
    public partial class czerw2023 : Window
    {
        public czerw2023()
        {
            InitializeComponent();
        }
        private void powrot_click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void sprawdz_Click(object sender, RoutedEventArgs e)
        {
            double cena=0;
           
            if(poczt.IsChecked==true)
            {
                cena = 1;
                wynik.Content = $"{cena} zł";
                zdjecie.Source = new BitmapImage(new Uri("C:\\Users\\student\\Documents\\3ip\\git\\zadanie-egazminacyjne_2\\zadanie\\zdjecia\\pocztowka.png"));
            }
            if (list.IsChecked == true)
            {
                cena = 1.5;
                wynik.Content = $"{cena} zł";
                zdjecie.Source = new BitmapImage(new Uri("C:\\Users\\student\\Documents\\3ip\\git\\zadanie-egazminacyjne_2\\zadanie\\zdjecia\\list.png"));
            }
            if (paczka.IsChecked == true)
            {
                cena = 10;
                wynik.Content = $"{cena} zł";
                zdjecie.Source = new BitmapImage(new Uri("C:\\Users\\student\\Documents\\3ip\\git\\zadanie-egazminacyjne_2\\zadanie\\zdjecia\\paczka.png"));
            }

        }

        private void zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            
            string MIASTO = miasto.Text;
            string KOD = kod.Text;
            string ULICA = ulica.Text;
            int kodint;
            bool kodtak = int.TryParse(kod.Text, out kodint);
            if(kod.Text.Length == 5) 
            {
                if (kodtak == true)
                {
                    MessageBox.Show($"Dane przesyłki zostały wprowadzone");
                }
                else
                {
                    MessageBox.Show($"Kod nie składa się z samych cyfr");
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }

            
            

        }
    }
}
