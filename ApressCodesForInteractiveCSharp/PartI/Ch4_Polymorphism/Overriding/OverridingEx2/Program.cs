using System;

namespace OverridingEx2
{
    class ParentClass
    {
        public virtual int ShowMe(int i)
        {
            Console.WriteLine("I am in Parent class");
            return i;
        }
    }
    class ChildClass : ParentClass
    {
        public override int ShowMe(int i)
        {
            Console.WriteLine("I am in Child class");
            Console.WriteLine("Incrementing i by 5");
            return i + 5;//Must return  an int
        }
        public void ShowMe()
        {
            Console.WriteLine("In Child.ShowMe()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Overloading with Overriding Demo***\n");
            ChildClass childOb = new ChildClass();
            Console.WriteLine(childOb.ShowMe(5));//10
            childOb.ShowMe();
            Console.ReadKey();
        }
    }
}
