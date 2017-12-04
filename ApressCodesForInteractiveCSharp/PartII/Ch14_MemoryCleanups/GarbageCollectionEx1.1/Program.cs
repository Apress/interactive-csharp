using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace GarbageCollectionEx1._1
{
    class MyClassA : IDisposable
    {
        MyClassB classBObject;
        class MyClassB : IDisposable
        {
            public int Diff(int a, int b)
            {
                return a - b;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
                Console.WriteLine("MyClass B:Dispose() is called");
            }
            ~MyClassB()
            {
                Console.WriteLine("MyClassB:Destructor is Called..");
                System.Threading.Thread.Sleep(10000);
            }
        }
        
        public int Sum(int  a, int b)
        {
            return a + b;
        }
        public int Diff(int a, int b)
        {
            classBObject = new MyClassB();
            return classBObject.Diff(a, b);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("MyClassA:Dispose() is called");
            //if we commentout the below code, destructor of the class will be called.
            //classBObject.Dispose();
        }
        ~MyClassA()
        {
            Console.WriteLine("MyClassA:Destructor is Called..");
            System.Threading.Thread.Sleep(6000);
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Quiz:Exploring Garbage Collections.***");
            MyClassA obA = new MyClassA();
            //MyClassB obB = new MyClassB();
            int sumOfIntegers = obA.Sum(100, 20);
            int diffOfIntegers = obA.Diff(100, 20);
            Console.WriteLine("Sum of 100 and 20 is:{0} ",sumOfIntegers);
            Console.WriteLine("Difference of 100 and 20 is:{0}" ,diffOfIntegers);
            obA.Dispose();
            Console.ReadKey();
        }
    }
}