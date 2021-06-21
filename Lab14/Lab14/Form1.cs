using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
    public partial class Form1 : Form
    {
        bool showMessage;
        int numOfMessages;
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Mouse);
            button1.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка “Ок” була натиснута");
        }
        private void checkMousePosition()
        {
            Rectangle buttonRectangle = new Rectangle(button1.Location.X, button1.Location.Y - 5, button1.Width + 20, button1.Height + 30);
            var relativePoint = this.PointToClient(Cursor.Position);
            Rectangle cursorRectangle = new Rectangle(relativePoint, Cursor.Size);
            Point bCenterCords = new Point(button1.Location.X + (button1.Width + 20) / 2, button1.Location.Y + (button1.Height + 30) / 2);
            Random rnd = new Random();
            int sizeDecreaser = rnd.Next(0, 2);
            if (cursorRectangle.IntersectsWith(buttonRectangle))
            {
                if(relativePoint.X < bCenterCords.X)
                {
                    if(relativePoint.Y < bCenterCords.Y)
                    {
                        button1.Location = new Point(button1.Location.X + 8, button1.Location.Y + 8);
                    }
                    else
                    {
                        button1.Location = new Point(button1.Location.X + 8, button1.Location.Y - 8);
                    }
                    button1.Width -= sizeDecreaser;
                    button1.Height -= sizeDecreaser;
                }
                else
                {
                    if (relativePoint.Y < bCenterCords.Y)
                    {
                        button1.Location = new Point(button1.Location.X - 8, button1.Location.Y + 8);
                    }
                    else
                    {
                        button1.Location = new Point(button1.Location.X - 8, button1.Location.Y - 8);
                    }
                    button1.Width -= sizeDecreaser;
                    button1.Height -= sizeDecreaser;
                }
            }
            if((bCenterCords.X >= this.Width) || (bCenterCords.X <= 0) || (bCenterCords.Y >= this.Height) || (bCenterCords.Y <= 20))
            {
                button1.Location = new Point(rnd.Next(0, this.Width), rnd.Next(0, this.Height));
            }
            if((button1.Width == 0) || (button1.Height == 0))
            {
                timer2.Enabled = true;
            }
        }
        private void Mouse(object sender, EventArgs e)
        {
            checkMousePosition();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Interval = 500;
            if (this.showMessage)
            {
                this.Text = "";
                this.showMessage = false;
            }
            else
            {
                this.Text = "Натисніть кнопку 'OK'!";
                this.showMessage = true;
            }
            this.numOfMessages += 1;
            bool b = this.numOfMessages > 8;
            if (b)
            {
                this.timer1.Enabled = false;
                this.showMessage = false;
                this.numOfMessages = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timer2.Interval = 500;
            if (this.showMessage)
            {
                this.Text = "";
                this.showMessage = false;
            }
            else
            {
                this.Text = "Кнопка 'ОК' не може бути натиснута!";
                this.showMessage = true;
            }
            this.numOfMessages += 1;
            bool b = this.numOfMessages > 8;
            if (b)
            {
                this.timer2.Enabled = false;
                this.showMessage = false;
            }
        }
    }
}
