public class Group : IEnumerable<Student>
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

        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Student this[int i]
        {
            get
            {
                if (i < Count && i >= 0) return students[i];
                throw new IndexOutOfRangeException("Error Index : " + i);
            }
            set
            {
                if (i < Count && i >= 0)
                    students[i] = value;
                throw new IndexOutOfRangeException("Error Index : " + i);
            }
        }
    }