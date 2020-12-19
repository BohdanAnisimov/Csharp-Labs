using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Picture : IDraw
    {
        int n;
        List<Shape> Shape = new List<Shape>();
        public Picture(int n)
        {
            this.n = n;
        }
        public int Num
        {
            get
            {
                return Shape.Count;
            }
        }
        public Picture() 
        {
            
        }
        public void Add(Shape newShape)
        {
            Shape.Add(newShape);
        }
        public void DeleteByName(string name)
        {
            bool b = false;
            for(int i = 0; i < Shape.Count; i++)
            {
                if(Shape[i].Name == name)
                {
                    Shape.RemoveAt(i);
                    i--;
                    b = true;
                }
            }
            if(b)
            {
                Console.WriteLine("Удаление прошло успешно");
            }
            else
            {
                Console.WriteLine("Подходящих элементов для удаления не нашлось.");
            }
        }
        public void DeleteByType(string type)
        {
            switch(type)
            {
                case "1":
                    Triangle triangle = new Triangle();
                    bool b = false;
                    for (int i = 0; i < Shape.Count; i++)
                    {
                        if (Shape[i].GetType() == triangle.GetType())
                        {
                            Shape.RemoveAt(i);
                            i--;
                            b = true;
                        }
                    }
                    if (b)
                    {
                        Console.WriteLine("Удаление прошло успешно");
                    }
                    else
                    {
                        Console.WriteLine("Подходящих элементов для удаления не нашлось.");
                    }
                    break;
                case "2":
                    Circle circle = new Circle();
                    b = false;
                    for (int i = 0; i < Shape.Count; i++)
                    {
                        if (Shape[i].GetType() == circle.GetType())
                        {
                            Shape.RemoveAt(i);
                            i--;
                            b = true;
                        }
                    }
                    if (b)
                    {
                        Console.WriteLine("Удаление прошло успешно");
                    }
                    else
                    {
                        Console.WriteLine("Подходящих элементов для удаления не нашлось.");
                    }
                    break;
                case "3":
                    Square square = new Square();
                    b = false;
                    for (int i = 0; i < Shape.Count; i++)
                    {
                        if (Shape[i].GetType() == square.GetType())
                        {
                            Shape.RemoveAt(i);
                            i--;
                            b = true;
                        }
                    }
                    if (b)
                    {
                        Console.WriteLine("Удаление прошло успешно");
                    }
                    else
                    {
                        Console.WriteLine("Подходящих элементов для удаления не нашлось.");
                    }
                    break;
                default:
                    Console.WriteLine("Подходящих элементов для удаления не нашлось.");
                    break;
            }
        }
        public Shape this[int index]
        {
            get
            {
                return Shape[index];
            }
            set
            {
                Shape[index] = value;
            }
        }
        public void Draw()
        {
            for(int i = 0; i < Shape.Count; i++)
            {
                //Console.WriteLine($" Фигура - {Shape[i].GetType()}\n Имя - {0}\n Площадь - {1}\nПериметр - {2}\n Цвет - {3}", Shape[i].Name, Shape[i].S(), Shape[i].P(), Shape[i].Color);
                string typeOfShape = "Nan";
                if(Shape[i] is Square)
                {
                    typeOfShape = "Квадрат";
                }
                if (Shape[i] is Circle)
                {
                    typeOfShape = "Круг";
                }
                if (Shape[i] is Triangle)
                {
                    typeOfShape = "Треугольник";
                }
                Console.WriteLine($" Фигура - {typeOfShape}\n Имя - {Shape[i].Name}");
                Console.Write(" Площадь - ");
                Shape[i].S();
                Console.WriteLine();
                Console.Write(" Периметр - ");
                Shape[i].P();
                Console.WriteLine();
                Console.WriteLine($" Цвет - {Shape[i].Color}");
            }
        }
    }
}
