using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            // Завдання 1
            button1.Text = "Додати";
            button1.ForeColor = Color.Blue;
            button2.Text = "Видалити";
            button2.ForeColor = Color.Orange;
            textBox1.BackColor = Color.PeachPuff;
            comboBox1.BackColor = Color.Orange;
            tabPage1.Text = "Завдання 1";
            tabPage2.Text = "Завдання 2";
            CreateButtonMatrix();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        //Завдання 2
        List<Button> button = new List<Button>();
        TextBox textBox2 = new TextBox();
        public void CreateButtonMatrix()
        {
            button.Clear();
            tabPage2.Controls.Clear();
            int buttonNum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++, buttonNum++)
                {
                    button.Add(new Button());
                    button[buttonNum].BackColor = Color.LightGray;
                    button[buttonNum].ForeColor = Color.DarkGray;
                    button[buttonNum].Location = new Point(10 + 40 * j, 10 + 30 * i);
                    button[buttonNum].Text = Convert.ToString(buttonNum);
                    button[buttonNum].Size = new Size(40, 30);
                    button[buttonNum].Click += new EventHandler(buttonClick);
                    tabPage2.Controls.Add(button[buttonNum]);
                }
            }
            textBox2.Location = new Point(90, 160);
            textBox2.Text = "";
            textBox2.BackColor = Color.Green;
            tabPage2.Controls.Add(textBox2);
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn == button[0])
            {
                button.Remove(btn);
                tabPage2.Controls.Remove(btn);
                textBox2.Text = "";
                if(button.Count == 0)
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
