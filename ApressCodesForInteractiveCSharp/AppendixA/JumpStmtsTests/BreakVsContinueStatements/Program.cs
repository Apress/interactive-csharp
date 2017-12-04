using System;

namespace BreakVsContinueStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Illustration -break vs continue***");
            int i = 5;
            while (i != 10)
            {
                i++;
                Console.WriteLine("i is now {0}", i);
                if (i == 8)
                {
                    Console.WriteLine(" Entered inside if loop");
                    break;
                    //continue;
                    //unreachable code
                    //Console.WriteLine(" I am still in if  loop");
                }
            }
            Console.ReadKey();
        }
    }

}
