using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаб. работа №3, Вариант 2
            int x;
            int y;
            Console.WriteLine("Введите X и Y:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if((x < 0) && (y > 0))
            {
                Console.WriteLine($"Координата ({x};{y}) лежит во втором квадранте");
            }
            else
            {
                Console.WriteLine($"Координата ({x};{y}) не лежит во втором квадранте");
            }
            Console.ReadKey();
        }
    }
}
