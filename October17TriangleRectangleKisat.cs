public class Triangle : Figure
    {
        public Triangle(int a = 0, int b = 0) : base(a, b) { }
        public override void Draw()
        {
            Console.WriteLine("Draw Triangle from Figure");
        }
        public override string ToString()
        {
            return base.ToString()+" From Triangle";
        }
    }
    public class Rectangle : Figure
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b) { }
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle from Figure");
        }
        public override string ToString()
        {
            return base.ToString() + " From Rectangle";
        }
    }