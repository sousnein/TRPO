using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _8Ball
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия кнопки
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Ставим курсор ожидания.
            Cursor = Cursors.Wait;
            // Делаем задержку, для создания эффекта того, что программа задумалась.
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Берем случайный ответ.
            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();
            // Восстанавливаем прежнее состояние курсора.
            Cursor = null;
        }

    }
}
