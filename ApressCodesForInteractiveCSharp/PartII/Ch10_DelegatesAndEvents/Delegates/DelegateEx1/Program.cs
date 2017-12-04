using System;

namespace DelegateEx1
{
    public delegate int Mydel(int x, int y);

    class Program
    {
        public static int Sum(int a, int b) { return a + b; }

        static void Main(string[] args)
        {
            Console.WriteLine("***Delegate Example -1: A simple delegate demo***");
            int a = 25, b = 37;
            Console.WriteLine("\n Calling Sum(..) method without using a delegate:");
            Console.WriteLine("Sum of a and b is : {0}", Sum(a,b));

            //Mydel del = new Mydel(Sum);
            //or simply write
            Mydel del = Sum;
            Console.WriteLine("\n Using delegate now:");
            Console.WriteLine("Calling Sum(..) method with the use of a delegate:");
            Console.WriteLine("Sum of a and b is: {0}", del(a, b));
            //del(a,b) is shorthand for del.Invoke(a,b)
            //Console.WriteLine("Sum of a and b is: {0}", del.Invoke(a, b));
            Console.ReadKey();
        }
    }
}

