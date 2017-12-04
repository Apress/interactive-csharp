using System;
using System.Collections.Generic;
using System.Diagnostics;//For Stopwatch

namespace PerformanceOfBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Performance analysis in Boxing ***");
            List<int> myInts = new List<int>();
            Stopwatch myStopwatch1 = new Stopwatch();
            myStopwatch1.Start();
            for (int i = 0; i < 1000000; i++)
            {
            //Adding an integer to a list of Integers. So, there is no need of boxing.(Advantage of Generics)
                myInts.Add(i);
            }
            myStopwatch1.Stop();
            Console.WriteLine("Time taken without Boxing: {0}", myStopwatch1.Elapsed);

            //Now we are testing :Boxing Performance

            List<object> myObjects = new List<object>();
            Stopwatch myStopwatch2 = new Stopwatch();
            myStopwatch2.Start();
            for (int i = 0; i < 1000000; i++)
            {
                //Adding an integer to a list of Objects. So, there is need of boxing.
                myObjects.Add(i);
            }
            myStopwatch2.Stop();
            Console.WriteLine("Time taken with    Boxing :{0}", myStopwatch2.Elapsed);
            Console.ReadKey();
        }
    }
}
