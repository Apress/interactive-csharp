using System;

namespace StructureImplementsInterfaceEx
{
    interface IMyInterface
    {
        void ShowMe();
    }
    struct MyStructure : IMyInterface
    {
        public void ShowMe()
        {
            Console.WriteLine("MyStructure is implementing IMyInterface");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Demo:A Structure can implement an interface***");
            MyStructure myS = new MyStructure();
            myS.ShowMe();
            Console.ReadKey();
        }
    }
}
