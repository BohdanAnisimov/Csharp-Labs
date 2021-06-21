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

namespace Lab15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.RowDefinitions.Add(new RowDefinition());
            grid.Margin = new Thickness(10, 10, 10, 10);
            textbox.SetValue(Grid.ColumnSpanProperty, 4);
            for (int i = 0; i < 4; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int j = 0; j < 7; j++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            List<Button> button = new List<Button>();
            string[] buttonText = new string[] { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "0", ".", "=", "+" };
            int buttonNum = 2;
            //Кнопка +/-
            button.Add(new Button());
            button[0].Background = Brushes.LightGray;
            button[0].Foreground = Brushes.DarkGray;
            Grid.SetColumn(button[0], 0);
            Grid.SetRow(button[0], 1);
            button[0].Content = "+/-";
            button[0].Width = 30;
            button[0].Height = 30;
            button[0].AddHandler(Button.ClickEvent, new RoutedEventHandler(button_Click));
            grid.Children.Add((button[0]));
            //Кнопка C
            button.Add(new Button());
            button[1].Background = Brushes.LightGray;
            button[1].Foreground = Brushes.DarkGray;
            Grid.SetColumn(button[1], 3);
            Grid.SetRow(button[1], 1);
            button[1].Content = "C";
            button[1].Width = 30;
            button[1].Height = 30;
            button[1].AddHandler(Button.ClickEvent, new RoutedEventHandler(button_Click));
            grid.Children.Add((button[1]));
            //TextBox
            textbox.IsReadOnly = true;
            textbox.TextAlignment = TextAlignment.Right;
            textbox.Text = "0";
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++, buttonNum++)
                {
                    button.Add(new Button());
                    button[buttonNum].Background = Brushes.LightGray;
                    button[buttonNum].Foreground = Brushes.DarkGray;
                    Grid.SetColumn(button[buttonNum], j);
                    Grid.SetRow(button[buttonNum], i + 3);
                    button[buttonNum].Content = buttonText[buttonNum - 2];
                    button[buttonNum].Width = 30;
                    button[buttonNum].Height = 30;
                    button[buttonNum].Click += new RoutedEventHandler(button_Click);
                    grid.Children.Add((button[buttonNum]));
                }
            }
        }
        float a = 0, b = 0;
        bool point = false;
        string sign;
        void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string numbers = "1234567890";

            if (numbers.Contains(Convert.ToString(btn.Content)))
            {
                if (textbox.Text == "0")
                {
                    textbox.Text = Convert.ToString(btn.Content);
                }
                else
                {
                    if ((point) && (!textbox.Text.Contains(".")))
                    {
                        textbox.Text += "," + Convert.ToString(btn.Content);
                        point = false;
                    }
                    else
                    {
                        textbox.Text += Convert.ToString(btn.Content);
                    }
                }
            }
            switch (Convert.ToString(btn.Content))
            {
                case ".":
                    point = true;
                    break;
                case "+/-":
                    a = float.Parse(textbox.Text);
                    a = -a;
                    textbox.Text = Convert.ToString(a);
                    break;
                case "C":
                    a = 0;
                    b = 0;
                    sign = "";
                    textbox.Text = Convert.ToString(a);
                    break;
                case "/":
                    Calculate();
                    a = float.Parse(textbox.Text);
                    b = a;
                    a = 0;
                    sign = Convert.ToString(btn.Content);
                    textbox.Text = Convert.ToString(a);
                    break;
                case "*":
                    Calculate();
                    a = float.Parse(textbox.Text);
                    b = a;
                    a = 0;
                    sign = Convert.ToString(btn.Content);
                    textbox.Text = Convert.ToString(a);
                    break;
                case "-":
                    Calculate();
                    a = float.Parse(textbox.Text);
                    b = a;
                    a = 0;
                    sign = Convert.ToString(btn.Content);
                    textbox.Text = Convert.ToString(a);
                    break;
                case "+":
                    Calculate();
                    a = float.Parse(textbox.Text);
                    b = a;
                    a = 0;
                    sign = Convert.ToString(btn.Content);
                    textbox.Text = Convert.ToString(a);
                    break;
                case "=":
                    Calculate();
                    break;
            }
        }

        void Calculate()
        {
            if (textbox.Text == "Ошибка")
            {
                a = 0;
                b = 0;
                sign = "";
                textbox.Text = Convert.ToString(a);
            }
            else
            {
                if (a == 0)
                {
                    a = float.Parse(textbox.Text);
                }
            }
            switch (sign)
            {
                case "/":
                    if (a == 0)
                    {
                        textbox.Text = "Ошибка";
                        break;
                    }
                    else
                    {
                        b = b / a;
                    }
                    textbox.Text = Convert.ToString(b);
                    break;
                case "*":
                    b = a * b;
                    textbox.Text = Convert.ToString(b);
                    break;
                case "-":
                    b = b - a;
                    textbox.Text = Convert.ToString(b);
                    break;
                case "+":
                    b = a + b;
                    textbox.Text = Convert.ToString(b);
                    break;
            }
        }
    }
}
