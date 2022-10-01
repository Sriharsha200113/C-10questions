using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//problem3
namespace ConsoleApp7
{
    public interface Vehicle
    {
         void drive();
         bool refuel();
    }
    public class Car : Vehicle
    {
        public int fuel { get; set; }
       
    public void drive()
        {
            if(fuel>0)
            {
                Console.WriteLine("Car is driving");
            }
            else
            {
                Console.WriteLine("need to refuel");
            }
        }

        public bool refuel()
        {
            if(fuel>0)
                return true;
            else
            {
                return false;
            }
        }

    }

    internal class Class3
    {
        static void Main()
        {
            int f;
            Console.WriteLine("Enter the amount of fuel");
            f=Convert.ToInt32(Console.ReadLine());
            Car benz = new Car();
             benz.fuel = f;
             benz.drive();
            Console.WriteLine(benz.refuel());
        }

    }
}
