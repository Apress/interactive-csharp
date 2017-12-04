using System;

namespace ExceptionEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Exceptions.***");
            int a=100, b=0;
            int c = a / b;                    
            Console.WriteLine(" So, the result of a/b is :{0}", c);
            Console.ReadKey();
        }
    }
}
