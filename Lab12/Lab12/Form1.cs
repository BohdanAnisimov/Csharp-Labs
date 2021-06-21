using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(350, 500);
            List<Button> button = new List<Button>();
            string[] buttonText = new string[] { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "0", ".", "=", "+"};
            int buttonNum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++, buttonNum++)
                {
                    button.Add(new Button());
                    button[buttonNum].BackColor = Color.LightGray;
                    button[buttonNum].ForeColor = Color.DarkGray;
                    button[buttonNum].Location = new Point(10 + 40 * j, 10 + 40 * i + 60);
                    button[buttonNum].Text = buttonText[buttonNum];
                    button[buttonNum].Size = new Size(30, 30);
                    button[buttonNum].Click += new EventHandler(button_Click);
                    this.Controls.Add(button[buttonNum]);
                }
            }
            //Кнопка +/-
            button.Add(new Button());
            button[16].BackColor = Color.LightGray;
            button[16].ForeColor = Color.DarkGray;
            button[16].Location = new Point(10, 10 + 40 * 0 + 25);
            button[16].Text = "+/-";
            button[16].Size = new Size(30, 30);
            button[16].Click += new EventHandler(button_Click);
            this.Controls.Add(button[16]);
            //Кнопка C
            button.Add(new Button());
            button[17].BackColor = Color.LightGray;
            button[17].ForeColor = Color.DarkGray;
            button[17].Location = new Point(10 + 40 * 3, 10 + 40 * 0 + 25);
            button[17].Text = "C";
            button[17].Size = new Size(30, 30);
            button[17].Click += new EventHandler(button_Click);
            this.Controls.Add(button[17]);
            //TextBox
            textBox1.ReadOnly = true;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        float a = 0, b = 0;
        bool point = false;
        string sign;
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numbers = "1234567890";

            if(numbers.Contains(btn.Text))
            {
                if(textBox1.Text == "0")
                {
                    textBox1.Text = btn.Text;
                }
                else
                {
                    if((point) && (!textBox1.Text.Contains(".")))
                    {
                        textBox1.Text += "," + btn.Text;
                        point = false;
                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }
                }
            }
            switch(btn.Text)
            {
                case ".":
                    point = true;
                    break;
                case "+/-":
                    a = float.Parse(textBox1.Text);
                    a = -a;
                    textBox1.Text = Convert.ToString(a);
                    break;
                case "C":
                    a = 0;
                    b = 0;
                    sign = "";
                    textBox1.Text = Convert.ToString(a);
                    break;
                case "/":
                    Calculate();
                    a = float.Parse(textBox1.Text);
                    b = a;
                    a = 0;
                    sign = btn.Text;
                    textBox1.Text = Convert.ToString(a);
                    break;
                case "*":
                    Calculate();
                    a = float.Parse(textBox1.Text);
                    b = a;
                    a = 0;
                    sign = btn.Text;
                    textBox1.Text = Convert.ToString(a);
                    break;
                case "-":
                    Calculate();
                    a = float.Parse(textBox1.Text);
                    b = a;
                    a = 0;
                    sign = btn.Text;
                    textBox1.Text = Convert.ToString(a);
                    break;
                case "+":
                    Calculate();
                    a = float.Parse(textBox1.Text);
                    b = a;
                    a = 0;
                    sign = btn.Text;
                    textBox1.Text = Convert.ToString(a);
                    break;
                case "=":
                    Calculate();
                    break;
            }
        }

        public void Calculate()
        {
            if (textBox1.Text == "Ошибка")
            {
                a = 0;
                b = 0;
                sign = "";
                textBox1.Text = Convert.ToString(a);
            }
            else
            {
                if (a == 0)
                {
                    a = float.Parse(textBox1.Text);
                }
            }
            switch (sign)
            {
                case "/":
                    if (a == 0)
                    {
                        textBox1.Text = "Ошибка";
                        break;
                    }
                    else
                    {
                        b = b / a;
                    }
                    textBox1.Text = Convert.ToString(b);
                    break;
                case "*":
                    b = a * b;
                    textBox1.Text = Convert.ToString(b);
                    break;
                case "-":
                    b = b - a;
                    textBox1.Text = Convert.ToString(b);
                    break;
                case "+":
                    b = a + b;
                    textBox1.Text = Convert.ToString(b);
                    break;
            }
        }
    }
}
