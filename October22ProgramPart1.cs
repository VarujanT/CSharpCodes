class Program
    {
        static void Main(string[] args)
        {
            Student[] st = {
                           new Student(),
                           new Student("",Progress.Middle,56),
                           new Student("Ashot",Progress.Excelent,34)
            };
            Array.Sort(st);
            foreach(Student s in st)
            {
                Console.WriteLine(s);
            }
            Array.Sort(st,new CompareByCourse());
            foreach (Student s in st)
            {
                Console.WriteLine(s);
            }
        }
    }