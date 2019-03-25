using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaxenalu_Cragir
{
    public class CodeName
    {
        public int Code { set; get; }
        public string Name { set; get; }
        public CodeName (int cd, string nm)
        {
            Code = cd;
            Name = nm;
        }

        public CodeName() { }
    }

    public class CodeExist
    {
        public int Code { set; get; }
        public bool Exist { set; get; }
        public CodeExist(int cd, bool b)
        {
            Code = cd;
            Exist = b;
        }

        public CodeExist() { }
    }
}