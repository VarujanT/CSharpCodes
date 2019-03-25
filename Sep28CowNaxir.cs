using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexerner
{
    public class Naxir
    {
        private List<Cow> cowList = new List<Cow>();
        public Naxir()
        {
        }
        public void Add(Cow cow)
        {
            cowList.Add(cow);
        }
    }
}