using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Indexaoterner
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow c1 = new Cow();
            Cow c2 = new Cow("Nargiz", 17, 120);
            WriteLine(c1 + "\t" + c2);

            Naxir nx = new Naxir();
            nx.Add(new Cow());
            nx.Add(new Cow("Manushak"));
            
            //foreach (Cow cw i nx)
            //{
            //    WriteLine(cw)
            //} 

            for (int i = 0; i < nx.Count; i++)
            {
                WriteLine(nx[i]);
            }

            nx[1] = new Cow("Boo");
            WriteLine(nx[1]);
            WriteLine(nx["Boo"]);
            nx["Boo"] = new Cow("Anushik");
            WriteLine(nx["Anushik"]);

            
        }
    }
}