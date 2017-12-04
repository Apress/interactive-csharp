using System;

namespace DoWhileEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Illustration:do...while***");
            int j = 5;
            do
            {
                Console.WriteLine("Inside loop:j is now {0}", j);
                j++;
            } while (j < 10);
            Console.WriteLine(" Outside loop: Final value in j is {0}", j);

            Console.ReadKey();
        }
    }
}
