using System;
using System.Collections.Generic;


namespace ForVsForEachDemo
{
    class Program
        {
            static void Main(string[] args)
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
                Console.WriteLine("Executing foreach loop");
                foreach (int i in list)
                {
                    Console.WriteLine("\t" + i);
                }
                Console.WriteLine("Executing for loop :");
                for (int i = 0; i < list.Count; i++)
                {
                    int j = list[i];
                    Console.WriteLine("\t" + j);
                }
                Console.ReadKey();
            }
        }
    }
