using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace AttributesNov23
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Author = "Charents",
                Page = 1936,
                Price = 500,
                Title = "Nairi"
            };
            WriteLine(book);
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream str = new FileStream(@"C:\Users\LabUser26\Desktop\BookSer", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(str, book);
            }
        }
    }
}