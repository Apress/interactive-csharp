using System;

namespace SelectionStmtsTests
{
    class Program
    {
        static int score;

        static void Main(string[] args)
        {
            switch (score)
            {
                case 1:
                    Console.WriteLine(" Poor performance");
                    break;
                case 2:
                    Console.WriteLine(" Good performance");
                    //break;//compilation error if we comment out this line
                    break;
                default:
                    break;
                case 3:
                    Console.WriteLine(" Excellent performance");
                    break;
            }         

        }
    }
}
