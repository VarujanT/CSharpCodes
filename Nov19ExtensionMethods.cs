using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Book
    {
        public string Autor { set; get; }
        public int Price { set; get; }

        public int ReturnCount()
        {
            return Autor.Length + Price;
        }
    }

    public static class SBook
    {
        public static string BackAutor (this Book b)
        {
            return "Aram";
        }

        public static void Show(this Array i)
        {
            foreach(var item in i)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}