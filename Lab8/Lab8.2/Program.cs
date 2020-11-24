using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._2
{
    class Program
    {
        /*2.	Наслідування
Використовуючи наслідування реалізувати еволюцію: 
        дисковий телефон->кнопочний телефон->мобільний з чорнобілим екраном->мобільний із кольоровим екраном->смартфон 

Мінімальний набір властивостей (враховуючи наслідування)
Дисковий телефон:
•	номер телефону
•	набір доступних символів для вибору
Кнопочний телефон:
•	набір доступних символів для вибору (додати символи, які відсутні на дисковому телефоні («*» і «#»))
Мобільний з чорнобілим екраном:
•	набір доступних символів для вибору (додати символи, які відсутні на кнопочному телефоні)
•	роздільна здатність екрану
•	фізичний розмір екрану
•	колір пристрою
мобільний із кольоровим екраном:
•	кількість кольорів, що може відображати екран
•	наявність двох сім-карт
•	другий номер телефону
Смартфон:
•	наявність сенсорного керування
•	максимальна кількість розпізнавання одночасних дотиків
•	кількість камер

Мінімальний набір методів (враховуючи наслідування)
Дисковий телефон:
•	здійснювати вихідний дзвінок
•	приймати вхідний дзвінок
Кнопочний телефон:
•	під час прийому дзвінка виводити на екран номер телефону викликаючого абонента (автовизначник номеру)
Мобільний з чорнобілим екраном:
•	метод відправки СМС
•	метод прийому СМС
мобільний із кольоровим екраном:
•	метод відправки ММС
•	метод прийому ММС
•	підказка: не забувайте за наявність другої сім-карти при наборі номеру і т.д.

Смартфон:
•	метод створення фото
•	метод створення відео
підказка: не забувайте за наявність декількох камер
*/
        class DiskTelephone
        {
            public DiskTelephone()
            {

            }
            protected string number;
            protected string symbols = "0123456789";
            protected virtual void changeSymbols()
            {
                symbols = "0123456789";
            }
            public virtual void Number()
            {
                Console.WriteLine("\nВведите номер телефона:");
                string num = Console.ReadLine();
                if (checkNumber(num))
                {
                    number = num;
                }
            }
            public virtual void Dialing()
            {
                Console.WriteLine("\nВведите номер телефона:");
                string num = Console.ReadLine();
                if (checkNumber(num))
                {
                    Console.WriteLine("Вызов...");
                }
            }
            public bool checkNumber(string num)
            {
                bool b = false;
                for(int i = 0; i < num.Length; i++)
                {
                    b = false;
                    for(int j = 0; j < symbols.Length; j++)
                    {
                        if(num[i] == symbols[j])
                        {
                            b = true;
                        }
                    }
                    if(!b)
                    {
                        break;
                    }
                }
                if(b)
                {
                    Console.WriteLine("Номер введен.");
                }
                else
                {
                    Console.WriteLine("Номер введен неверно");
                    Console.ReadKey();
                }
                return b;
            }
            public virtual void Call()
            {
                Console.WriteLine("\nВам звонят...");
                Console.ReadKey();
            }
        }
        class ButtonTelephone : DiskTelephone
        {
            protected override void changeSymbols()
            {
                symbols += "*#";
            }
            public override void Call()
            {
                Console.WriteLine("\nВам звонят...");
                Console.WriteLine("+380164929990");
            }
        }
        class MonochromePhone : ButtonTelephone
        {
            protected string sms;
            protected string resolution;
            protected string size;
            protected string color;
            protected override void changeSymbols()
            {
                symbols += "$%";
            }
            public virtual void SMS()
            {
                Console.WriteLine("\nВведите номер телефона:");
                string num = Console.ReadLine();
                if (checkNumber(num))
                {
                    Console.WriteLine("\nВведите СМС:");
                    sms = Console.ReadLine();
                    Console.WriteLine("СМС отправлено.");
                }
            }
            public void ReceiveSMS()
            {
                Console.WriteLine("\nНовое сообщение:");
                Console.WriteLine("Привет!");
            }
            public virtual void PhoneParams()
            {
                Console.WriteLine("\nВведите характеристики вашего телефона: " +
                    "\nРазрешение экрана" +
                    "\nРазмер экрана" +
                    "\nЦвет телефона");
                resolution = Console.ReadLine();
                size = Console.ReadLine();
                color = Console.ReadLine();
                Console.WriteLine("Характеристики введены.");
            }
        }
        class ColorPhone : MonochromePhone
        {
            protected int numOfColors;
            protected int numOfSim = 1;
            protected string number2;
            public override void PhoneParams()
            {
                Console.WriteLine("\nВведите характеристики вашего телефона: " +
                    "\nРазрешение экрана" +
                    "\nРазмер экрана" +
                    "\nЦвет телефона" +
                    "\nКоличество цветов экрана" +
                    "\nКоличество сим-карт (1/2)");
                resolution = Console.ReadLine();
                size = Console.ReadLine();
                color = Console.ReadLine();
                numOfColors = Convert.ToInt32(Console.ReadLine());
                do
                {
                    numOfSim = Convert.ToInt32(Console.ReadLine());
                } while ((numOfSim != 1) && (numOfSim != 2));
                Console.WriteLine("Характеристики введены.");
            }
            public override void Number()
            {
                if (numOfSim == 2)
                {
                    int i;
                    do
                    {
                        Console.WriteLine("Для какой сим-карты выбирается номер?");
                        i = Convert.ToInt32(Console.ReadLine());
                    } while ((i != 1) && (i != 2));
                    if (i == 1)
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            number = num;
                        };
                    }
                    else
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            number2 = num;
                        };
                    }
                }
                else
                {
                    Console.WriteLine("\nВведите номер телефона:");
                    string num = Console.ReadLine();
                    if (checkNumber(num))
                    {
                        number = num;
                    };
                }
            }
            public void ReceiveMMS()
            {
                Console.WriteLine("\nПолучено ММC.");
            }
            public override void Dialing()
            {
                if (numOfSim == 2)
                {
                    int i;
                    do
                    {
                        Console.WriteLine("С какой сим-карты звоним?");
                        i = Convert.ToInt32(Console.ReadLine());
                    } while ((i != 1) && (i != 2));
                    if (i == 1)
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            Console.WriteLine("Вызов...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            Console.WriteLine("Вызов...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nВведите номер телефона:");
                    string num = Console.ReadLine();
                    if (checkNumber(num))
                    {
                        Console.WriteLine("Вызов...");
                    }
                }
            }
            public override void SMS()
            {
                if (numOfSim == 2)
                {
                    int i;
                    do
                    {
                        Console.WriteLine("С какой сим-карты звоним?");
                        i = Convert.ToInt32(Console.ReadLine());
                    } while ((i != 1) && (i != 2));
                    if (i == 1)
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            Console.WriteLine("\nВведите СМС:");
                            sms = Console.ReadLine();
                            Console.WriteLine("СМС отправлено.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            Console.WriteLine("\nВведите СМС:");
                            sms = Console.ReadLine();
                            Console.WriteLine("СМС отправлено.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nВведите номер телефона:");
                    string num = Console.ReadLine();
                    if (checkNumber(num))
                    {
                        Console.WriteLine("\nВведите СМС:");
                        sms = Console.ReadLine();
                        Console.WriteLine("СМС отправлено.");
                    }
                }
            }
            public void MMS()
            {
                if (numOfSim == 2)
                {
                    int i;
                    do
                    {
                        Console.WriteLine("С какой сим-карты звоним?");
                        i = Convert.ToInt32(Console.ReadLine());
                    } while ((i != 1) || (i != 2));
                    if (i == 1)
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            Console.WriteLine("ММС отправлено.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        string num = Console.ReadLine();
                        if (checkNumber(num))
                        {
                            Console.WriteLine("ММС отправлено.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nВведите номер телефона:");
                    string num = Console.ReadLine();
                    if (checkNumber(num))
                    {
                        Console.WriteLine("ММС отправлено.");
                    }
                }
            }
        }
        class Smartphone : ColorPhone
        {
            protected bool touch = false;
            protected int numOfTouches;
            protected int numOfCameras = 1;
            public override void PhoneParams()
            {
                Console.WriteLine("\nВведите характеристики вашего телефона: " +
                    "\nРазрешение экрана" +
                    "\nРазмер экрана" +
                    "\nЦвет телефона" +
                    "\nКоличество цветов экрана" +
                    "\nКоличество сим-карт (1/2) " +
                    "\nНаличие сенсорного управления (если есть, напишите 1, нет - иное число)" +
                    "\nМакс. кол-во одновременных нажатий (если сен управления нет, то пункт пропускается)" +
                    "\nКоличество камер (1/2)");
                resolution = Console.ReadLine();
                size = Console.ReadLine();
                color = Console.ReadLine();
                numOfColors = Convert.ToInt32(Console.ReadLine());
                do
                {
                    numOfSim = Convert.ToInt32(Console.ReadLine());
                } while ((numOfSim != 1) && (numOfSim != 2));
                if(Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    touch = true;
                }
                if(touch)
                {
                    numOfTouches = Convert.ToInt32(Console.ReadLine());
                }
                do
                {
                    numOfCameras = Convert.ToInt32(Console.ReadLine());
                } while ((numOfCameras != 1) && (numOfCameras != 2));
                Console.WriteLine("Характеристики введены.");
            }
            public void Camera()
            {
                Console.WriteLine("Фото (1) или видео (2)?");
                int m;
                do
                {
                    m = Convert.ToInt32(Console.ReadLine());
                } while ((m != 1) && (m != 2));
                if (m == 1)
                {
                    if (numOfCameras == 2)
                    {
                        int i;
                        do
                        {
                            Console.WriteLine("С какой камеры фотографируем? (1 - тыловая камера, 2 - фронтальная камера");
                            i = Convert.ToInt32(Console.ReadLine());
                        } while ((i != 1) || (i != 2));
                        if (i == 1)
                        {
                            Console.WriteLine("Фото сделано на тыловую камеру.");
                        }
                        else
                        {
                            Console.WriteLine("Фото сделано на фронтальную камеру.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Фото сделано на тыловую камеру.");
                    }
                }
                else
                {
                    if (numOfCameras == 2)
                    {
                        int i;
                        do
                        {
                            Console.WriteLine("С какой камеры снимаем видео? (1 - тыловая камера, 2 - фронтальная камера");
                            i = Convert.ToInt32(Console.ReadLine());
                        } while ((i != 1) || (i != 2));
                        if (i == 1)
                        {
                            Console.WriteLine("Видео снято на тыловую камеру.");
                        }
                        else
                        {
                            Console.WriteLine("Видео снято на фронтальную камеру.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Видео снято на тыловую камеру.");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.WriteLine("\nВыберите телефон:" +
                    "\n 1 - Дисковый телефон" +
                    "\n 2 - Кнопочный телефон" +
                    "\n 3 - Черно-белый телефон" +
                    "\n 4 - Цветной телефон" +
                    "\n 5 - Смартфон" +
                    "\n 0 - Выход");
                menu = Convert.ToInt32(Console.ReadLine());
                switch(menu)
                {
                    case 1:
                        DiskTelephone Dphone = new DiskTelephone();
                        int Dmenu;
                        do
                        {
                            Console.WriteLine("\nДисковый телефон. Что хотите сделать?" +
                                "\n 1 - Позвонить по номеру телефона" +
                                "\n 2 - Ожидать звонка" +
                                "\n 3 - Выбрать себе номер телефона" +
                                "\n 0 - Убрать телефон");
                            Dmenu = Convert.ToInt32(Console.ReadLine());
                            switch(Dmenu)
                            {
                                case 1:
                                    Dphone.Dialing();
                                    break;
                                case 2:
                                    Dphone.Call();
                                    break;
                                case 3:
                                    Dphone.Number();
                                    break;
                            }
                        } while (Dmenu != 0);
                        break;
                    case 2:
                        ButtonTelephone Bphone = new ButtonTelephone();
                        int Bmenu;
                        do 
                        {
                            Console.WriteLine("\nКнопочный телефон. Что хотите сделать?" +
                                "\n 1 - Позвонить по номеру телефона" +
                                "\n 2 - Ожидать звонка" +
                                "\n 3 - Выбрать себе номер телефона" +
                                "\n 0 - Убрать телефон");
                            Bmenu = Convert.ToInt32(Console.ReadLine());
                            switch (Bmenu)
                            {
                                case 1:
                                    Bphone.Dialing();
                                    break;
                                case 2:
                                    Bphone.Call();
                                    break;
                                case 3:
                                    Bphone.Number();
                                    break;
                            }
                        } while (Bmenu != 0);
                        break;
                    case 3:
                        MonochromePhone Mphone = new MonochromePhone();
                        int Mmenu;
                        do
                        {
                            Console.WriteLine("\nЧерно-белый телефон. Что хотите сделать?" +
                                "\n 1 - Позвонить по номеру телефона" +
                                "\n 2 - Ожидать звонка" +
                                "\n 3 - Отправить СМС " +
                                "\n 4 - Ожидать СМС" +
                                "\n 5 - Ввести характеристики телефона" +
                                "\n 6 - Выбрать себе номер телефона" +
                                "\n 0 - Убрать телефон");
                            Mmenu = Convert.ToInt32(Console.ReadLine());
                            switch (Mmenu)
                            {
                                case 1:
                                    Mphone.Dialing();
                                    break;
                                case 2:
                                    Mphone.Call();
                                    break;
                                case 3:
                                    Mphone.SMS();
                                    break;
                                case 4:
                                    Mphone.ReceiveSMS();
                                    break;
                                case 5:
                                    Mphone.PhoneParams();
                                    break;
                                case 6:
                                    Mphone.Number();
                                    break;
                            }
                        } while (Mmenu != 0);
                        break;
                    case 4:
                        ColorPhone Cphone = new ColorPhone();
                        int Cmenu;
                        do
                        {
                            Console.WriteLine("\nЦветной телефон. Что хотите сделать?" +
                                "\n 1 - Позвонить по номеру телефона" +
                                "\n 2 - Ожидать звонка\n 3 - Отправить СМС " +
                                "\n 4 - Ожидать СМС" +
                                "\n 5 - Ввести характеристики телефона" +
                                "\n 6 - Выбрать себе номер телефона" +
                                "\n 7 - Отправить ММС" +
                                "\n 8 - Ожидать ММС" +
                                "\n 0 - Убрать телефон");
                            Cmenu = Convert.ToInt32(Console.ReadLine());
                            switch (Cmenu)
                            {
                                case 1:
                                    Cphone.Dialing();
                                    break;
                                case 2:
                                    Cphone.Call();
                                    break;
                                case 3:
                                    Cphone.SMS();
                                    break;
                                case 4:
                                    Cphone.ReceiveSMS();
                                    break;
                                case 5:
                                    Cphone.PhoneParams();
                                    break;
                                case 6:
                                    Cphone.Number();
                                    break;
                                case 7:
                                    Cphone.MMS();
                                    break;
                                case 8:
                                    Cphone.ReceiveMMS();
                                    break;
                            }
                        } while (Cmenu != 0);
                        break;
                    case 5:
                        Smartphone Sphone = new Smartphone();
                        int Smenu;
                        do
                        {
                            Console.WriteLine("\nЦветной телефон. Что хотите сделать?" +
                                "\n 1 - Позвонить по номеру телефона" +
                                "\n 2 - Ожидать звонка\n 3 - Отправить СМС " +
                                "\n 4 - Ожидать СМС" +
                                "\n 5 - Ввести характеристики телефона" +
                                "\n 6 - Выбрать себе номер телефона" +
                                "\n 7 - Отправить ММС" +
                                "\n 8 - Ожидать ММС" +
                                "\n 9 - Камера" +
                                "\n 0 - Убрать телефон");
                            Smenu = Convert.ToInt32(Console.ReadLine());
                            switch (Smenu)
                            {
                                case 1:
                                    Sphone.Dialing();
                                    break;
                                case 2:
                                    Sphone.Call();
                                    break;
                                case 3:
                                    Sphone.SMS();
                                    break;
                                case 4:
                                    Sphone.ReceiveSMS();
                                    break;
                                case 5:
                                    Sphone.PhoneParams();
                                    break;
                                case 6:
                                    Sphone.Number();
                                    break;
                                case 7:
                                    Sphone.MMS();
                                    break;
                                case 8:
                                    Sphone.ReceiveMMS();
                                    break;
                                case 9:
                                    Sphone.Camera();
                                    break;
                            }
                        } while (Smenu != 0);
                        break;
                }
            } while (menu != 0);
        }
    }
}
