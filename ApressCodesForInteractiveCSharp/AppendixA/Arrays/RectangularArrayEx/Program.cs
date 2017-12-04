using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace RectangularArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A rectangular 2D array example ***");
            Console.WriteLine("Enter how many rows you want?");
            String rowSize = Console.ReadLine();
            int row = int.Parse(rowSize);
            Console.WriteLine("Enter how many columns you want?");
            String columnSize = Console.ReadLine();
            int column = int.Parse(columnSize);
            int[,] myArray = new int[row, column];
            Console.WriteLine("Enter all the {0} data from keyboard",row*column);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Printing the matrix
            Console.WriteLine("Your matrix is as below:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
