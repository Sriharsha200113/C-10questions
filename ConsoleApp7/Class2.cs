using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//problem 9
namespace ConsoleApp7
{
    public delegate void Employee(String s);
    internal class Class2

    {
        public static void promot(String a)
        {
            Console.WriteLine("{0} is promoted",a);
        }

        static  void Main()
        {
            Employee job = new Employee(Class2.promot);
            job.Invoke("Harsha");
            job.Invoke("Rahul");
            job.Invoke("Ujwal");
            job.Invoke("rachana");
            job.Invoke("Prathyusha");

        }

    }

}
