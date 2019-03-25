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
            group.Add(new Student("First"));
            group.Add(new Student("Second", Progress.Excelent, 56));
            group.Add(new Student("Third", Progress.Bad, 34));
            group.Add(new Student("Forth", Progress.Good, 23));
            group.Add(new Student("Fifth", Progress.Middle, 14));
            //Console.WriteLine(group.Count);
            //group.RemoveAt(1);
            //Console.WriteLine(group[1]);
            //for(int i = 0;i<group.Count; i++)
            //{
            //    Console.WriteLine(group[i]);
            //}
            foreach (Student st in group)
            {
                Console.WriteLine(st);
            }
            IEnumerator ie = group.GetEnumerator();
            Console.WriteLine("\n\t  NewCode\n");
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            Console.WriteLine("\n\t  NewCode2\n");
            foreach(Student st in group.Iterator(false))
            {
                Console.WriteLine(st);
            }
        }
    }