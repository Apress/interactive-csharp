using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStmtsTests2
{
    class Program
    {
        static int score;

        static void Main(string[] args)
        {
            int number = 5;
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", number);
                Console.WriteLine("We have not used brackets for if statements");
            }

            else
                Console.WriteLine("{0} is an odd  number", number);
            Console.ReadKey();

        }
    }
}

