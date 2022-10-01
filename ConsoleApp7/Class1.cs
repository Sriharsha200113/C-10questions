using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//problem 1
namespace ConsoleApp7
{
    internal class Class1
    {
        static void Main()
        {
            int[] ar = new int[] { 22, 44, 11, 10, 33 };
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }
                if (ar[i] > max)
                {
                    max = ar[i];
                }
            }
            Console.WriteLine("Maximum element is {0}", max);
            Console.WriteLine("Minimum element is {0}", min);
        }
    }
}
