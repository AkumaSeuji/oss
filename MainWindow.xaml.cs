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

namespace Лабораторная_3_7_ветка_3
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
        private void but_arr_gen_Click(object sender, RoutedEventArgs e)
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

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 8: " + Environment.NewLine + "Дан массив из 10 чисел. Увеличить на единицу значения всех элементов кратных 5." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 5) == 0)
                {
                    array[i] = array[i] + 1;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Вывод массива: " + Environment.NewLine;
            for (int i = 0; i < 10; i++)
            {
                tb1.Text = tb1.Text + "Элемент №" + i + ": " + array[i] + Environment.NewLine;
            }
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            int counter = 0;
            tb1.Text = tb1.Text + "Задание 9: " + Environment.NewLine + "Для массива из 10 целых чисел подчитать сумму элементов,­ значения которых не кратны 3." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 3) != 0)
                {
                    counter = counter + array[i];
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Сумма: " + counter + Environment.NewLine;
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 12: " + Environment.NewLine + "Дан массив из 10 разных чисел. Найти элемент, меньше всего отличающий­ся от второго. Указание: функция абсолютной­ величины – ABS." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int default_dif = Math.Abs(array[1] - array[0]);
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[1])
                {
                    int temp = Math.Abs(array[1] - array[i]);
                    if (temp < default_dif)
                    { counter = i; }
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерация массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 12: " + Environment.NewLine + "Дан массив из 10 разных чисел. Найти элемент, меньше всего отличающий­ся от второго. Указание: функция абсолютной­ величины – ABS." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int default_dif = Math.Abs(array[1] - array[0]);
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[1])
                {
                    int temp = Math.Abs(array[1] - array[i]);
                    if (temp < default_dif)
                    { counter = i; }
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерация массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 14: " + Environment.NewLine + "В массиве из 10 целых чисел подсчитать­ количество­ элементов,­ кратных 3." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    counter++;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }
    }
}
