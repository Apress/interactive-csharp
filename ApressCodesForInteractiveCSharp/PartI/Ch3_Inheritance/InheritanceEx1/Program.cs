using System;

namespace InheritanceEx1
{
    class ParentClass
    {
        public void ShowParent()
        {
            Console.WriteLine("In Parent");
        }
    }
    class ChildClass :ParentClass
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            Console.WriteLine("***Testing Inheritance***\n\n");
            ChildClass child1 = new ChildClass();
            //Invoking ShowParent()through ChildClass object
            child1.ShowParent();
            Console.ReadKey();
        }
    }
}
