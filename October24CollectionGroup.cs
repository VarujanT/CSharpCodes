public class Group : IEnumerable
    {
        private List<Student> students = new List<Student>();
        public void Add(Student st)
        {
            students.Add(st);
        }
        public int Count
        {
            get { return students.Count; }
        }
        public void RemoveAt(int i)
        {
            students.RemoveAt(i);
        }
        public void Remove(Student st)
        {
            students.Remove(st);
        }
        public void RemoveAll()
        {
            students.RemoveAll(x => true);
        }
        public IEnumerator GetEnumerator()
        {
            //for (int i = 0; i < Count; i++)
            //    yield return students[i];
            //yield return students[1];
            //yield return students[4];
            return students.GetEnumerator();
        }
        public IEnumerable Iterator(bool b)
        {
            if (b)
                for (int i = 0; i < Count; i++)
                    yield return students[i];
            else
                for (int i = Count - 1; i >= 0; i--)
                    yield return students[i];
        }
        /*
        public IEnumerator<Student> GetEnumerator()
        {       
          return students.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }*/
        public Student this[int i]
        {
            get
            {
                if (i < Count && i >= 0) return students[i];
                throw new IndexOutOfRangeException("Error Index : " + i);
            }
            set
            {
                if (i > Count || i < 0)
                    throw new IndexOutOfRangeException("Error index : " + i);
                students[i] = value;
            }
        }
    }