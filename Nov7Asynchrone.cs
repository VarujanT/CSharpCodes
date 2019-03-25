using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace AsinxronKan4
{
    public delegate int AsineDel(int a);


    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("MeinCall Call in thred" + Thread.CurrentThread.ManagedThreadId);
            AsineDel dlg = test.DrawNums;
            IAsyncResult iar = dlg.BeginInvoke(15, Finaly, null);
            int i = 0;
            while (i < 15)
            {
                WriteLine("Num front Main" + i++);
                Thread.Sleep(500);
            }
            WriteLine("Finish Primery ");
           // int result = dlg.EndInvoke(iar);
            //WriteLine(result);
        }

        public static void Finaly(IAsyncResult ias)
        {
            WriteLine("Finaly Call in thred" + Thread.CurrentThread.ManagedThreadId);
            AsyncResult ar = ias as AsyncResult;
            AsineDel d = ar.AsyncDelegate as AsineDel;
            int res = d.EndInvoke(ias);
            WriteLine("result is " + res);
          
        }
    }

    

    public class test
    {
        public static int DrawNums(int n)
        {
            WriteLine("CdrawNums Call in thred" + Thread.CurrentThread.ManagedThreadId);
            int sum = 0;
            while (n-- != 0)
            {
                sum += n;
                WriteLine("NumFrom DrauNum" + n);
                Thread.Sleep(1000);
            }
            WriteLine("Finish DrawNums");
            return sum;
        }
    }
}