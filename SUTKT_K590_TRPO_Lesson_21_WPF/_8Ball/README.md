# Задание 5. Создание адаптивного TextBox

Создайте новый проект «_8Ball» в IDE Visual Studio 2019.
Укажите название окна проекта: Магический 8 ball.
На Панели элементов в разделе Типовые элементы управления выберете 2 TextBox и 1 Button. Разместите элементы на форме следующим образом и задайте такие же свойства (рис.1.12).: 
Нажмите двойным щелчком левой кнопкой мыши по одному из текст-боксов. В открывшейся программной части проекта добавить следующий код:
```XAML
<Window x:Class="_8Ball.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Магический 8 Ball" Height="350" Width="525">
    <!--
        Объект Grid Определяет гибкую область сетки, состоящую из столбцов и строк.        
    -->
    <Grid>
        <!--
            RowDefinitions - Коллекция которая определяет
            строки для отображения - RowDefinition.
        -->
        <Grid.RowDefinitions>
            <!--
                Создаем три строки(RowDefinition) в коллекции - RowDefinitions.
                (Height="100*"):
                100  - Фиксированные размер.
                100* - Указывает, что начальный размер ряда значение до звездочки, но размер может пропорционально изменяться при изменении размера окна.
                Auto - Указывает что размер данного элемента будет подобран под размер
                       самого большого объекта в контейнере.
            -->
            <RowDefinition Height="100*" />
            <RowDefinition Height="Auto" />
            <RowDefinition Height="100*" />
        </Grid.RowDefinitions>
        <!--
            Используем сложную кисть для заливки фона градиентом.
            Добавляем для этого дескриптор - Background.
        -->
        <Grid.Background>
            <!-- LinearGradientBrush - Заполняет область линейным градиентом.
Линейный градиент определяет градиент вдоль прямой линии.
Конечные точки линии определяются свойствами StartPoint и EndPoin линейного градиента.
Кисть LinearGradientBrush рисует свои GradientStops вдоль этой линии.
            -->
            <LinearGradientBrush StartPoint="0,0" EndPoint="0,1">

                <!-- Коллекция свойств GradientStop -->
                <LinearGradientBrush.GradientStops>
                    <!--
                        GradientStop имеет свойства:
                        Offset - Задает позици цвета.
                        Color  - Задает цвет.
                    -->
                    <GradientStop Offset="1" Color="#FFEEEEEE" />
                    <GradientStop Offset="0.881" Color="#FF302F2F" />
                </LinearGradientBrush.GradientStops>
            </LinearGradientBrush>
        </Grid.Background>

        <!--
            <TextBox Имя объкта.
                     Name="txtQuestion"
            Выравнивание элемента по горизонтали относительно контейнера.
                     HorizontalAlignment="Stretch" 
            Выравнивание элемента по вертикали относительно контейнера.
                     VerticalAlignment="Stretch" 
            Выравнивание элемента относительно сторон контейнера.
                     Margin="10" 
            Пренос на новую строку в случае, если текст не помещается в одной строке.
                     TextWrapping="Wrap" 
            Шрифт, который будем использовать.
                     FontFamily="Verdana" 
            Размер используемого шрифта.
                     FontSize="20" 
            Строка в контейнере в которой будет находится данный элемент.
                     Grid.Row="0" 
            Цвет используемого шрифта.
                     Foreground="#FF646464" 
            Свойство текст.
                     Text="[Введите свой вопрос.]" />
        -->
        <TextBox Name="txtQuestion" 
                 HorizontalAlignment="Stretch" 
                 VerticalAlignment="Stretch" 
                 Margin="10" 
                 TextWrapping="Wrap" 
                 FontFamily="Verdana" 
                 FontSize="20" 
                 Grid.Row="0" 
                 Foreground="#FF646464" 
                 Text="[Введите свой вопрос.]" TextChanged="txtQuestion_TextChanged" />
        <!-- 
            IsDefault - Получает или задает значение, указывающее, является ли Button кнопкой по умолчанию.
        -->
        <Button HorizontalAlignment="Left" 
                VerticalAlignment="Center" 
                Margin="10,0,10,0"
                Padding="5"
                Grid.Row="1" 
                Content="Ответ на вопрос" 
                Click="Answer_Click" 
                IsDefault="True" />
        <TextBox Name="txtAnswer" 
                 HorizontalAlignment="Stretch" 
                 VerticalAlignment="Stretch" 
                 Margin="10" 
                 TextWrapping="Wrap" 
                 FontFamily="Verdana" 
                 FontSize="20" 
                 IsReadOnly="True"
                 Grid.Row="2" 
                 Foreground="#FF009BFF" 
                 Text="[Ответ появится здесь.]" />
    </Grid>
</Window>
```
Нажмите двойным щелчком левой кнопкой мыши по кнопке Ответ на вопрос. Откроется программная часть проекта, в которой необходимо добавить следующий код:
```C#
namespace _8Ball
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
        // Обработчик события нажатия кнопки
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Ставим курсор ожидания.
            this.Cursor = Cursors.Wait;
            // Делаем задержку, для создания эффекта того, что программа задумалась.
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Берем случайный ответ.
            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();
            // Восстанавливаем прежнее состояние курсора.
            this.Cursor = null;
        }
        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
```
