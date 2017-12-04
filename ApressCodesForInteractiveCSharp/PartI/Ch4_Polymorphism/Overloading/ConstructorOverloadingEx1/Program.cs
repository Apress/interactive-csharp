using System;

namespace ConstructorOverloadingEx1
{
    class ConsOverloadEx
    {
        public ConsOverloadEx()
        {
            Console.WriteLine("Constructor with no argument");
        }
        public ConsOverloadEx(int a)
        {
            Console.WriteLine("Constructor with one integer argument {0}", a);
        }
        public ConsOverloadEx(int a, double b)
        {
            Console.WriteLine("You have passed one integer argument {0} and one double argument {1} in the constructor", a,b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Constructor overloading Demo***\n\n");
            ConsOverloadEx ob1 = new ConsOverloadEx();
            ConsOverloadEx ob2 = new ConsOverloadEx(25);
            ConsOverloadEx ob3 = new ConsOverloadEx(10,25.5);
            //ConsOverloadEx ob4 = new ConsOverloadEx(37.5);//Error
            Console.ReadKey();
        }
    }
}
