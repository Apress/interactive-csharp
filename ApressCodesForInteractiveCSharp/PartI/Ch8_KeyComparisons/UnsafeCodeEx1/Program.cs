using System;

namespace UnsafeCodeEx1
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int a = 25;
            int* p;
            p = &a;
            Console.WriteLine("***Pointer Type Demo***");
            Console.WriteLine("*p is containing:{0}", *p);

            Console.ReadKey();
        }
    }
}
