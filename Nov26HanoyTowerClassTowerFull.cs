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
        
        public void Add(int a)
        {
            if (Count != 0)
                if (a < list[Count - 1]) list.Add(a);
                else throw new Exception(a.ToString());
            else list.Add(a);
        }

        public void Show()
        {
            if (Count == 0) { Console.WriteLine("Empty"); return; }
            
            foreach (int x in list)
            {
                Console.Write(x + "\t");
            }
            Console.WriteLine();
        }
        public void Remove()
        {
            if (list.Count == 0) return;
            list.RemoveAt(Count - 1);
        }
        public int Last => list[Count - 1];
    }
}