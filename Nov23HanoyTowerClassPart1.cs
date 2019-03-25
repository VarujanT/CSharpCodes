using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HanoyTower
{
    public class Tower
    {
        private List<int> list = new List<int>();
        public int Count => list.Count;
        public int this [int i]
        {
            get
            {
                if (i >= 0 && i < Count)
                    return list[i];
                throw new Exception("Asi Bror");
            }
            set
            {
                if (i >= 0 && i < Count) list[i] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        public void Add(int a)
        {
            if (list.Count != 0)
            {
                if (a < list[list.Count - 1])
                {
                    list.Add(a);
                }
                else throw new Exception(""+a);
            }
            else list.Add(a);
        }
        public void Remove()
        {
            if (list.Count == 0)
                return;
            list.RemoveAt(Count - 1);
        }
    }
}