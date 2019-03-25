using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annnn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RetString(x=>x%3==0,"Erevan is capital of Armenia",31));
        }

        static string RetString(Func<int, bool > func, string s,int a)
        {
            if (func(a) == true)
                return s;
            string s1 = "";
            for (int i = s.Length-1; i >=0; i--)
            {
                s1 += s[i];
            }
            return s1;
        }
    }
}