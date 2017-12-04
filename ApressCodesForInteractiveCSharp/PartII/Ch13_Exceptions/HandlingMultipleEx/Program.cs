using System;

namespace HandlingMultipleEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Handling multiple Exceptions***");
            string b1;
            int input;
            Console.WriteLine("Enter your choice( 0 or 1)");
            b1 = Console.ReadLine();
            //Checking whether we can parse the string as an integer
            if (int.TryParse(b1, out input))
            {
                Console.WriteLine("You have entered {0}", input);
                switch (input)
                {
                    case 0:
                        int a = 100, b = 0;
                        try
                        {
                            int c = a / b;
                            Console.WriteLine(" So, the result of a/b is :{0}", c);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Encountered an exception with integers:{0}", ex.Message);
                            Console.WriteLine("Encountered an exception with integers:{0}", ex.StackTrace);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("In Choice0.Exception block ..{0}",ex.Message);                        
                        }
                        break;
                    case 1:
                        int[] myArray = { 1, 2, 3 };
                        try
                        {
                            Console.WriteLine(" myArray[0] :{0}", myArray[0]);
                            Console.WriteLine(" myArray[1] :{0}", myArray[1]);
                            Console.WriteLine(" myArray[2] :{0}", myArray[2]);
                            Console.WriteLine(" myArray[3] :{0}", myArray[3]);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("Encountered an exception with array elements :{0}", ex.Message);
                            Console.WriteLine("Encountered an exception with array elements :{0}", ex.StackTrace);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("In Choice1.Exception block ..{0}", ex.Message);
                        }
                        

                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You have not entered an integer!");
            }            
            Console.ReadKey();
        }
    }
}
