using System;

namespace Quiz1OnDelegate
{
    public delegate int Mydel1(int x, int y);
    public delegate int Mydel2(int x, int y,int z);

    class A
    {
        //Overloaded non static Methods
        public int Sum(int a, int b) { return a + b; }
        public int Sum(int a, int b,int c) { return a + b+ c; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Quiz on Delegate***");
            int a = 25, b = 37, c=100;
            A obA1 = new A();
            A obA2 = new A();

            Mydel1 del1 = obA1.Sum;//Pointing Sum(int a, int b)
            Console.WriteLine("del1 is pointing Sum(int a,int b):");
            Console.WriteLine("Sum of a and b is: {0}", del1(a, b));

            Mydel2 del2 = obA1.Sum;//pointing Sum(int a, int b, int c)
            Console.WriteLine("del2 is pointing Sum(int a,int b,int c):");
            Console.WriteLine("Sum of a, b and c is: {0}", del2(a, b,c));
            //same as 
            //Console.WriteLine("Sum of a, b and c is: {0}", del2.Invoke(a, b, c));
            Console.ReadKey();
        }
    }
}

