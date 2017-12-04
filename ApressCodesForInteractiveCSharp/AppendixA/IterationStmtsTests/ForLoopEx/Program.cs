using System;

namespace ForLoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Illustration: for loop***");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("i is now {0}", i);
            //}
            //Equivalent while loop
            Console.WriteLine("***Illustration: while loop***");
            int i = 0;
            while (i < 5)
                //while ()//error
                //while()//error
                //while(true && true)//infinite loop
                {
                Console.WriteLine("i is now {0}", i);
                i++;
            }
            Console.ReadKey();
        }
    }
}