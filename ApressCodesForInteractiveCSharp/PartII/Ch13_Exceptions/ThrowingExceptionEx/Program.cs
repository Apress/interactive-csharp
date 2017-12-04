using System;

namespace ThrowingExceptionEx
{
    class Program
    {
        static int a = 100, b = 0, c;
        static void Divide(int a, int b)
        {
            if (b != 0)
            {
                int c = a / b;
            }
            else
            {
                throw new DivideByZeroException("b comes as Zero");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Exceptions:Throwing an Exception Example***");
            try
            {
                Divide(a, b);
                Console.WriteLine(" Division operation completed");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Encountered an exception :{0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
