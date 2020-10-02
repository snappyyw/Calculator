using System;
using System.Collections.Generic;
using System.IO;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Number_1, Number_2, Res = 0;
        char Sign;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '1';
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '2';
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '3';
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '4';
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '5';
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '6';
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '7';
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '8';
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '9';
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + '0';
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Clear();
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Number_1 = Convert.ToDouble(Result_Box.Text);
                Sign = '-';
                TextBl.Text = Number_1 + "  -";
                Result_Box.Clear();
            }
            catch
            {
                MessageBox.Show("Введите число", "Ошибка операции");
            }
        }

        private void Button_Increase_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Number_1 = Convert.ToDouble(Result_Box.Text);
                Sign = '*';
                TextBl.Text=Number_1+"  *";
                Result_Box.Clear();
            }
            catch
            {
                MessageBox.Show("Введите число", "Ошибка операции");
            }
        }

        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Number_1 = Convert.ToDouble(Result_Box.Text);
                Sign = '/';
                TextBl.Text = Number_1 + "  /";
                Result_Box.Clear();
            }
            catch
            {
                MessageBox.Show("Введите число", "Ошибка операции");
            }
        }

        private void Button_Equally_Click(object sender, RoutedEventArgs e)
        {
            Number_2 = Convert.ToDouble(Result_Box.Text);
            TextBl.Text =" ";
            switch (Sign) { 
                case '+':
                    Res = Number_1 + Number_2;
                    File.AppendAllText("text.txt", $"{Number_1} + {Number_2} = {Res}\n");
                    break;
                case '-':
                    Res = Number_1 - Number_2;
                    File.AppendAllText("text.txt", $"{Number_1} - {Number_2} = {Res}\n");
                    break;
                case '*':
                    Res = Number_1 * Number_2;
                    File.AppendAllText("text.txt", $"{Number_1} * {Number_2} = {Res}\n");
                    break;
                case '/':
                    Res = Number_1 / Number_2;
                    File.AppendAllText("text.txt", $"{Number_1} / {Number_2} = {Res}\n");
                    break;
            }
            Result_Box.Text = Res.ToString();

        }

        private void Button_Root_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBl.Text = "Sqrt("+Result_Box.Text+")";
                Result_Box.Text = (Math.Sqrt(Convert.ToDouble(Result_Box.Text))).ToString();

                File.AppendAllText("text.txt", $"Sqrt({Math.Sqrt(Convert.ToDouble(Result_Box.Text))})\n");


            }
            catch
            {
                MessageBox.Show("Введите число", "Ошибка операции");
            }
        }

        private void Button_Factorial_Click(object sender, RoutedEventArgs e)
        {
            int Factorial(int num)
            {
                int res = 1;
                for (int i = num; i > 1; i--)
                {
                    res *= i;
                }
                return res;
            }
            try
            {
                TextBl.Text = Result_Box.Text+'!';
                Result_Box.Text = (Factorial(Convert.ToInt32(Result_Box.Text))).ToString();
                File.AppendAllText("text.txt", $"{Result_Box.Text}! = {Factorial(Convert.ToInt32(Result_Box.Text))}\n");
            }
            catch
            {
                MessageBox.Show("Введите число", "Ошибка операции");
            }
        }

        private void Button_Clear_all_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Clear();
            TextBl.Text ="  ";
            Sign = '_';


        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void Button_Point_Click(object sender, RoutedEventArgs e)
        {
            Result_Box.Text = Result_Box.Text + ',';
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Number_1 = Convert.ToDouble(Result_Box.Text);
                Sign = '+';
                TextBl.Text = Number_1 + "  +";
                Result_Box.Clear();
            }
            catch
            {
                MessageBox.Show("Введите число", "Ошибка операции");
            }
        }
    }
}
