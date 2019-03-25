using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Employeers
{
    public class Employee
    {
        public string Name { set; get; }
        private int age;
        public int Age
        {
            set
            {
                if (value >= 18 && value < 100) age = value;
            }
            get => age;
        }
        private decimal salary;
        public decimal Salary
        {
            set
            {
                if (value >= 55000)
                    salary = value;
            }
            get => salary;
        }
        private static readonly int tax;
        public static int Tax => tax;

        public Employee(string nm = "UnNamed", int ag = 18, decimal sl = 100000)
        {
            Name = nm;
            Age = ag;
            Salary = sl;
        }
        ~Employee()
        {
        }
        static Employee()
        {
            WriteLine("Static Ctor: Enter tax");
            tax = int.Parse(ReadLine());
        }
        public virtual decimal RealSalary()
        {
            return Salary - tax;
        }
        public override string ToString()
        {
            return Name + "\t" + Age + "\t" + Salary;
        }
    }
}