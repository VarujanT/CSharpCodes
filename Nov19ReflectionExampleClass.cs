using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefelctionExample
{
    public class Book
    {
        public string Autor { set; get; }
        public int Price { set; get; }

        public int ReturnCount()
        {
            return Autor.Length + Price;
        }

        public Book (string atr = "Shiraz", int prc = 10000)
        {
            Autor = atr;
            Price = prc;
        }
        public override string ToString()
        {
            return Autor + "\t" + Price;
        }

        public void MethodFirst()
        {
            Console.WriteLine("Method First");
        }

        public void MethodFirst(int a)
        {
            Console.WriteLine("Method First With Param" + a);
        }
    }

   
}