using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;

namespace RefelctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Type tp = typeof(Book);
            //Book b = new Book();
            //Type tp1 = b.GetType();
            MethodInfo[] mi = tp.GetMethods();
            foreach (MethodInfo m in mi)
            {
                //WriteLine(m.Name);
                WriteLine(m);
            }

            Type tpDouble = typeof(double);
            PropertyInfo[] pi = tpDouble.GetProperties();
            foreach(var p in pi)
            {
                WriteLine(p);
            }
        }
    }
}