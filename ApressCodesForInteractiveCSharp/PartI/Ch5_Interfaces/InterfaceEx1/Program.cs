using System;

namespace InterfaceEx1
{
    interface IMyInterface
    {
        void Show();
    }
    class MyClass : IMyInterface
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is implemented.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Interfaces.Example-1***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.Show();
            Console.ReadKey();
        }
    }
}
