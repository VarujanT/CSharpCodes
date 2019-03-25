using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BubbleSortMethodFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            SetBufferSize(WindowWidth, WindowHeight);
            do
            {
                int[] a = new int[rd.Next(7, 17)];
                FillArray(a, rd);
                DisplayArray(a);
            } while (ReadKey().Key == ConsoleKey.Enter);
        }
        public static void FillArray(int[] a, Random rd)
        {
            for(int i = 0; i <a.Length; i++)
            {
                a[i] = rd.Next(-99, 100);
            }
        }
        public static void DisplayArray(int[] array)
        {
            WriteLine("Funciton Size is " + array.Length);
            foreach(int i in array)
            {
                Write(i + "\t");
            }
            WriteLine();
        }
    }
}