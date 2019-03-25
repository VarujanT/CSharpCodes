using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazayi_imitacia
{
	class Program
	{
		static void Main(string[] args)
		{
			CodeName[] cn =
			{
				new CodeName(122,"Ator"),
				new CodeName(114,"Sexan"),
				new CodeName(135,"Mkrat"),
				new CodeName(542,"Zugarani tuxt"),
				new CodeName(457,"Lvacqi poshi")
			};
			foreach (CodeName ar in cn)
			{
				Console.WriteLine(ar);
			}
			Console.WriteLine();

			CodeExist[] ce =
			{
				new CodeExist(122,0),
				new CodeExist(114,KaChka.CHka),
				new CodeExist(135,0),
				new CodeExist(542,KaChka.CHka),
				new CodeExist(457,0)
			};
			foreach (CodeExist ar in ce)
			{
				Console.WriteLine(ar);
			}
			Console.WriteLine();

			var result = from x in cn//@ntrum enq element cn ic
						 join y in ce//@ntrum enq element ce ic
						 on x.Code equals y.Code//ete x.Code @ = y.Code
						 select new { x.Name, y.KCH };//@ntrel aydandam@ ev cuyc tal nra Name@ ev Exist@
			foreach(var ar in result)
			{
				Console.WriteLine(ar);
			}
			Console.WriteLine();
		}
	}
}