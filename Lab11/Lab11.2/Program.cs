using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    //Задание 2
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>(10);
            student.Add(new Student("Max", "Ivanov", 19));
            student.Add(new Student("Ivan", "Smirnov", 22));
            student.Add(new Student("Mikhail", "Davidov", 20));
            student.Add(new Student("Anastasia", "Kovaleva", 17));
            student.Add(new Student("Vladislav", "Gluschenko", 18));
            student.Add(new Student("Andrew", "Smith", 17));
            student.Add(new Student("David", "Troelsen", 23));
            student.Add(new Student("Andrew", "Troelsen", 28));
            student.Add(new Student("Corey", "El", 16));
            student.Add(new Student("Matthew", "Dalton", 21));

            List<Student> newList = student.FindStudent(Student.Age);
            for(int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.WriteLine();
            newList = student.FindStudent(Student.FirstName);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.WriteLine();
            newList = student.FindStudent(Student.LastName);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            //лямбды
            Console.WriteLine("-------------------------");
            newList = student.FindStudent(studentDelegate => studentDelegate.age >= 18);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.WriteLine();
            newList = student.FindStudent(studentDelegate => studentDelegate.firstName[0] == 'A');
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.WriteLine();
            newList = student.FindStudent(studentDelegate => studentDelegate.lastName.Length > 3);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.WriteLine("-------------------------");
            newList = student.FindStudent(studentDelegate => studentDelegate.age >= 20 && studentDelegate.age <= 25);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.WriteLine();
            newList = student.FindStudent(studentDelegate => studentDelegate.firstName == "Andrew");
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.WriteLine();
            newList = student.FindStudent(studentDelegate => studentDelegate.lastName == "Troelsen");
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{newList[i].firstName} {newList[i].lastName}, {newList[i].age}");
            }
            Console.ReadKey();
        }
    }
}
