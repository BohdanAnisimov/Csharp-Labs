using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    static class ExtentionMethods
    {
        public static void method(this int n)
        {
            string Str = Convert.ToString(n);
            int l = Str.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                Console.Write(Str[i]);
            }
            Console.WriteLine();
        }
        public static void method(this string str)
        {
            int l = str.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        public static void method(this float num)
        {
            string str = Convert.ToString(num);
            int l = str.Length;
            int point = l;
            for (int i = 0; i < l; i++)
            {
                if ((str[i] == '.') || (str[i] == ','))
                {
                    point = i;
                }
            }
            for (int i = point - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write('.');
            for (int i = l - 1; i > point; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        public static void method(string str, int l)
        {
            int point = l;
            for (int i = 0; i < l; i++)
            {
                if (str[i] == ',')
                {
                    point = i;
                }
            }
            for (int i = point - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write(',');
            for (int i = l - 1; i > point; i--)
            {
                Console.Write(str[i]);
            }
        }
        public static void method7(this int[] array)
        {
            int l = array.Length;
            int temp;
            for (int i = 0; i < l / 2; i++)
            {
                temp = array[i];
                array[i] = array[l - i - 1];
                array[l - i - 1] = temp;
            }
            for (int i = 0; i < l; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
