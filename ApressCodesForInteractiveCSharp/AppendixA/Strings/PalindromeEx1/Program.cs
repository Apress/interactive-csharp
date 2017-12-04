using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace PalindromeEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Program to check palindrome strings***");
            Console.WriteLine("Enter the string:");
            string s1 = Console.ReadLine();
            //string s1 = "abccba";
            char[] tempArray = s1.ToCharArray();
            Array.Reverse(tempArray);
            //change the reverse array to a string and compare
            string reverseStr = new string(tempArray);
            if (s1.Equals(reverseStr))
            {
                Console.WriteLine("String \" {0} \" is a palindrome string, reverse string of it is :\n {1}", s1, reverseStr);
            }
            else
            {
                Console.WriteLine("String \"{0}\"is a Not palindrome string,reverse string of it is:\n {1}", s1, reverseStr);
            }
            Console.ReadKey();
        }        
    }
}
