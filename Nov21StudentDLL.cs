using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.dll
{
    public class Student
    {
        public string Name { set; get; }
        public int Course { set; get; }

        public Student (string name = "Saqo", int course = 3)
            {
            Name = name;
            Course = course;
            }

        public Student()
        {
        }

        public void First()
        {
            Console.WriteLine("Calling First Without Param");
        }
        public void Second(int a, bool b)
        {
            Console.WriteLine("Calling First With Params" + a +"\t" + b);
        }
    }
   
}