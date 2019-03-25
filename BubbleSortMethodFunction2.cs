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
                string[] s = { "Hakob", "Asgo", "Parandzem", "EF", "SG", "AB" };
                BubbleSort(s);
                WriteLine();
                foreach(var s1 in s)
                {
                    WriteLine(s1);
                }
                WriteLine();
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
        public static void BubbleSort(string [] s)
        {
            for (int i = 0; i < s.Length-1; i++)
            {
                for (int k = 0; k < s.Length - i - 1; k++)
                {
                    if(s[k].CompareTo(s[k+1])>0)
                    {
                        string temp = s[k + 1];
                        s[k+1] = s[k];
                        s[k] = temp;
                    }
                }
            }
        }
    }
}