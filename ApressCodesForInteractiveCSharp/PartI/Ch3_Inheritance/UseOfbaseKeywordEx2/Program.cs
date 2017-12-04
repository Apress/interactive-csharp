using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UseOfbaseKeywordEx3
{
    class Parent
    {
        public void ParentMethod()
        {
            Console.WriteLine("I am inside the Parent method");
        }
    }
    class Child : Parent
    {
       
        public void childMethod()
        {
               Console.WriteLine("I am inside the Child method");
               Console.WriteLine("I am calling the Parent method now");
               base.ParentMethod();
        }

}

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("***Testing the use of base keyword. Example-2***\n\n");
            Child obChild = new Child();
            obChild.childMethod();
            Console.ReadKey();
        }
    }
}
