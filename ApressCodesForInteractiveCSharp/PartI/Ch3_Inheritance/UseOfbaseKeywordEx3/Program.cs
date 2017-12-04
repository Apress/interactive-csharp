using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UseOfbaseKeywordEx3
{
    class Parent
    {
        public void ShowMe()
        {
            Console.WriteLine("I am inside the Parent method");
        }
    }
    class Child : Parent
    {

        public void ShowMe()
        {
            Console.WriteLine("I am inside the Child method");            
            base.ShowMe();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("***Testing the use of base keyword. Example-3***\n\n");
            Child obChild = new Child();
            obChild.ShowMe();
            Console.ReadKey();
        }
    }
}

