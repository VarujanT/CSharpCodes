using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Indexaoterner
{
    public class Naxir
    {
        private List<Cow> cowList = new List<Cow>();
        public int Count
        {
            get => cowList.Count();
        }
        public Naxir()
        {

        }

        public void Add(Cow cow)
        {
            cowList.Add(cow);
        }

        public Cow this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException("Error Index : " + i);
                }
                return cowList[i];
            }

            set
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException("Error Index : " + i);
                }
                cowList[i] = value;
            }

        }

        public Cow this[string name]
        {
            get
            {
                foreach (Cow cw in cowList)
                {
                    if (cw.Name == name)
                    {
                        return cw;
                    }
                }
                throw new IndexOutOfRangeException("Error Name : " + name);

            }
            set
            {
                for(int i = 0; i < Count; i++)
                {
                    if(cowList[i].Name == name)
                    {
                        cowList[i] = value;
                        return;
                    }
                }
                throw new IndexOutOfRangeException("Error Name : " + name);
            }
             
        }


         
    }
}