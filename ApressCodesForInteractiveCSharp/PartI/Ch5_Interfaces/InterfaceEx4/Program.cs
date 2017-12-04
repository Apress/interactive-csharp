using System;

namespace InterfaceEx4
{
    //Both of the interfaces have the same method name "Show()".
    interface IMyInterface4A
    {
        void Show();
    }
    interface IMyInterface4B
    {
        void Show();
    }
    class MyClass4 : IMyInterface4A, IMyInterface4B
    {
        public void Show()
        {
            Console.WriteLine("MyClass4 .Show() is completed.");
        }

        void IMyInterface4A.Show()
        {
            Console.WriteLine("Explicit interface Implementation.IMyInterface4A .Show().");
        }

        void IMyInterface4B.Show()
        {
            Console.WriteLine("Explicit interface Implementation.IMyInterface4B .Show().");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Interfaces.Example-4***\n");
          
            //All the 3 ways of callings are fine.
            MyClass4 myClassOb = new MyClass4();
            myClassOb.Show();

            IMyInterface4A inter4A = myClassOb;
            inter4A.Show();

            IMyInterface4B inter4B = myClassOb;
            inter4B.Show();

            Console.ReadKey();
        }
    }
}
