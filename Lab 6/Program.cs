using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        //завдання 1
        static void method(int n)
        {
            string Str = Convert.ToString(n);
            int l = Str.Length - 1;
            for(int i = l; i >= 0; i--)
            {
                Console.Write(Str[i]);
            }
            Console.WriteLine();
        }
        //завдання 2
        static void method(string str)
        {
            int l = str.Length - 1;
            for(int i = l; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        //завдання 3
        static void method(float num)
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
        //завдання 4
        static void method(string str, int l)
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
            Console.WriteLine();
        }
        //завдання 5 - методи перевантажені
        //завдання 6
        static void function(int n, int pos, params int[] l) //1
        {
            string num = Convert.ToString(n);
            l[0] = num.Length - 1 - pos;
            if (l[0] < 0)
            {
                return;
            }
            Console.Write(num[l[0]]);
            pos += 1;
            function(n, pos, l[0]);
        }
        static void function(string str, int pos, params int[] l) //2
        {
            l[0] = str.Length - 1 - pos;
            if (l[0] < 0)
            {
                return;
            }
            Console.Write(str[l[0]]);
            pos += 1;
            function(str, pos, l[0]);
        }
        static void function(float num, int pos, params int[] l) //3
        {
            string str = Convert.ToString(num);
            l[0] = str.Length;
            if (l[0] < 0)
            {
                return;
            }
            int point = l[1];
            if(point == 0)
            {
                for (int i = 0; i < l[0]; i++)
                {
                    if ((str[i] == '.') || (str[i] == ','))
                    {
                        point = i;
                    }
                }
            }
            if(point <= pos)
            {
                Console.Write('.');
                for (int i = l[0] - 1; i > point; i--)
                {
                    Console.Write(str[i]);
                }
                return;
            }
            else
            {
                Console.Write(str[point - pos - 1]);
                pos += 1;
            }
            function(num, pos, l[0], point);
        }
        static void function(int pos, string str, params int[] l) //4
        {
            l[0] = str.Length;
            if (l[0] < 0)
            {
                return;
            }
            int point = l[1];
            if (point == 0)
            {
                for (int i = 0; i < l[0]; i++)
                {
                    if (str[i] == ',')
                    {
                        point = i;
                    }
                }
            }
            if (point <= pos)
            {
                Console.Write('.');
                for (int i = l[0] - 1; i > point; i--)
                {
                    Console.Write(str[i]);
                }
                return;
            }
            else
            {
                Console.Write(str[point - pos - 1]);
                pos += 1;
            }
            function(pos, str, l[0], point);
        }
        //завдання 7
        static void method7(int[] array)
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
        //завдання 8
        static void methodRef(ref int[] array)
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
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            float numFloat = (float)Convert.ToDouble(Console.ReadLine());
            string str2 = Console.ReadLine();
            int l = str2.Length;
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[5] { 0, 2, 4, 6, 8 };
            method(number);
            method(str);
            method(numFloat);
            method(str2, l);
            function(number, 0, 0);
            Console.WriteLine();
            function(str, 0, 0);
            Console.WriteLine();
            function(numFloat, 0, 0, 0);
            Console.WriteLine();
            function(0, str2, 0, 0);
            Console.WriteLine();
            method7(array);
            Console.WriteLine();
            methodRef(ref array2);
            Console.ReadKey();
        }
    }
}
