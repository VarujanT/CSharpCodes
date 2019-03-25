class Program
    {
        static void Main(string[] args)
        {
            //Student[] st = {
            //               new Student(),
            //               new Student("",Progress.Middle,56),
            //               new Student("Ashot",Progress.Excelent,34)
            //};
            //Array.Sort(st);
            //foreach(Student s in st)
            //{
            //    Console.WriteLine(s);
            //}
            //Array.Sort(st);
            //foreach (Student s in st)
            //{
            //    Console.WriteLine(s);
            //}
            Group group = new Group();
            group.Add(new Student());
            group.Add(new Student("", Progress.Middle, 56));
            group.Add(new Student("Ashot", Progress.Excelent, 34));
            //Console.WriteLine(group.Count);
            //group.RemoveAt(1);
            //Console.WriteLine(group[1]);
            //for(int i = 0;i<group.Count; i++)
            //{
            //    Console.WriteLine(group[i]);
            //}
            foreach(Student s in group)
            {
                Console.WriteLine(s);
            }
        }
    }