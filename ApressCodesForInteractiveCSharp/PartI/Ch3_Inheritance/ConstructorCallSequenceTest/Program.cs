using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConstructorCallSequenceTest
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("At present: I am in Parent Constructor");
        }
    }
    class Child : Parent
    {
        public Child()

        {
            Console.WriteLine("At present: I am in Child Constructor");
        }
    }
    class GrandChild : Child
    {
        public GrandChild()
        {
            Console.WriteLine("At present: I am in GrandChild Constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("***Testing the call sequence of constructors***\n\n");
            GrandChild grandChild = new GrandChild();
            Console.ReadKey();
        }
    }
}
