using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостійна_Робота_11._11._2020
{
    /*Варіант 2
     2.	Створити клас Cars, в якому міститься набір з 5 машин японського виробництва, для кожної з машин визначені 4характеристики: 
    колекція кольорів в якому вона представлена, рік випуску і ціна. 
    Четверту характеристику оберіть самі. 
    Реалізувати можливість для покупця обрати машину з набору за її параметрами. 
    Повідомити якщо не існує машини з потрібними параметрами, 
    якщо існує – вивести на екран повний опис машини. */
    class Auto
    {
        public int price { get; set; }
        public List<string> colors;
        public int speed { get; set; }
        public int year { get; set; }
        public Auto(int price, List<string> colors, int speed, int year)
        {
            this.colors = new List<string>(3);
            this.price = price;
            for(int i = 0; i < 3; i++)
            {
                this.colors.Add(colors[i]);
            }
            this.speed = speed;
            this.year = year;
        }
    }
    class Cars
    {
        List<Auto> car = new List<Auto>(5);
        public void NewCar(int price, List<string> color, int speed, int year)
        {
            Auto auto = new Auto(price, color, speed, year);
            car.Add(auto);
        }
        public int NumberOfAutos()
        {
            return car.Count;
        }
        public void ShowAutos()
        {
            for (int i = 0; i < NumberOfAutos(); i++)
            {
                Console.WriteLine($"{i + 1}. {car[i].price}, {car[i].colors}, {car[i].speed} км/ч, {car[i].year} г.");
            }
        }
        public void Sort(int price, string color, int speed, int year)
        {
            List<Auto> sortedList = new List<Auto>();
            for (int i = 0; i < NumberOfAutos(); i++)
            {
                sortedList.Add(car[i]);
            }
            if (price != 0)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].price != price)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (color != "0")
            {
                bool b = false;
                for (int i = 0; i < sortedList.Count; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if(sortedList[i].colors[j] == color)
                        {
                            b = true;
                        }
                    }
                    if(!b)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (speed != 0)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].speed != speed)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (year != 0)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].year != year)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if(sortedList.Count == 0)
            {
                Console.WriteLine("Подходящих автомобилей не найдено");
            }
            else
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    Console.Write($"{i + 1}.");
                    Console.Write($"{sortedList[i].price} $, ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{sortedList[i].colors[j]} ");
                    }
                    Console.WriteLine($"{sortedList[i].speed} км/ч, {sortedList[i].year} г.");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.NewCar(10000, new List<string>(3) {"White", "Blue", "Purple"}, 150, 2008);
            car.NewCar(20000, new List<string>(3) { "Red", "Blue", "White" }, 170, 2015);
            car.NewCar(25000, new List<string>(3) { "Yellow", "Purple", "Blue" }, 170, 2008);
            car.NewCar(25000, new List<string>(3) { "Red", "White", "Grey" }, 180, 2018);
            car.NewCar(30000, new List<string>(3) { "White", "Black", "Grey" }, 190, 2004);
                Console.WriteLine("Для поиска авто вписывайте: \nЦена\nЦвет\nСкорость\nГод\nЕсли параметр неизвестен, пишите 0");
                int p = Convert.ToInt32(Console.ReadLine());
                string c = Console.ReadLine();
                int s = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                car.Sort(p, c, s, y);
                Console.ReadKey();
        }
    }
}
