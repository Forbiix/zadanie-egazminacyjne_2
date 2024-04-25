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
    /// Logika interakcji dla klasy sty2023.xaml
    /// </summary>
    public partial class sty2023 : Window
    {
        public sty2023()
        {
            InitializeComponent();
        }
        private void powrot_click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AcceptOnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("zatwierdzono dane");


        }

        public static char[] random_letters(int legth, bool number, bool b_letter, bool special)
        {
            Random rnd = new Random();
            char[] specials = { '!', '@', '#', '$', '%', '^', '&', '*' };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'q', 'y', 'z' };
            char[] b_letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'W', 'Q', 'Y', 'Z' };
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] password = new char[legth];

            for (int i = 0; i < legth; i++)
            {
                password[i] = letters[rnd.Next(letters.Length)];
            }
            if (number == true)
            {
                password[0] = numbers[rnd.Next(numbers.Length)];
            }
            if (special == true)
            {
                if (legth > 1)
                {
                    password[1] = specials[rnd.Next(specials.Length)];
                }

            }
            if (b_letter == true)
            {
                if (legth > 2)
                {
                    password[2] = b_letters[rnd.Next(b_letters.Length)];
                }
            }

            return password;
        }

        private void zatwierdz(object sender, RoutedEventArgs e)
        {
            bool b_letters = false;
            bool numbers = false;
            bool specials = false;
            int password_length = int.Parse(passwordlength.Text);
            if (c_numbers.IsChecked == true)
            {
                numbers = true;
            }
            if (c_letters.IsChecked == true)
            {
                b_letters = true;
            }
            if (c_special.IsChecked == true)
            {
                specials = true;
            }
            char[] generated_password = random_letters(password_length, numbers, b_letters, specials);
            string password = "";
            for (int i = 0; i < generated_password.Length; i++)
            {
                password += generated_password[i].ToString();
            }
            MessageBox.Show($"Twoje hasło to: {password}");
        }
    }
}
