using System;

namespace Quiz1Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Exceptions***");
            int a = 100, b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(" So, the result of a/b is :{0}", c);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Encountered an exception :{0}", ex.Message);
            }
            //Error:Exceptions follows the inheritance hierarchy. 
            //So, we need to place catch blocks properly.
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Encountered an DivideByZeoException :{0}", ex.Message);
            //}           
            Console.ReadKey();
        }
    }
}
