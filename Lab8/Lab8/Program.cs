using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    /*1.Гараж шейха
    Створити клас, який буде уособлювати Гараж Шейха. Створити клас, який буде уособлювати Автомобіль.
    В Гаражі зберігається необмежена кількість Автомобілів. Шейх може купити новий Автомобіль в Гараж, чи викинути існуючий.
    Також Шейх може взяти машину покататися за певними критеріями: за ім’ям машини, кольором, швидкістю, року випуску
    (за всіма параметрами, або частково). Після введення параметру на екран виводяться всі Автомобілі з Гаражу Шейха, які
    підходять за цими параметрами*/

    class Auto
    {
        public string name { get; set; }
        public string color { get; set; }
        public int speed { get; set; }
        public int year { get; set; }
        public Auto(string name, string color, int speed, int year)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            this.year = year;
        }
    }
    class Garage
    {
        List<Auto> garage = new List<Auto>();
        public void NewCar(string name, string color, int speed, int year)
        {
            Auto auto = new Auto(name, color, speed, year);
            garage.Add(auto);
        }
        public int NumberOfAutos()
        {
            return garage.Count;
        }
        public void ShowAutos()
        {
            for (int i = 0; i < NumberOfAutos(); i++)
            {
                Console.WriteLine($"{i + 1}. {garage[i].name}, {garage[i].color}, {garage[i].speed} км/ч, {garage[i].year} г.");
            }
        }
        public void TakeAwayAuto(int i)
        {
            garage.RemoveAt(i);
        }
        public void Sort(string name, string color, int speed, int year)
        {
            List<Auto> sortedList = new List<Auto>();
            for (int i = 0; i < NumberOfAutos(); i++)
            {
                sortedList.Add(garage[i]);
            }
            if (name != "0")
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].name != name)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (color != "0")
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].color != color)
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
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedList[i].name}, {sortedList[i].color}, {sortedList[i].speed} км/ч, {sortedList[i].year} г.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.NewCar("BMW", "Blue", 180, 2010);
            garage.NewCar("Lamborghini", "Yellow", 200, 2010);
            garage.NewCar("BMW", "White", 170, 2012);
            garage.NewCar("Bugatti", "Grey", 210, 2018);
            garage.NewCar("BMW", "Blue", 175, 2006);
            int m;
            do
            {
                Console.WriteLine("1 - Список автомобилей\n2 - Добавить автомобиль\n3 - Выкинуть автомобиль\n4 - Выбрать автомобиль для поездки\n0 - Выйти из меню");
                m = Convert.ToInt32(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        if (garage.NumberOfAutos() == 0)
                        {
                            Console.WriteLine("У Вас нет ни одного автомобиля");
                        }
                        else
                        {
                            garage.ShowAutos();
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Для добавления нового авто вписывайте: \nНазвание\nЦвет\nСкорость\nГод");
                        string name = Console.ReadLine();
                        string color = Console.ReadLine();
                        int speed = Convert.ToInt32(Console.ReadLine());
                        int year = Convert.ToInt32(Console.ReadLine());
                        garage.NewCar(name, color, speed, year);
                        break;
                    case 3:
                        Console.WriteLine("Какой автомобиль хотите убрать?");
                        garage.ShowAutos();
                        int num;
                        do
                        {
                            num = Convert.ToInt32(Console.ReadLine()) - 1;
                            if ((num > garage.NumberOfAutos()) || (num < 0))
                            {
                                Console.WriteLine("Такого авто нет в списке, введите другой номер в списке");
                            }
                        } while (((num > garage.NumberOfAutos()) || (num < 0)));
                        garage.TakeAwayAuto(num);
                        break;
                    case 4:
                        Console.WriteLine("Для поиска авто вписывайте: \nНазвание\nЦвет\nСкорость\nГод\nЕсли параметр неизвестен, пишите 0");
                        string n = Console.ReadLine();
                        string c = Console.ReadLine();
                        int s = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        garage.Sort(n, c, s, y);
                        break;
                }
            } while (m != 0);
        }
    }
}

