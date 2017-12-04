using System;

namespace PassReferenceTypeUsingValue
{
    class Program
    {
        static void CheckMe(string s)
        {
            s = "World";
            Console.WriteLine("Inside CheckMe(), the  string value is {0}", s);//World
        }
        static void Main(string[] args)
        {
            string s = "Hello";
            Console.WriteLine("Inside Main(), Initially the  string value is {0}", s);//Hello
            CheckMe(s);
            Console.WriteLine("Inside Main(), finally the  string value is {0}", s);//Hello
            Console.ReadKey();
        }
    }

}
