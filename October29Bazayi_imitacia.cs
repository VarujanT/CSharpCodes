using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazayi_imitacia
{
	public enum KaChka
	{
		Ka,
		CHka,
	}
	public class CodeName
	{
		public int Code { set; get; }
		public string Name { set; get; }
		public CodeName(int cd, string nm)
		{
			Code = cd;
			Name = nm;
		}
		public CodeName() { }
		public override string ToString()
		{
			return Code + "\t" + Name;
		}
	}
	public class CodeExist
	{
		public int Code { set; get; }
		public KaChka KCH { set; get; }
		public CodeExist(int cd, KaChka kch)
		{
			Code = cd;
			KCH = kch;
		}
		public CodeExist() { }
		public override string ToString()
		{
			return Code + "\t" + KCH;
		}
	}
}