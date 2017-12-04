using System;
using System.Collections.Generic;

namespace GenericEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Use Generics to avoid runtime error***");
            List<int> myGenericList = new List<int>();
            myGenericList.Add(10);
            myGenericList.Add(20);
            //myGenericList.Add("Invalid");// compile time error
            foreach (int myInt in myGenericList)
            {
                Console.WriteLine((int)myInt);//downcasting
            }
            Console.ReadKey();
        }
    }

}
