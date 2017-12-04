using System;

namespace Example_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Illustration -switch statement***");
            Console.WriteLine(" 1-Below 40");
            Console.WriteLine(" 2-Between 41 and 60");
            Console.WriteLine(" 3-Between 60 and 79");
            Console.WriteLine(" 4-Above 80");
            Console.WriteLine("Enter your score");
            //Using Parse() instead of tryParse() just for a change.
            //Though ,it is suggested that you use tryParse()
            int score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case 1:
                    Console.WriteLine(" Poor performance");
                    break;
                case 2:
                    Console.WriteLine(" Average performance");
                    break;
                case 3:
                    Console.WriteLine(" Good performance");
                    break;
                case 4:
                    Console.WriteLine(" Excellent performance");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}

