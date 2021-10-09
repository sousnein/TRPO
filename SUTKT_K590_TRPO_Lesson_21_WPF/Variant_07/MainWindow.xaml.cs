using System;
using System.Windows;

namespace Variant_07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int oldNUmber;
        private int CalcSumm(int number)
        {
            int sum = 0;
            foreach (var c in number.ToString())
            {
                int n = 0;
                int.TryParse(c.ToString(), out n);
                sum += n;
            }
            return sum;
        }

        private int CalcMultip(int number)
        {
            int multip = 1;
            foreach (var c in number.ToString())
            {
                int n;
                int.TryParse(c.ToString(), out n);
                multip *= n;
            }
            return multip;
        }

        private int getRandomInt()
        {
            Random random = new Random();
            int number = random.Next(10, 99);
            oldNUmber = number;
            return number;
        }

        private void SubmitOnClick(object sender, RoutedEventArgs e)
        {
            int number;
            if (!int.TryParse(number_textBox.Text, out number))
            {
                number = getRandomInt();
                number_textBox.Text = number.ToString();
            } else if (number == oldNUmber)
            {
                number = getRandomInt();
                number_textBox.Text = number.ToString();
            }
            else
            {
                oldNUmber = number;
            }
            result_textBlock.Text = "Сумма цифр: " + CalcSumm(number) + "\nПроизведение цифр: " + CalcMultip(number);
        }
    }
}