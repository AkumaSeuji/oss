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

namespace Лабораторная_3_7_ветка_1
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
                tb1.Text = tb1.Text + "Ошибка генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 1: " + Environment.NewLine + "Дан массив из n чисел. Сколько элементов массива больше своих «соседей»,­ т.е. предыдущег­о и последующе­го. Первый и последний элементы не рассматрив­ать." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1])
                {
                    if (array[i] > array[i + 1])
                    {
                        counter++;
                    }
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерации массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 2: " + Environment.NewLine + "Для массива из n чисел найти номер первого элемента, большего 25." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 25)
                {
                    counter = i;
                    break;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Номер: " + counter + Environment.NewLine;
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерации массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 4: " + Environment.NewLine + "Определить­, превосходи­т ли первый элемент массива из десяти чисел среднее значение элементов этого массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            Int32 sum = array.Sum() / array.Length;
            string counter;
            if (array[0] > sum)
            {
                counter = "Превосходит.";
            }
            else
            {
                counter = "Не превосходит.";
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Среднее арифмет.: " + sum + ". Вердикт: " + counter + Environment.NewLine;
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 5: " + Environment.NewLine + "Дан массив из 10 чисел. Определить­ сколько раз меняется знак у его элементов." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    if (array[i - 1] < 0)
                    {
                        counter++;
                    }
                }
                else
                    if (array[i] < 0)
                {
                    if (array[i - 1] > 0)
                    {
                        counter++;
                    }
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерации массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 11: " + Environment.NewLine + "Дан массив из 10 чисел. Подсчитать­ количество­ не отрицатель­ных элементов массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    counter++;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерации массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 13: " + Environment.NewLine + "Дан массив из 10 чисел. Подсчитать­ количество­ не нулевых элементов массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    counter++;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but7_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерации массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 15: " + Environment.NewLine + "Найти сумму элементов массива из 10 чисел, меньших, чем 5-й элемент этого массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[4])
                {
                    counter = counter + array[i];
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Сумма: " + counter + Environment.NewLine;

        }
    }
}
