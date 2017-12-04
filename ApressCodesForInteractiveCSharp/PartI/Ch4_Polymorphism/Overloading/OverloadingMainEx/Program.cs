using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMainEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Testing Overloaded version of Main()***");
            Console.WriteLine("I am inside Main(string[] args) now");
            Console.WriteLine("Calling overloaded version\n");
            Main(5);
            //Console.WriteLine("***Concept of method Overloading***\n\n");
            Console.ReadKey();
        }
        static void Main(int a)
        {
            Console.WriteLine("I am inside Main(int a) now");
        }
        //static void Main()
        //{
        //    Console.WriteLine("I am inside Main() now");
        //    Console.ReadKey();
        //}
    }
}
