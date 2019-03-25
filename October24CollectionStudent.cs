public enum Progress
    {
        Bad, Middle, Good, Excelent
    }
    public class CompareByCourse : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Course.CompareTo(y.Course);
        }
    }
    public class Student : IComparable<Student> 
    {
        public string Name { set; get; }
        public Progress Progress { set; get; }
        public int Course { set; get; }

        public Student(string name = "UnNamed", Progress progress = Progress.Good, int course = 1)
        {
            Name = name;
            Progress = progress;
            Course = course;
        }

        public override string ToString()
        {
            return Name + "\tCourse " + Course + "\t" + Progress;
        }

        public int CompareTo(Student other)
        {
            return Progress.CompareTo(other.Progress);
        }
        public static CompareByCourse ByCourse
        {
            get { return new CompareByCourse(); }
        }
    }