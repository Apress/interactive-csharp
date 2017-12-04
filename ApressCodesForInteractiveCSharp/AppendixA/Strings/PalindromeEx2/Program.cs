using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string test = Console.ReadLine();
            char[] testForPalindrome = test.ToCharArray();
            int len = testForPalindrome.Length;
            int mid = len / 2;
            bool flag = true;
            //odd palindrome
            if (len % 2 != 0)
            {
                int j = mid + 1;
                for (int i = mid - 1; i >= 0; i--)
                {
                    if (testForPalindrome[i] != testForPalindrome[j])
                    {
                        flag = false;
                    }
                    j++;
                }
                Console.WriteLine("The string {0} is palindrome? {1}", test, flag);
            }
            //even palindrome
            else
            {
                int j = mid;
                for (int i = mid - 1; i >= 0; i--)
                {
                    if (testForPalindrome[i] != testForPalindrome[j])
                    {
                        flag = false;
                    }
                    j++;
                }
                Console.WriteLine("The string {0} is palindrome? {1}", test, flag);
            }
            Console.ReadKey();
        }
    }
}
