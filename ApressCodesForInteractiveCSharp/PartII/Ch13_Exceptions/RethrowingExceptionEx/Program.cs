using System;

namespace RethrowingExceptionEx
{
    class Program
    {
        static int a = 100, b = 1, c;
        static void Divide(int a, int b)
        {
            try
            {
                b--;
                c = a / b;
                //some code
            }
            catch(Exception ex)
            {   //some code e.g. log it now
                Console.WriteLine("a={0} b={1}", a,b);
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("StackTrace: {0}", ex.StackTrace);                
                //Now rethrow it
                //throw; //will throw the current exception
                throw  new ArithmeticException();//throwing the parent class exception
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Rethrowing an Exception Example***");
            try
            {
                Divide(a, b);
                Console.WriteLine(" Main.Divide() is completed");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\na={0} b={1}", a, b);
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("StackTrace: {0}", ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nIn catch(Exception ex)");
                Console.WriteLine("a={0} b={1}", a, b);
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("StackTrace: {0}", ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
