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

namespace Variant_01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private const int MAX_RANDOM_VALUE = 100; 

        private TextBox[] getTextBoxes()
        {
            TextBox[] textBoxes = new[] {number_one, number_two, number_three};
            return textBoxes;
        }

        private void RandomizeNumbersOnClick(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            foreach (var textBox in getTextBoxes())
            {
                textBox.Text = random.Next(MAX_RANDOM_VALUE).ToString();
            }
        }

        private void SummOnClick(object sender, RoutedEventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                int sum = 0;
                foreach (var tb in getTextBoxes())
                {
                    int number = 0;
                    int.TryParse(tb.Text, out number);
                    sum += number;
                }

                result_textBox.Text = "Сумма: "+sum;
            }
            else
            {
                throw new ArgumentException("Нужно использовать только для Button");
            }
        }

        private void MultiOnClick(object sender, RoutedEventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                int mult = 1;
                foreach (var tb in getTextBoxes())
                {
                    int number;
                    if (int.TryParse(tb.Text, out number))
                    {
                        mult *= number;    
                    }
                    else
                    {
                        mult = 0;
                    }
                }

                result_textBox.Text = "Произведение: "+mult;   
            }
            else
            {
                throw new ArgumentException("Нужно использовать только для Button");
            }
        }
        private void CleanValueOnClick(object sender, RoutedEventArgs e)
        {
            Type type = sender.GetType(); 
            if (type == typeof(TextBox))
            {
                TextBox textBox = sender as TextBox;
                textBox.Text = "";
            }
                        
        }
    }
}
