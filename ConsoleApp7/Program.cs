using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//problem 5
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(((string)Console.ReadLine()));
            int a = n;
            for(int i = a; i >=1; i--)
            {
                a = a * i;
            }
            Console.WriteLine("The fatorial of number is {0}",a);
            Console.WriteLine("The table of the number is");
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0}*{1}={2}",n,i,n*i);
            }
        }
    }
}
