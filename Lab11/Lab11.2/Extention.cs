using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    static class Extention
    {
        public static List<Student> FindStudent(this List<Student> student, StudentPredicateDelegate studentDelegate)
        {
            List<Student> newStudentList = new List<Student>();
            for(int i = 0; i < 10; i++)
            {
                if(studentDelegate(student[i]))
                {
                    newStudentList.Add(student[i]);
                }
            }
            return newStudentList;
        }
    }
}
