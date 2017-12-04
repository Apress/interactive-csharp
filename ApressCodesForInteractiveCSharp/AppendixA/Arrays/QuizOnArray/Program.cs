using System;


namespace QuizOnArray
{
    //Quiz-1
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("**Test on Array initialization***");
    //        int[] myIntArray = new int[4];
    //        for (int i = 0; i < myIntArray.Length; i++)
    //        {
    //            Console.WriteLine("myIntArray[" + i + "] is : {0}", myIntArray[i]);
    //        }
    //        Console.WriteLine();
    //        string[] myStringArray = new string[4];
    //        for (int i = 0; i < myStringArray.Length; i++)
    //        {
    //            bool value = string.IsNullOrEmpty(myStringArray[i]);
    //            if (value)
    //            {
    //                Console.WriteLine("myStringArray[" + i + "] is null.");
    //            }
    //            else
    //            {
    //                Console.WriteLine("myStringArray[" + i + "] is NOT  null.");
    //            }
    //        }
    //        Console.ReadKey();
    //    }
    //}

    //Quiz-2
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Quiz on Arrays***");
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[6] { 5, 6, 7, 8, 9, 10 };
            jaggedArray[2] = new int[2] { 11,12 };
            Console.WriteLine(jaggedArray[0].GetUpperBound(0));//3
            Console.WriteLine(jaggedArray[1].GetUpperBound(0));//5
            Console.WriteLine(jaggedArray[2].GetUpperBound(0));//1
            //Console.WriteLine(jaggedArray[0].GetUpperBound(1));//IndexOutOfRangeException
            //Console.WriteLine(jaggedArray.GetUpperBound(0));//2
            //Console.WriteLine(jaggedArray.Length);//3

            //int[,] rectArray = new int[3, 4];
            //Console.WriteLine(rectArray.Length);//3*4=12

            Console.ReadKey();            
        }
    }
}
