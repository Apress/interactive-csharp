using System;


namespace LambdaExpressionEx1
{
    public delegate int Mydel(int x, int y);

    class Program
    {
        public static int Sum(int a, int b) { return a + b; }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Exploring Lambda Expression***");
            //Without using delgates or lambda expression
            int a = 25, b = 37;
            Console.WriteLine("\n Calling Sum method without using a delegate:");
            Console.WriteLine("Sum of a and b is : {0}", Sum(a, b));

            //Using Delegate( Initialization with a named method)
            Mydel del = new Mydel(Sum);
            Console.WriteLine("\n Using delegate now:");
            Console.WriteLine("Calling Sum method with the use of a delegate:");
            Console.WriteLine("Sum of a and b is: {0}", del(a, b));

            //Using Anonymous method(C# 2.0 onwards)
            Mydel del2 = delegate (int x, int y) { return x + y; };
            Console.WriteLine("\n Using Anonnymous method now:");
            Console.WriteLine("Calling Sum method with the use of an anonymous method:");
            Console.WriteLine("Sum of a and b is: {0}", del2(a, b));

            //Using Lambda expression(C# 3.0 onwards)
            Console.WriteLine("\n Using Lambda Expresson now:");
            Mydel sumOfTwoIntegers = (x1, y1) => x1 + y1;
            Console.WriteLine("Sum of a and b is: {0}", sumOfTwoIntegers(a, b));
            Console.ReadKey();
        }
    }
}

