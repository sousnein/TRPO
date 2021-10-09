# Задание 1. Создание проекта WPF

В задании будет показано, как разработать классическое приложение Windows Presentation Foundation (WPF), включающее элементы, которые являются общими для большинства приложений WPF: разметка XAML (XAML), код программной части, определения приложений, элементы управления, макет и др. 
Создание проекта приложения
Первым шагом является создание инфраструктуры приложения, включающей определение приложения, две страницы и изображение.
Создайте новый проект приложения WPF в Visual C# с именем TestProject1. Для этого откройте Visual Studio и выберите Создать новый проект в меню Приступая к работе.
Откроется диалоговое окно Создание нового проекта (рис.1.1).
В раскрывающемся списке Язык выберите C#.
Выберите шаблон Приложения WPF (платформа .NET Framework) и нажмите кнопку Далее.

Откроется диалоговое окно Настройка нового проекта.
Введите имя проекта TestProject1 и нажмите кнопку Создать (рис.1.2).

Visual Studio создаст проект и откроет конструктор для окна приложения по умолчанию с именем MainWindow.xaml (рис.1.3).

Создайте App.xaml. Этот файл определяет приложение WPF и все ресурсы приложения. Этот файл также используется для указания пользовательского интерфейса, в данном случае MainWindow.xaml, который автоматически отображается при запуске приложения.
Код XAML должен выглядеть следующим образом:

```XAML
<Application x:Class="TestProject1.App"
xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
xmlns:local="clr-namespace:TestProject1"
StartupUri="MainWindow.xaml">
<Application.Resources>
</Application.Resources>
</Application>
```
Создайте файл MainWindow.xaml. Этот XAML-файл является главным окном приложения и отображает содержимое, созданное на страницах. Window-класс определяет свойства окна, такие как заголовок, размер или значок, а также обрабатывает события, такие как закрытие или скрытие.
```XAML
<Window x:Class="TestProject1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
    </Grid>
</Window>
```
Измените Window элемент на NavigationWindow , как показано в следующем коде XAML:
```XAML
<NavigationWindow x:Class="TestProject1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
    </Grid>
</NavigationWindow>
```
Это приложение переходит к другому содержимому в зависимости от введенных пользователем данных. Именно поэтому необходимо изменить основное значение Window на NavigationWindow.  
NavigationWindow наследует все свойства Window. NavigationWindow создает экземпляр NavigationWindow класса. 
Удалите Grid элементы между NavigationWindow тегами.
Измените следующие свойства в коде XAML для NavigationWindow элемента:
- Присвойте Title свойству значение " ExpenseIt ".
- Задайте Height для свойства значение 350 пикселей.
- Задайте Width для свойства значение 500 пикселей.

Получится код XAML:
```XAML
<NavigationWindow x:Class="TestProject1.MainWindow"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"   
        Title="ExpenseIt" Height="350" Width="500">
</NavigationWindow>
```
Создайте файл MainWindow.xaml.cs
Этот файл является файлом кода программной части, который содержит код для работы с событиями, объявленными в файле MainWindow.xaml. Этот файл содержит разделяемый класс для окна, определенного в XAML-коде.
Измените MainWindow класс на производный от NavigationWindow.
```XAML
*** using (добавленные по умолчанию)
namespace TestProject1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
```
***Добавление файлов в приложение***
В этом разделе вы добавите в приложение две страницы и изображение.
Добавьте в проект новую страницу и назовите ее ExpenseItHome.xaml :
В Обозреватель решений щелкните правой кнопкой мыши ExpenseIt узел проекта и выберите команду Добавить > Страницу (рис.1.4).

В диалоговом окне Добавление нового элемента шаблон Page (WPF) уже выбран. Введите имя ExpenseItHome и нажмите кнопку Добавить.
Эта страница является первой страницей, отображаемой при запуске приложения. 
Создайте ExpenseItHome.xaml. Присвойте свойству значение Title "ExpenseItHome".
Задайте для параметра значение DesignHeight 350 пикселей, а для параметра — значение DesignWidth 500 пикселей.
```XAML
</Page x: Class="TestProject1.ExpenseItHome"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      xmlns: local="clr-namespace: TestProject1"
      mc:Ignorable="d" 
      d: DesignHeight="350" d: DesignWidth="500"
      Title="ExpenseItHome">
    <Grid>
    </Grid>
</Page> 
```
Создайте файл MainWindow.xaml.
Добавьте Source свойство в NavigationWindow элемент и задайте для него значение " ExpenseItHome.xaml ". Этот набор устанавливается ExpenseItHome.xaml в качестве первой страницы, открытой при запуске приложения
```XAML
<NavigationWindow x: Class="ExpenseIt.MainWindow"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        Title="ExpenseIt" Height="350" Width="500" Source="ExpenseItHome.xaml">
</NavigationWindow>
```
Также можно задать свойство Source в категории Разное в окне Свойства (рис.1.5).
Добавьте еще одну новую страницу WPF в проект и назовите ее файл ExpenseReportPage.xaml.
Создайте файл ExpenseReportPage.xaml
Присвойте свойству значение Title "ExpenseIt_View_Expense".
Задайте для параметра значение DesignHeight 350 пикселей, а для параметра - значение DesignWidth 500 пикселей.
Файл ExpenseReportPage.xaml теперь выглядит следующим образом:
```XAML
<Page x: Class="TestProject1.ExpenseReportPage"
xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      xmlns: local="clr-namespace: TestProject1"
      mc:Ignorable="d" 
      d: DesignHeight="350" d: DesignWidth="500"
      Title="ExpenseIt_View_Expense">
    <Grid>
    </Grid>
</Page>
```
Код должен выглядеть следующим образом ExpenseItHome:
```XAML
*** using (добавленные по умолчанию)
namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome: Page
    {
        public ExpenseItHome ()
        {
            InitializeComponent ();
        }
    }
}
```
И, как и для файла ExpenseReportPage:
```XAML
*** using (добавленные по умолчанию)
namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage: Page
    {
        public ExpenseReportPage ()
        {
            InitializeComponent ();
        }
    }
}
```
Чтобы выполнить сборку и запуск приложения, нажмите клавишу F5 или выберите начать отладку в меню Отладка.
Закройте приложение, чтобы вернуться в IDE Visual Studio 2019.
