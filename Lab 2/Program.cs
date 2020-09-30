using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаб. работа №2, Вариант 2
            double sum = 0.0;
            double nn, nk, k;
            nn = Convert.ToDouble(Console.ReadLine());
            nk = Convert.ToDouble(Console.ReadLine());
            k = nn;
            while ((nn >= 0) && (nn <= nk))
            {
                sum += (k * k + Math.Pow(-1, k) * k - 1) / (k * k + 1);
                Console.WriteLine(sum);
                k++;
                nn = k;
            }
            Console.WriteLine($"Sum: {sum}");
            Console.ReadKey();

        }
    }
}
