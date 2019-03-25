using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Run
{
    public class Dog : Animal
    {
        public Dog(string nm = "Alpha", int x = 0, ConsoleColor clr = ConsoleColor.Green, char ic = '@') : base(nm, x, clr, ic)
        {

        }
        public override void Move()
        {
            int temp = RD.Next(100);
            if (temp < 25) X += 4;
            else if (temp < 40) X += 2;
            else if (temp < 60) X -= 2;
            else if (temp < 70) X -= 1;
        }
    }
    public class Horse : Animal
    {
        public Horse(string nm = "BigBoy", int x = 0, ConsoleColor clr = ConsoleColor.Green, char ic = 'H') : base(nm, x, clr, ic)
        {
        }
        public override void Move()
        {
            int temp = RD.Next(100);
            if (temp < 15) X += 5;
            else if (temp < 40) X += 1;
            else if (temp < 65) X -= 2;
            else if (temp < 80) X -= 1;
        }
    }
}