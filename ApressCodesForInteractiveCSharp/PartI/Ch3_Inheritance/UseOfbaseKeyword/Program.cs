using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfbaseKeywordEx3
{
    class Parent
    {
        private int a;
        private int b;
        public Parent(int a, int b)
        {
            Console.WriteLine("I am in Parent constructor");
            Console.WriteLine("Setting the value for instance variable  a and b");
            this.a = a;
            this.b = b;
            Console.WriteLine("a={0}", this.a);
            Console.WriteLine("b={0}", this.b);
        }
        
}
    class Child : Parent
    {
	    private int c;
        public Child(int a, int b, int c) : base(a, b)

        {
            Console.WriteLine("I am in Child constructor");
            Console.WriteLine("Setting the value for instance variable c");
            this.c = c;
            Console.WriteLine("c={0}", this.c);            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("***Testing the use of base keyword. Example-1***\n\n");           
            Child obChild = new Child(1, 2, 3);
            //Console.WriteLine("a in ObB2={0}", obChild.a);// a is private, so Child.a is inaccessible            
            Console.ReadKey();
        }
    }
}
