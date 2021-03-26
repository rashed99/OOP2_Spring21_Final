using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Rashed", "18-36155-1", 2.5f);
            Student s2 = new Student("Tanvir", "19-36156-1", 3.0f);
            Department d1 = new Department("Computer Science", "CIS");
            s1.Department = d1;
            s2.Department = d1;
            d1.AddStudent(s1);
            d1.AddStudent(s2);
            d1.AllStudents();

        }
    }
}