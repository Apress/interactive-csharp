using System;

namespace Example_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Illustration -if-else***");
            string input;
            int number;
            Console.WriteLine("Enter a number");
            input = Console.ReadLine();
            //Checking whether we can parse the string as an integer
            if (int.TryParse(input, out number))
            {
                Console.WriteLine("You have entered {0}", input);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", number);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", number);
            }
            Console.ReadKey();
        }
    }

}
