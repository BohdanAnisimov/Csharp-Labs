using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    /*Створити ліст трінгових змінних, дозволити можливість заповнення з калвіатури. 
     * Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). Скопіювати ліст в масив.*/
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Введите пять слов (eng):");
            for (int i = 0; i < 5; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("Введите слово для проверки (eng):");
            string word = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (word == list[i])
                {
                    Console.WriteLine($"Слово {list[i]} имеет индекс {i}.");
                }
            }
            string[] array = new string[5];
            for(int i = 0; i < 5; i++)
            {
                array[i] = list[i];
            }
            Console.WriteLine("Скопированный массив слов: ");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
