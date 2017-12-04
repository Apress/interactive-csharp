using System;

namespace InterfaceEx5
{
    interface Interface5A
    {
        void ShowInterface5A();
    }
    interface Interface5B
    {
        void ShowInterface5B();
    }
    //Interface implementing multiple inheritance
    interface Interface5C :Interface5A, Interface5B
    {
	    void ShowInterface5C();
    }
    class MyClass5 : Interface5C
    {
        public void ShowInterface5A()
        {
            Console.WriteLine("ShowInterface5A() is completed.");
        }

        public void ShowInterface5B()
        {
            Console.WriteLine("ShowInterface5B() is completed.");
        }

        public void ShowInterface5C()
        {
            Console.WriteLine("ShowInterface5C() is completed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Interfaces.Example-5***");
            Console.WriteLine("***Concept of multiple inheritance through interface***\n");

            MyClass5 myClassOb = new MyClass5();
            Interface5A ob5A = myClassOb;
            ob5A.ShowInterface5A();

            Interface5B ob5B = myClassOb;
            ob5B.ShowInterface5B();

            Interface5C ob5C = myClassOb;
            ob5C.ShowInterface5C();

            Console.ReadKey();
        }
    }
}
