using System;


namespace StringQuizPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Quiz on Strings***");
            string aString=string.Concat("hello", "world!");
            string helloMrX = "Hello" + " Mr. X";
            Console.WriteLine(aString);
            Console.WriteLine(helloMrX);
            string doubleQuotesEx = @"Welcome to ""Dream World"" ";
            Console.WriteLine(doubleQuotesEx);
            string urlEx = @"\\abcd\ef";
            Console.WriteLine(urlEx);
            string blankSpaceAtbeginning = "      This line contains blank spaces at beginning.";
            Console.WriteLine(blankSpaceAtbeginning.Trim());

            char[] trimCharacters = { ' ', '\t', '.', 'd' };
            string blankSpaceAtEnd = "This line contains blank and tab spaces at End.     ";
            Console.WriteLine(blankSpaceAtEnd.TrimEnd(trimCharacters));

            string welcome0 = "Welcome, to C# Basics.";
            foreach (char c in welcome0)
            {
                Console.Write(c);
            }

            //string emptyString = String.Empty;
            //string nullString = null;
            //Console.WriteLine("Length of emptyString is {0}", emptyString.Length);//0
            //Console.WriteLine("Length of nullString is {0}", nullString.Length); //Exception


            string welcome = "Welcome to C# programming";
            string welcome1 = welcome.PadLeft(welcome.Length + 3, '*');
            string welcome2 = welcome1.PadRight(welcome1.Length + 3, '#');
            Console.WriteLine(welcome2);

            string welcome3 = "Welcome to C# programming";
            Console.WriteLine(welcome3.PadRight(5, '*'));
            ////Length of a string
            //Console.WriteLine("Enter a string");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Length of the string \"{0}\" is {1}", inputString, inputString.Length);

            //Own program segment to calculate the length of a string
            Console.WriteLine("Enter a string :");
            string inputString = Console.ReadLine();
            int len = 0;
            foreach (char c in inputString)
            {
                len++;
            }
            Console.WriteLine("Length of the string \"{0}\" is {1}", inputString, len);


            Console.ReadKey();
        }
    }
}
