using System;
namespace PassingValueTypeUsingOut
{
    class Program
    {
        static void Change(out int x)
        {
            x = 25;
            //int y = 10;
            x = x * 2;
            Console.WriteLine("Inside Change(), myVariable is {0}", x);//50
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Passing Value Type by Reference using out-Demo***");
            int myVariable;//need to be initialized ,if you use 'ref'
            Change(out myVariable);
            Console.WriteLine("Inside Main(), myVariable={0}", myVariable);//50
            Console.ReadKey();
        }
    }
}
