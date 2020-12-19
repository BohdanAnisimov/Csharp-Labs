using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle : Shape, IDraw
    {
        public int numOfAngles = 0;
        public float radius;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int NumOfAngles { get; set; }
        public override void S()
        {
            Console.Write("Площадь данного круга: ");
            Console.WriteLine(3.14 * this.radius * this.radius);
        }
        public override void P()
        {
            Console.Write("Периметр данного круга: ");
            Console.WriteLine(this.radius);
        }
        public void Sides(float radius)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($" Фигура - Круг\n Имя - {0}\n Площадь - {1}\nПериметр - {2}\n Цвет - {3}", Name, 3.14 * this.radius * this.radius, this.radius, Color);
        }
    }
}
