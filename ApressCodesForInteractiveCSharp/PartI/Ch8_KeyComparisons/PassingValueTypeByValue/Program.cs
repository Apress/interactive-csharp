using System;

namespace PassingValueTypeByValue
{
    class Program
    {

        static void Change(int x)
        {
            x = x * 2;
            Console.WriteLine("Inside Change(), myVariable is {0}", x);//50
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Passing Value Type by Value-Demo***");
            int myVariable = 25;
            Change(myVariable);
            Console.WriteLine("Inside Main(), myVariable={0}", myVariable);//25 
            Console.ReadKey();
        }
    }
}
