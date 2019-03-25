public class Tower
    {
        private List<int> list = new List<int>();
        public int Count => list.Count;
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < Count) return list[i];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i >= 0 && i < Count) list[i] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        public void Add(int a)
        {
            if (Count != 0)
                if (a < list[Count - 1]) list.Add(a);
                else throw new Exception(a.ToString());
            else list.Add(a);
        }
        public void Remove()
        {
            if (list.Count == 0) return;
            list.RemoveAt(Count - 1);
        }
        public int Last => list[Count];
    }