public delegate int Dlg(int a, string st);
    class Program
    {
        static void Main(string[] args)
        {
            Dlg d1 = new Dlg(MyMethods.Sum);
            int result = d1.Invoke(50, "Armenia");
            Console.WriteLine("Result = " + result);
            Dlg d2 = MyMethods.Sum;
            int rst = d2(121, "Erevan Dardzac , Im Erebuniiii ... !");
            Console.WriteLine("Result is " + rst);
            d2 += MyMethods.Multy;
            int r = d2(119, "Sona");
            Console.WriteLine(r);
        }
    }