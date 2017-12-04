using System;

namespace OverloadingWithMultipleClasses
{
    class Parent
    {
        public void ShowMe()
        {
            Console.WriteLine("Parent.ShowMe1.No parameter");
        }
        public void ShowMe(int a)
        {
            Console.WriteLine("Parent.ShowMe1. One integer parameter");
        }       
    }
    class Child:Parent
    {
        //An overloaded method in child/derived class
        public void ShowMe(int a,int b)
        {
            Console.WriteLine("Child.ShowMe1. Two integer parameter");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Overloading across multiple classes***\n");
            Child childOb = new Child();
            //Calling all the 3 overloaded methods
            childOb.ShowMe();
            childOb.ShowMe(1);
            childOb.ShowMe(1, 2);
            Console.ReadKey();
        }
    }
}
