using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    // Вариант 2
    static class ArraySort // Задание 2
    {
        public static void Sort(this int[] num)
        {
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(num[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 4, 0, 3, 9, -1 };
            ArraySort.Sort(array);
            Console.WriteLine();
            int number = 60991;
            string str = "apple";
            float numFloat = 223.54f;
            string str2 = "hello,world";
            int l = str2.Length;
            int[] array2 = new int[5] { 0, 2, 4, 6, 8 };
            ExtentionMethods.method(number);
            ExtentionMethods.method(str);
            ExtentionMethods.method(numFloat);
            ExtentionMethods.method(str2, l);
            Console.WriteLine();
            ExtentionMethods.method7(array2);
            Console.ReadKey();
        }
    }
}
