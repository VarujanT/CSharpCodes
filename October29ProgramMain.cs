using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaxenalu_Cragir
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeName[] cn =
            {
                new CodeName (122,"Ator"),
                new CodeName (145,"Fanta"),
                new CodeName (45,"Afto"),
                new CodeName (86,"Nokia"),
                new CodeName (88,"Vodka"),
            };

            CodeExist[] ce =
            {
                new CodeExist (122,false),
                new CodeExist (145,true),
                new CodeExist (45,true),
                new CodeExist (86,false),
                new CodeExist (88,true),
            };

            var result = from x in cn
                         join y in ce
                         on x.Code equals y.Code
                         select new { x.Name, y.Exist};
            foreach (var z in result)
            {
                Console.WriteLine(z);
            }

        }
    }
}