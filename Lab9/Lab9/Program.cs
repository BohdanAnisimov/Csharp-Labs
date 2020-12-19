using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    //Завданя 1 - вариант 1.1
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle() { Name = "Kolobok", Color = "Red" };
            Triangle triangle = new Triangle() { Name = "12345", Color = "Yellow" };
            Square square = new Square() { Name = "Pixel", Color = "White" };
            Picture picture = new Picture();
            Painter painter = new Painter();
            circle.radius = 5;
            circle.P();
            circle.S();
            triangle.side = 10;
            triangle.P();
            triangle.S();
            square.side = 15;
            square.P();
            square.S();
            picture.Add(circle);
            picture.Add(triangle);
            picture.Add(square);
            picture.DeleteByName("12345"); // Удаление по имени фигуры
            picture.DeleteByType("2"); // 1 - Треугольник, 2 - Круг, 3 - Квадрат
            Console.WriteLine("Фигуры картинки: ");
            picture.Draw();
            Console.ReadKey();
        }
    }
}
