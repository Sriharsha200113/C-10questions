using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//problem 7
namespace ConsoleApp7
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
    internal class class5
    {
        static void Main(string[] args)
        {





            Queue<Person> persons = new Queue<Person>();



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter name of Person " + (i + 1) + " :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age of Person " + (i + 1) + " :");
                int age = int.Parse(Console.ReadLine());
                persons.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }
            Console.WriteLine("\nPrinting all person details:");
            Console.WriteLine("Name - Age");
            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }




        }
    }
}
