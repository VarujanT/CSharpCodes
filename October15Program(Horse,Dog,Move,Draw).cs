using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AnimalContest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog
            {
                Name = "Chalo",
                X = 1,
                Icon = '@',
                Color = ConsoleColor.Yellow
            };

            Horse horse = new Horse
            {
                Name = "Jalal",
                X = 2,
                Icon = 'H',
                Color = ConsoleColor.Gray
            };

            for (int i = 0; i < 100; i++)
            {
                dog.Draw();
                horse.Draw();
                Thread.Sleep(100);
                dog.Draw(false);
                horse.Draw(false);
                dog.Move();
                horse.Move();
            }
        }
    }
}