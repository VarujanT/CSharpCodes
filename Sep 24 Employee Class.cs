using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car

{
    public class Employee
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public decimal Salary { set; get; }

        public static int Tax => tax;

        private static readonly int tax;

        static Employee()
        {
            Console.WriteLine("Static Ctor: Enter Tax; ");
            tax = int.Parse(Console.ReadLine());
        }

       


        public Employee(String nm = "UnNamed", int ag = 18, decimal sl = 100000)
            {
                Name = nm;
                Salary = sl;
                Age = ag;
            }

        public override string ToString()
        {
            return Name + "\t" + Age + "\t" + Salary;
        }

        public decimal RealSalary()
        {
            return Salary - (Salary / 4);
        }
    }
}