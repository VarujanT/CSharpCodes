public class Triangle : Figure , IPoint
    {
        public Triangle(int a = 0, int b = 0) : base(a, b) { }

        public int this[int i] => 3;

        public int Points => 3;

        public override void Draw()
        {
            Console.WriteLine("Draw Triangle from Figure");
        }

        public int GetPoints()
        {
            return 3;
        }

        public override string ToString()
        {
            return base.ToString()+" From Triangle";
        }
    }
    public class Rectangle : Figure , IPoint
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b) { }

        public int this[int i] => 4;

        public int Points => 4;

        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle from Figure");
        }

        public int GetPoints()
        {
            return 4;
        }

        public override string ToString()
        {
            return base.ToString() + " From Rectangle";
        }
    }
    public class Circle : Figure
    {
        public Circle(int a = 0, int b = 0) : base(a, b) { }
        public override void Draw()
        {
            Console.WriteLine("Draw Circle from Figure");
        }
        public override string ToString()
        {
            return base.ToString() + " From Circle";
        }
    }
    public class Mountain : IPoint
    {
        public int this[int i] => 4;

        public int Points => 4;

        public int GetPoints()
        {
            return 4;
        }
    }
    public class Knife : IPoint
    {
        public int this[int i] => 2;

        public int Points => 2;

        public int GetPoints()
        {
            return 2;
        }
    }