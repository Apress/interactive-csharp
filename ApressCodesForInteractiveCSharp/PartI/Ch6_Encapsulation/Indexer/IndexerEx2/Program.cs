using System;

namespace IndexerEx2
{
    interface IMyInterface
    {
        int this[int index] { get; set; }
    }
    class MyClass : IMyInterface
    {
        //private int[] myIntegerArray;
        private int[] myIntegerArray = new int[4];
        public int this[int index]
        {
            get
            {
                return myIntegerArray[index];
            }
            set
            {
                myIntegerArray[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Indexers with interfaces***\n");
            MyClass obMyClass = new MyClass();
            //Initializing 0th, 1st and 3rd element using indexers
            obMyClass[0] = 10;
            obMyClass[1] = 20;
            obMyClass[3] = 30;
            for (int i = 0; i <4; i++)
            {
                // Console.WriteLine("\t obMyClass[{0}]={1}", i, obMyClass[i]);
                System.Console.WriteLine("Element #{0} = {1}", i, obMyClass[i]);
            }
            Console.ReadKey();
        }
    }
}
