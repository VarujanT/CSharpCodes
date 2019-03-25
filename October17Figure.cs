public abstract class Figure
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Figure(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return X + "\t" + Y;
        }
        public abstract void Draw();
    }