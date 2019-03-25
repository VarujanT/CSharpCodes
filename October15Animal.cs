using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Animal_Run
{
    public abstract class Animal
    {
        public static Random RD { get; }
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
                //else throw new Exception("Error value : " + value);
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
                if ((int)value >= 0 && (int)value < 16)
                    color = value;
                else throw new Exception("Error Color : " + value);
            }
            get => color;
        }
        public Animal(string nm = "UnNamed", int x = 0, ConsoleColor clr = ConsoleColor.Black, char ic = '*')
        {
            Name = nm;
            X = x;
            Color = clr;
            Icon = ic;
        }
        public override string ToString()
        {
            return Name + "\t" + Icon + "\t" + Color + "\t" + X;//jamanakavor
        }
        public void Draw(bool draw = true)
        {
            ForegroundColor = draw ? Color : BackgroundColor;
            SetCursorPosition(X, 5);
            Write(Icon);
        }
        public abstract void Move();
        static Animal()
        {
            RD = new Random();
        }
    }
}