using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book
            {
                Autor = "Troelsen",
                Price = 13000
            };
            int result = b.ReturnCount();
            Console.WriteLine(result);
            Console.WriteLine(b.BackAutor());
        }
    }
}