class Program
    {
        static void Main(string[] args)
        {
            IPoint ip = new Rectangle(5, 7);
            Console.WriteLine(ip.GetPoints());
            Console.WriteLine(ip.Points);
            Console.WriteLine(ip[0]);
            IPoint[] iparray = 
                {
                    new Rectangle(14,32),
                    new Triangle (2,14),
                    new Mountain()
                };
            Console.WriteLine();
            foreach(IPoint temp in iparray)
            {
                Console.WriteLine(temp.Points);
            }
            foreach (IPoint p in iparray)
            {
                if (p is Figure)
                    (p as Figure).Draw();
            }
        }
    }