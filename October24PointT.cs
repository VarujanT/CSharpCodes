public class Point<T> where T : class, ICloneable , new()
    {
        private T x;
        private T y;

        public Point()
        {
        }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
        //public T Sum(Point<T> p)
        //{
        //    //return new Point<T>(X + p.X,Y + p.Y);
        //}
        public int Sum(int a , int b)
        {
            return a + b;
        }
        public override string ToString()
        {
            return X + "\t" + Y;
        }
        public T X { get => x; set => x = value; }
        public T Y { get => y; set => y = value; }
    }



Collapse 

8:03 AM
Collection Main 