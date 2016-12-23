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

namespace Lab_1_1
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
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb1.Text + "Генерация массива..." + Environment.NewLine;
            int n;
            if (tb_elem.Text == "")
            {
                tb1.Text = tb1.Text + "Ошибка ввода корректного числа элемента" + Environment.NewLine;
                return;
            }
            if (int.TryParse(tb_elem.Text, out n) == false)
            {
                tb1.Text = tb1.Text + "Ошибка ввода корректного числа элемента" + Environment.NewLine;
                return;
            }
            n = int.Parse(tb_elem.Text);
            Array.Resize(ref array, n);
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, 2 * n);
            }
            array_created = true;
            for (int i = 0; i < n; i++)
            {
                tb1.Text = tb1.Text + "Элемент №" + i + ": " + array[i] + Environment.NewLine;
            }
            tb1.Text = tb1.Text + "Генерация массива завершена." + Environment.NewLine;
        }

        private void but_1_1_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Ошибка генерации массива" + Environment.NewLine;
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

        private void but_1_2_Click(object sender, RoutedEventArgs e)
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

        private void but_1_3_Click(object sender, RoutedEventArgs e)
        {
            {
                if (array_created == false)
                {
                    tb1.Text = tb1.Text + "Ошибка генерации массива" + Environment.NewLine;
                    return;
                }
                if (array.Length < 2)
                {
                    tb1.Text = tb1.Text + "Ошибка массив содержит меньше, чем два элемента" + Environment.NewLine;
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
}
