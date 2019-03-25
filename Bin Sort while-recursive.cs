using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayFunctions;
namespace BinSortRecursino
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Class1.FillArray(a);
            Class1.ShowArray(a);

            BinSort(a);
            Class1.ShowArray(a);

            
        }
        static void BinSort(int[]a)
        {
          for(int i = 0; i < a.Length; i++)
            {
                int first = 0;
                int last = i - 1;
                int mid = GetMid(a, first, i - 1, i);
                int temp = a[i];
                for (int k = i; k> mid; k--)
                {
                    a[k] = a[k - 1];
                }
                a[mid] = temp;

            }
        }
        static int GetMid(int [] a, int first, int last, int i)
        {
            int mid = first + (last - first) / 2;
            if (first > last)
                return mid;
            if (a[i] == a[mid])
                return mid;
            if (a[i] > a[mid])
                return GetMid(a, mid + 1, last, i);
            return GetMid(a, first, mid - 1, i);
        }
    }
}