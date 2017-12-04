using System;

namespace UseOfgoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Illustration -goto statement***");
            //infinite loop
            //starttesting:
            int i = 5;
            //our label
            starttesting:
            while (i != 10)
            {
                i++;
                Console.WriteLine("i is now {0}", i);
                if (i == 8)
                {
                    Console.WriteLine(" Entered inside if loop");
                    i++;//making i=9 now
                    goto starttesting;//transferring control 
                    //Warning CS0162 :Unreachable code detected
                    //Console.WriteLine(" I am still in if  loop");
                }
            }
            Console.ReadKey();
        }
    }
}
