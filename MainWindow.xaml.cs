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

namespace Лабораторная_3_7_ветка_2
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
        public bool array_created = false;
        public Int32[] array;
        public Random rand = new Random();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb1.Text + "Генерация массива..." + Environment.NewLine;
            Array.Resize(ref array, 10);
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(-10, 20);
            }
            array_created = true;
            for (int i = 0; i < 10; i++)
            {
                tb1.Text = tb1.Text + "Элемент №" + i + ": " + array[i] + Environment.NewLine;
            }
            tb1.Text = tb1.Text + "Генерация массива завершена." + Environment.NewLine;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерация массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 6: " + Environment.NewLine + "Найти, сколько элементов массива из 10 чисел больше, чем четвертый элемент этого массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[3])
                {
                    counter++;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерация массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 7: " + Environment.NewLine + "Найти сумму элементов массива из 10 чисел, меньших, чем 21." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 21)
                {
                    counter = counter + array[i];
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Сумма: " + counter + Environment.NewLine;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерация массив" + Environment.NewLine;
                return;
            }
            if (array.Length < 2)
            {
                tb1.Text = tb1.Text + "Ошибка массив содержит меньше двух элементов" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 3: " + Environment.NewLine + "В массиве из n чисел найти сумму элементов больших, чем   второй элемент этого массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[1])
                {
                    counter = counter + array[i];
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Сумма: " + counter + Environment.NewLine;

        }
    }
}
