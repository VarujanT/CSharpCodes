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
                int mid = last / 2;
                while (last >= first)
                {
                    if (a[i] == a[mid])
                    {
                        break;
                    }
                    if (a[i] > a[mid])
                    {
                        first = mid + 1;
                    }
                    else
                    {
                        last = mid - 1;
                    }
                    mid = first + (last - first) / 2;
                }
                int temp = a[i];
                for (int k = i; k> mid; k--)
                {
                    a[k] = a[k - 1];
                }
                a[mid] = temp;

            }
        }
    }
}