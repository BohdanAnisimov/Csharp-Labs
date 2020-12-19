using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Square : Shape, IDraw
    {

        public int numOfAngles = 4;
        public float side;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int NumOfAngles { get; set; }
        public override void S()
        {
            Console.Write("Площадь данного квадрата: ");
            Console.WriteLine(this.side * this.side);
        }
        public override void P()
        {
            Console.Write("Периметр данного квадрата: ");
            Console.WriteLine(this.side * 4);
        }
        public void Sides(float side)
        {
            this.side = side;
        }
        public override void Draw()
        {
            Console.WriteLine($" Фигура - Квадрат\n Имя - {0}\n Площадь - {1}\nПериметр - {2}\n Цвет - {3}", Name, this.side * this.side, this.side * 4, Color);
        }
    }
}
