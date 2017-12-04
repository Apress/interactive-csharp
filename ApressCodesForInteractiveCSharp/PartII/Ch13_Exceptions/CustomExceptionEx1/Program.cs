using System;
/*1. In Exception hierarchy, we noticed 2 major types of exception classes-SystemException and ApplicationException. A SystemException is thrown by runtime (CLR) and an ApplicationException was supposed to thrown by user programs. So, it was suggested that user defined exceptions should derive from ApplicationException class. But later MSDN suggested this:
“You should derive custom exceptions from the Exception class rather than the ApplicationException class. You should not throw an ApplicationException exception in your code, and you should not catch an ApplicationException exception unless you intend to re-throw the original exception”.*
2. When we create our own exception, the class name should end with the word “Exception”.*
3. Lastly, supply the most common 3 overloaded version of constructors.*

* Refer the links for these suggestions:
1. https://msdn.microsoft.com/en-us/library/system.applicationexception.aspx
2. https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions
*/

namespace CustomExceptionEx1
{
    class ZeroDivisorException : Exception
    {
        public ZeroDivisorException() : base("Divisor is zero")
        { }
        public ZeroDivisorException(string msg) : base(msg)
        { }
        public ZeroDivisorException(string msg, Exception inner) : base(msg, inner)
        { }
    }
    class TestCustomeException
    {
        int c;
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                //Ex.Message= "Divisor should not be Zero"
                //throw new ZeroDivisorException("Divisor should not be Zero");
                //Ex.Message= "Divisor is Zero"
                throw new ZeroDivisorException();
            }
            c = a / b;
            Console.WriteLine("Division completed");
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A Custom Exception Example***");
            int a = 10, b = 1, result;
            try
            {
                b--;
                TestCustomeException testOb = new TestCustomeException();
                result = testOb.Divide(a, b);
            }
            catch (ZeroDivisorException ex)
            {
                Console.WriteLine("Caught the custom exception: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("\nExample completed");
                Console.ReadKey();
            }
        }
    }
}
