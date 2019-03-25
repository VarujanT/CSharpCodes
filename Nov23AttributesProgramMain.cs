using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using AttributesNov23;
namespace NewTsragirNov23
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream str = File.Open(@"C:\Users\LabUser26\Desktop\BookSer",FileMode.Open))
            {
                Book b = (Book)bf.Deserialize(str);
                WriteLine(b);
            }
        }
    }
}