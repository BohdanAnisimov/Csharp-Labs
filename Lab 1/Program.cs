using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаб. работа №1, Вариант 2
            float U;
            float I;
            float R;
            string str;
            Console.WriteLine("Введите значение напряжения:");
            str = Console.ReadLine();
            U = Convert.ToInt32(str);
            Console.WriteLine("Введите значение сопротивления:");
            str = Console.ReadLine();
            R = Convert.ToInt32(str);
            I = U / R;
            Console.WriteLine($"Сила тока: {I}");
            Console.ReadKey();
        }
    }
}
