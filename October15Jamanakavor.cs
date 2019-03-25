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
        public ConsoleColor Color
        {
            set
            {
                if ((int)value > 0 && (int)value < 16)
                    color = value;
                else throw new Exception("Error icon : " + value);
            }
            get => color;
        }
        public Animal(string nm = "UnNamed",ConsoleColor color = ConsoleColor.Black,char icn = '*',int x = 0)
        {
            Name = nm;
            X = x;
            Color = color;
            Icon = icn;
        }
        public override string ToString()
        {
            return Name+"\t"+Icon+"\t"+Color+"\t"+X;//jamanakavor
        }
        public void Draw(bool draw)
        {
            ForegroundColor = draw ? Color : BackgroundColor;
            SetCursorPosition(X,5);
            WriteLine(Icon);
        }
    }