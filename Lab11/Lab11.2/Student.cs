using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    delegate bool StudentPredicateDelegate(Student student);
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public static bool Age(Student student)
        {
            bool b = false;
            if(student.age >= 18)
            {
                b = true;
            }
            return b;
        }
        public static bool FirstName(Student student)
        {
            bool b = false;
            if (student.firstName[0] == 'A')
            {
                b = true;
            }
            return b;
        }
        public static bool LastName(Student student)
        {
            bool b = false;
            if (student.lastName.Length > 3)
            {
                b = true;
            }
            return b;
        }
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
