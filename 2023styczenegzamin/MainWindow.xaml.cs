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
        public string smallLetters = "qwertyuiopasdfghjklzxcvbnm";
        public string bigLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
        public string numbers = "1234567890";
        public string special = "!@#$%^&*()_+-=";
        bool bigUsed = false;
        bool numUsed = false;
        bool specialUsed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void hasloBtn_Click(object sender, RoutedEventArgs e)
        {
            string password = "";
            Random random = new Random();
            for (int i = 0; i < int.Parse(znakiText.Text); i++)
            {
                if ((bool)literyCheck.IsChecked && !bigUsed)
                {
                    password += bigLetters.ElementAt(random.Next(bigLetters.Length));
                    bigUsed = true;
                    continue;
                }
                if ((bool)cyfryCheck.IsChecked && !numUsed)
                {
                    password += random.Next(9).ToString();
                    numUsed = true;
                    continue;
                }
                if ((bool)znakiCheck.IsChecked && !specialUsed)
                {
                    password += special.ElementAt(random.Next(special.Length));
                    specialUsed = true;
                    continue;
                }
                password.Append(smallLetters.ElementAt(random.Next(smallLetters.Length)));
            }
            MessageBox.Show(password, "", MessageBoxButton.OK);
        }
    }
}
