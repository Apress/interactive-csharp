using System;

namespace AbstractClassEx1
{
    abstract class MyAbstractClass
    {
        public abstract void ShowMe();
    }
    class MyConcreteClass : MyAbstractClass
    {
        public override void ShowMe()
        {
            Console.WriteLine("I am from a concrete class.");
            Console.WriteLine("My ShowMe() method body is complete.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Abstract class Example-1 ***\n");
            //Error:Cannot create an instance of the abstract class
            // MyAbstractClass abstractOb=new MyAbstractClass();
            MyConcreteClass concreteOb = new MyConcreteClass();
            concreteOb.ShowMe();
            Console.ReadKey();
        }
    }
}
