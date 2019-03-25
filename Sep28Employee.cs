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

        public Employee(string nm = "UnNamed",int ag = 18 ,decimal sl = 100000)
        {
            Name = nm;
            Age = ag;
            Salary = sl;
        }
        static Employee()
        {
            Console.WriteLine("Static Ctor: Enter tax");
            tax = int.Parse(Console.ReadLine());
        }
        public decimal RealSalary()
        {
            return Salary - tax;
        }
        public override string ToString()
        {
            return Name+"\t"+Age+ "\t" + Salary;
        }
    }
}