using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatner
{
    public delegate int Dlg(int a, string st);
    class Program
    {
        static void Main(string[] args)
        {
            Dlg d1 = new Dlg(MyMethods.Sum);
            int result = d1.Invoke(50, "Armenia");
            Console.WriteLine("Result is " + result);
            Dlg d2 = MyMethods.Sum;
            int rst = d2(121, "Erevan");
            Console.WriteLine("Res is " + rst);
            d2 += MyMethods.Multy;
            MyMethods md = new MyMethods();// kamel karelie "d2+= new MyMethods().Sub;"
            d2 += md.Sub;
            int r = d2(119, "Sona");
            Console.WriteLine(r);
            Delegate[] dl = d2.GetInvocationList();
            foreach (Dlg g in dl)
            {
                Console.WriteLine(g.Method.Name + "\t" + g.Target);
            }
        }
    }
}