using System;

namespace GarbageCollectionEx1
{
    class MyClass : IDisposable
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Dispose() is called");
        }
        ~MyClass()
        {
            Console.WriteLine("Destructor is Called..");
            System.Threading.Thread.Sleep(5000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Exploring Garbage Collections.Example-1***");
            MyClass myOb = new MyClass();
            int sumOfIntegers = myOb.Sum(10,20);
            Console.WriteLine("Sum of 10 and 20 is: " + sumOfIntegers);
            myOb.Dispose();
            Console.ReadKey();
        }
    }
}

