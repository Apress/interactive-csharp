using System;

namespace JaggedArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Multidimensional jagged array demo***\n");
            int[][] myJaggedArray = new int[3][];
            myJaggedArray[0] = new int[3];
            myJaggedArray[1] = new int[4];
            myJaggedArray[2] = new int[2];
            //Entering data
            //1st row
            myJaggedArray[0][0] = 1;
            myJaggedArray[0][1] = 2;
            myJaggedArray[0][2] = 3;
            //2nd row
            myJaggedArray[1][0] = 4;
            myJaggedArray[1][1] = 5;
            myJaggedArray[1][2] = 6;
            myJaggedArray[1][3] = 7;
            //3rd row
            myJaggedArray[2][0] = 8;
            myJaggedArray[2][1] = 9;

            //Printing the elements            
            foreach (int[] rows in myJaggedArray)
            {
                foreach (int i in rows)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
