public class Animal
    {
        private int x;
        private char icon;
        private ConsoleColor color;
        public String Name { set; get; }
        public int X
        {
            set
            {
                if (value >= 0 && value < WindowWidth)
                    x = value;
                else throw new Exception("Error value : " + value);
            }
            get => x;
        }
        public char Icon
        {
            set
            {
                if ((int)value >= 0 && (int)value < 256)
                    icon = value;
                else throw new Exception("Error icon : " + value);
            }
            get => icon;
        }
        public ConsoleColor Color { get => color; set => color = value; }
    }