using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Triangle : Shape
    {
        public int numOfAngles = 3;
        public float side;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int NumOfAngles { get; set; }
        public override void S()
        {
            Console.Write("Площать данного треугольника: ");
            Console.WriteLine(((float)Math.Sqrt(3f) * side * side) / 4);
        }
        public override void P()
        {
            Console.Write("Периметр данного треугольника: ");
            Console.WriteLine(side * 3);
        }
        public void Sides(float side)
        {
            this.side = side;
        }
        public override void Draw()
        {
            Console.WriteLine($" Фигура - Треугольник\n Имя - {0}\n Площадь - {1}\nПериметр - {2}\n Цвет - {3}", Name, ((float)Math.Sqrt(3f) * side * side) / 4, side * 4, Color);
        }
    }
}
