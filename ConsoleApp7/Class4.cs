using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//problem 4
namespace ConsoleApp7
{
    public abstract class Bird

    {

        private string name;

        public string Name

        {

            get { return name; }

            set { name = value; }

        }

        public abstract void eat();

        public void fly(){}



    }

    public class Parrot : Bird

    {

        public override void eat()

        {

            Console.WriteLine("{0} is eating",Name);

        }

        public new void fly()

        {

            Console.WriteLine("{0} is Flying",Name);

        }

    }

    public class Crow : Bird

    {

        public override void eat()

        {

            Console.WriteLine("{0} is eating", Name);

        }

        public new void fly()

        {

            Console.WriteLine("{0} is flying", Name);

        }

    }

    internal class class4

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter type of bird");

            string bird = Console.ReadLine();

            switch (bird)

            {

                case "parrot":

                    Parrot p = new Parrot();

                    Console.WriteLine("Enter name of bird");

                    string bird_name1 = Console.ReadLine();

                    p.Name = bird_name1;

                    Console.WriteLine(p.Name);

                    p.fly();

                    p.eat();

                    break;



                case "crow":

                    Crow c = new Crow();

                    Console.WriteLine("Enter name of bird");

                    string bird_name2 = Console.ReadLine();

                    c.Name = bird_name2;

                    Console.WriteLine(c.Name);

                    c.fly();

                    c.eat();

                    break;



            }

        }
    }
}
