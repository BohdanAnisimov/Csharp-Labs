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

namespace Lab16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Content = "Додати";
            button1.Foreground = Brushes.Blue;
            button2.Content = "Видалити";
            button2.Foreground = Brushes.Orange;
            textBox1.Background = Brushes.PeachPuff;
            textBox1.Text = "";
            comboBox1.Background = Brushes.Orange;
            tabPage1.Header = "Завдання 1";
            tabPage2.Header = "Завдання 2";
            buildGrid();
            CreateButtonMatrix();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }
        //Завдання 2
        TextBox textBox2 = new TextBox();
        Grid buttonGrid = new Grid();
        List<Button> button = new List<Button>();
        public void buildGrid() // Створення гріда та текстбокса
        {
            for (int i = 0; i < 4; i++)
            {
                buttonGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int j = 0; j < 8; j++)
            {
                buttonGrid.RowDefinitions.Add(new RowDefinition());
            }
            buttonGrid.Width = 200;
            buttonGrid.Height = 250;
        }

        public void CreateButtonMatrix()
        {
            tabPage2.Content = null;
            button.Clear();
            tabPage2.Content = buttonGrid;
            buttonGrid.Children.Clear();
            Grid.SetColumn(textBox2, 2);
            Grid.SetRow(textBox2, 7);
            textBox2.Background = Brushes.Green;
            textBox2.SetValue(Grid.ColumnSpanProperty, 2);
            buttonGrid.Children.Add(textBox2);
            int buttonNum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++, buttonNum++)
                {
                    button.Add(new Button());
                    button[buttonNum].Background = Brushes.LightGray;
                    button[buttonNum].Foreground = Brushes.DarkGray;
                    Grid.SetColumn(button[buttonNum], i);
                    Grid.SetRow(button[buttonNum], j);
                    button[buttonNum].Content = Convert.ToString(buttonNum);
                    button[buttonNum].Height = 30;
                    button[buttonNum].Width = 40;
                    button[buttonNum].AddHandler(Button.ClickEvent, new RoutedEventHandler(buttonClick));
                    buttonGrid.Children.Add(button[buttonNum]);
                }
            }
            textBox2.Text = "";
        }
        private void buttonClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == button[0])
            {
                button.Remove(btn);
                buttonGrid.Children.Remove(btn);
                textBox2.Text = "";
                if (button.Count == 0)
                {
                    CreateButtonMatrix();
                    textBox2.Text = "Молодець!";
                }
            }
            else
            {
                CreateButtonMatrix();
            }
        }
    }
}
