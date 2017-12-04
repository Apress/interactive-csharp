using System;

namespace InterfaceEx3
{
    interface IMyInterface3A
    {
        void Show3A();
    }
    interface IMyInterface3B
    {
        void Show3B();
    }
    class MyClass3 :IMyInterface3A, IMyInterface3B
    {	
        public void Show3A()
        {
           Console.WriteLine("MyClass3 .Show3A() is completed.");
        }   
        public void Show3B()
        {
           Console.WriteLine("MyClass3 .Show3B() is completed.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Interfaces.Example-3***\n");
            MyClass3 myClassOb = new MyClass3();
            myClassOb.Show3A();
            myClassOb.Show3B();
            Console.ReadKey();
        }
    }
}
