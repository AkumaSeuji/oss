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
using System.IO;
using Microsoft.Win32;

namespace Проектное_задание_трапеции
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

        public double  eps, result2, h;
        public bool eps_flag = false;
        public bool a_flag = false;
        public bool b_flag = false;
        public bool n_flag = false;
        public bool done_flag = false;
        public int n, a, b;

        private void information_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void Author_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Реализация метода трапеции для численного интегрирования. Герасимова Е.В. 120441 ");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            a = 0;
            b = 0;
            n = 0;
            eps = 0;
            while (a == b)
            {
                a = rand.Next(0, 10);
                b = rand.Next(0, 10);
                if (a > b)
                {
                    a = rand.Next(0, 10);
                    b = rand.Next(0, 10);
                }
            }
            
            n = rand.Next(3, 10);
           
            Otvet.Text = Otvet.Text + "Значения сгенерированы: " + Environment.NewLine;
            Otvet.Text = Otvet.Text + "а: " + a + Environment.NewLine;
            Otvet.Text = Otvet.Text + "b: " + b + Environment.NewLine;
            Otvet.Text = Otvet.Text + "n: " + n + Environment.NewLine;
            n_flag = true;

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            string[] arr_read;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            arr_read = File.ReadAllLines(ofd.FileName);
            string[] fd_res_string = arr_read[0].Split('|');
            a = Convert.ToInt32(fd_res_string[0]);
            b = Convert.ToInt32(fd_res_string[1]);
            n = Convert.ToInt32(fd_res_string[2]);
            Otvet.Text = Otvet.Text + "Чтение завершено: " + Environment.NewLine;
            Otvet.Text = Otvet.Text + "eps: " + eps + Environment.NewLine;
            Otvet.Text = Otvet.Text + "a: " + a + Environment.NewLine;
            Otvet.Text = Otvet.Text + "b: " + b + Environment.NewLine;
            Otvet.Text = Otvet.Text + "n: " + n + Environment.NewLine;
            n_flag = true;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            string[] str_res = new string[1];
            str_res[0] = "Результат: " + Convert.ToString(result2) + Environment.NewLine;
            File.WriteAllLines(sfd.FileName, str_res);
            Otvet.Text = Otvet.Text + "Запись завершена " + Environment.NewLine;

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Otvet_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public double x;
        static double Trapeze(Func<double, double> integralFunc, int a, int b, int n)
        {
            double h = (b - a) * 1.0 / n;

            List<double> results = new List<double>();

            double x = a;

            while (x <= b)
            {
                results.Add(integralFunc(x));
                x += h;
            }

            double first = results.First();
            double last = results.Last();

            double sum = 0;
            for (int i = 1; i < results.Count - 1; i++)
            {
                sum += results[i];
            }

            return h * (((first - last) / 2.0) + sum);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            

            if (rb1.IsChecked == true)
                {
                    Func<double, double> integralFunc = x => -Math.Sin(x);

                    double result = Trapeze(integralFunc, a, b, n);
                    double result2;
                    double diff;

                    do
                    {
                        result2 = Trapeze(integralFunc, a, b, n);
                        diff = Math.Abs(result2 - result);

                        result = result2;
                        n += 10;
                    } while (diff > eps);

                    Otvet.Text = "Результат= " + result2 + Environment.NewLine;

                }
                if (rb2.IsChecked == true)
                {
                    Func<double, double> integralFunc = x => Math.Cos(x);

                    double result = Trapeze(integralFunc, a, b, n);
                    double result2;
                    double diff;

                    do
                    {
                        result2 = Trapeze(integralFunc, a, b, n);
                        diff = Math.Abs(result2 - result);

                        result = result2;
                        n += 10;
                    } while (diff > eps);

                    Otvet.Text = "Результат= " + result2 + Environment.NewLine;

                }
                if (rb3.IsChecked == true)
                {
                    Func<double, double> integralFunc = x => 2 * x;

                    double result = Trapeze(integralFunc, a, b, n);
                    double result2;
                    double diff;

                    do
                    {
                        result2 = Trapeze(integralFunc, a, b, n);
                        diff = Math.Abs(result2 - result);

                        result = result2;
                        n += 10;
                    } while (diff > eps);

                    Otvet.Text = "Результат= " + result2 + Environment.NewLine;

                }

                if (rb4.IsChecked == true)
                {
                    Func<double, double> integralFunc = x => 1 / Math.Log(x);

                    double result = Trapeze(integralFunc, a, b, n);
                    double result2;
                    double diff;

                    do
                    {
                        result2 = Trapeze(integralFunc, a, b, n);
                        diff = Math.Abs(result2 - result);

                        result = result2;
                        n += 10;
                    } while (diff > eps);

                    Otvet.Text = "Результат= " + result2 + Environment.NewLine;

                }
            }

   
      
            private void button1_Click(object sender, RoutedEventArgs e)
             {

                if (textBox.Text == "")
                {
                    Otvet.Text = Otvet.Text + "Введите Эпсилон" + Environment.NewLine;
                    return;
                }
             if (textBox1.Text == "")
                {
                    Otvet.Text = Otvet.Text + "Введите a" + Environment.NewLine;
                    return;
                }
            if (textBox2.Text == "")
                {
                    Otvet.Text = Otvet.Text + "Введите b" + Environment.NewLine;
                    return;
                }
                if (textBox3.Text == "")
                {
                    Otvet.Text = Otvet.Text + "Введите n" + Environment.NewLine;
                    return;
                }
                if (double.TryParse(textBox.Text, out eps) == false)
                {
                    Otvet.Text = Otvet.Text + "Эпсилон не является допустимым числом" + Environment.NewLine;
                    return;
                }
                else
                {
                    eps = Convert.ToDouble(textBox.Text);
                    eps_flag = true;
                }
            if (int.TryParse(textBox1.Text, out a) == false)
                {
                    Otvet.Text = Otvet.Text + "a не является допустимым числом" + Environment.NewLine;
                    return;
                }
                else
                {
                    a = Convert.ToInt32(textBox1.Text);
                    a_flag = true;
                }
                if (int.TryParse(textBox2.Text, out b) == false)
                {
                    Otvet.Text = Otvet.Text + "b не является допустимым числом" + Environment.NewLine;
                    return;
                }
                else
                {
                    b = Convert.ToInt32(textBox2.Text);
                    b_flag = true;
                }
                if (int.TryParse(textBox3.Text, out n) == false)
                {
                    Otvet.Text = Otvet.Text + "n не является допустимым числом" + Environment.NewLine;
                    return;
                }
                else
                {
                    n = Convert.ToInt16(textBox3.Text);
                    n_flag = true;
                }
                if (n < 2)
                {
                    Otvet.Text = Otvet.Text + "N < 2" + Environment.NewLine;
                    return;
                }
                if (a > b)
                {
                    Otvet.Text = Otvet.Text + "a > b" + Environment.NewLine;
                    return;
                }
                Otvet.Text = Otvet.Text + "Значения зарегестрированны" + Environment.NewLine;
            }
        }
    }



