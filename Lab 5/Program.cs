using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаб. работа №5, Вариант 2
            /*Дана матриця розміру m * n. Знайти суми елементів всіх її 1)
            парних; 2) непарних строк (стовпчиків).*/
            int n, m;
            int sum = 0;
            Console.WriteLine("Введите m и n массива:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m, n];
            Console.WriteLine("Вводите числа в массив:");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += array[i, j];
                }
                i++;
            }
            Console.WriteLine($"Сумма чисел нечетных строк = {sum}");
            sum = 0;
            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += array[i, j];
                }
                i++;
            }
            Console.WriteLine($"Сумма чисел четных строк = {sum}");
            sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += array[i, j];
                    j++;
                }
            }
            Console.WriteLine($"Сумма чисел нечетных столбцов = {sum}");
            sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    sum += array[i, j];
                    j++;
                }
            }
            Console.WriteLine($"Сумма чисел четных столбцов = {sum}");
            sum = 0;
            Console.ReadKey();
        }
    }
}
