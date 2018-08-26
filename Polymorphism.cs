using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ITStudent student1 = new ITStudent();
            BusinessStudent student2= new BusinessStudent();
            student1.gradeA = 99;
            student1.gradeB = 60;
            student1.gradeC = 84;
            Console.WriteLine("ITStudent Average Grade:");
            Console.WriteLine(student1.GetGrade()/3);

            student2.gradeA = 22;
            student2.gradeB = 33;
            student2.gradeC = 44;
            Console.WriteLine("BusinessStudent Average Grade:");
            Console.WriteLine(student2.GetGrade() / 3);

            Console.ReadLine();
            Student[] stdArray = new Student[2];
            stdArray[0] = student1;
            stdArray[1] = student2;

        }
    }

    class Student
    {
        public int gradeA { get; set; }
        public int gradeB { get; set; }
        public int gradeC { get; set; }
    }

    class ITStudent : Student
    {
        public int MyProperty { get; set; }
        public int GetGrade()
        {
            return gradeA + gradeB + gradeC;
        }
    }
     class BusinessStudent : Student
     {
            public virtual int GetGrade()
            {
                if (gradeA > gradeB && gradeA > gradeC)
                    return gradeA;

                if (gradeB > gradeA && gradeB > gradeC)
                    return gradeB;

                else
                    return gradeC;
            }
     }
}
 
