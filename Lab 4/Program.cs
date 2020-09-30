using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаб. работа №4, Вариант 2
            int num;
            Console.WriteLine("Введите количество чисел в массиве:");
            num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            Console.WriteLine("Вводите числа");
            for(int i = 0; i < num; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Четный индекс:");
            for(int i = 0; i < num; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"A{i} = {array[i]}");
                }
            }
            Console.WriteLine("Нечетный индекс:");
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"A{i} = {array[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
