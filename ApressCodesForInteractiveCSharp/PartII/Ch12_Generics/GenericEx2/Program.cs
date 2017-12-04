using System;
using System.Collections;

namespace GenericEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Use Generics to avoid runtime error***");
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add(20);
            myList.Add("Invalid");//No compile time error but will cause runtime error
            foreach (int myInt in myList)
            {
                Console.WriteLine((int)myInt); //downcasting
            }
            Console.ReadKey();
        }
    }

}
