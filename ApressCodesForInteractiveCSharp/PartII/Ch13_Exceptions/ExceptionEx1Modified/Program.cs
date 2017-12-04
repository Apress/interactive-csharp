using System;

namespace ExceptionEx1Modified
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
            catch (Exception ex)
            {
                Console.WriteLine("Encountered an exception :{0}", ex.Message);
            }            
            finally
            {
                Console.WriteLine("I am in finally.You cannot skip me!");
            }
            Console.ReadKey();
        }
    }
}
