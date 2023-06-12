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

namespace _2023styczenegzamin
{
    public partial class MainWindow : Window
    {
        public char[] smallLetters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();

        public char[] bigLetters = "QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();
        public char[] numbers = "1234567890".ToCharArray();
        public char[] special = "!@#$%^&*()_+-=".ToCharArray();
        string password = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void hasloBtn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            int ileZnakow = int.Parse(znakiText.Text);
            for (int i = 0; i < ileZnakow; i++)
            {
                if((i==0) && (cyfryCheck.IsChecked == true))
                {
                    password += numbers[random.Next(numbers.Length)];
                }
                if ((i == 1) && (znakiCheck.IsChecked == true))
                {
                    password += special[random.Next(special.Length)];
                }
                if ((i == 2) && (literyCheck.IsChecked == true))
                {
                    password += bigLetters[random.Next(bigLetters.Length)];
                }
                else
                {
                    password += smallLetters[random.Next(smallLetters.Length)];
                }
            }

            MessageBox.Show(password);
        }

        private void zatwierdzBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dane pracownika: " + imieText.Text + " " + nazwiskoText.Text + " " + stanowiskoCombo.Text + " Hasło: " + password);
        }
    }
}
