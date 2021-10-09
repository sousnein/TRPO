# Задание 4. События мыши

Создайте новый проект «EventsInMarkup» в IDE Visual Studio 2019.
Укажите название окна проекта: Установка свойств в разметке. События мыши.
На Панели элементов в разделе Типовые элементы управления выберите компонент Rectangle и щелкните в любом месте формы – создайте два прямоугольника (рис 1.10).
```C#
namespace EventsInMarkup
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
        // Когда курсор попадает в область прямоугольника, заполняем прямоугольник желтым цветом.
        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Rectangle).Fill = Brushes.Yellow;
        }
        // При выходе курсора за пределы прямоугольника устанавливаем зеленый цвет.
        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Rectangle).Fill = Brushes.Green;
        }
    }
}
```

