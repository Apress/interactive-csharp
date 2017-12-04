using System;

namespace PassingValueTypeUsingRef
{
    class Program
    {
        static void Change(ref int x)
        {
            x = x * 2;
            Console.WriteLine("Inside Change(), myVariable is {0}", x);//50
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Passing Value Type by Reference using ref-Demo***");
            //int myVariable;//error: need to be initialized in case of 'ref'
            int myVariable = 25;
            Change(ref myVariable);
            Console.WriteLine("Inside Main(), myVariable={0}", myVariable);//50
            Console.ReadKey();
        }
    }
}
