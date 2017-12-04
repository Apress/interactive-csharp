using System;


namespace ArrayEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Demo: A simple array example ***");
            //int[] myInts = new int[3];
            //myInts[0] = 5;
            //myInts[1] = 15;
            //myInts[2] = 25;
            //Alternative approach-2
            int[] myInts = new int[] { 5, 15,25 };
            //Alternative approach-3
            //int[] myInts = { 5,15,25 };
            Console.WriteLine("Elements of myInts array are as follows:");
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(myInts[i]);
            }
            Console.ReadKey();
        }
    }
}
