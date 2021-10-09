# Задание 3. Установка свойств в разметке

Создайте новый проект в IDE Visual Studio 2019.
Укажите название окна проекта: Установка свойств в разметке.
На Панели элементов в разделе Типовые элементы управления выберите компонент Rectangle и щелкните в любом месте формы – создайте два квадрата.
Нажмите двойным щелчком левой кнопкой мыши по одному из квадратов. В открывшейся программной части проекта добавить следующий код:
```XAML
<Window x: Class="PropertiesInMarkUp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Установка свойств в разметке" Height="280" Width="525">
    <StackPanel>
        <!--Установка значения свойства Fill через атрибут-->
        <Rectangle Fill="Green" Width="100" Height="100">
        </Rectangle>
        <!--Установка значения свойства Fill через вложенный элемент-->
        <Rectangle Width="100" Height="100" Margin="10">
            <Rectangle.Fill>
                <LinearGradientBrush>
                    <GradientStop Color="Chocolate" Offset="0"></GradientStop>
                    <GradientStop Color="BlueViolet" Offset="1"></GradientStop>
                </LinearGradientBrush>
            </Rectangle.Fill>
        </Rectangle>
    </StackPanel>
</Window>
```
