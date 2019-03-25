public class MyMethods
    {
        public static int Sum(int a, string str)
        {
            Console.WriteLine("Calling Sum");
            return a + str.Length;
        }
        public int Sub(int a, string str)
        {
            Console.WriteLine("Calling Sub");
            int s = 0;
            foreach (char c in str)
            {
                s += (int)a;
            }
            return a - s;
        }
        public static int Multy(int a, string str)
        {
            Console.WriteLine("Calling Multy");
            return a * str.Length;
        }
    }