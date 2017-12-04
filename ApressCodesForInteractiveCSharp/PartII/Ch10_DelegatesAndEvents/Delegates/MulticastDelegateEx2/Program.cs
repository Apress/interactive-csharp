using System;

namespace MulticastDelegateEx2
{
    public delegate int MultiDel(int a, int b);

    class Program
    {
        public static int Sum(int a, int b)
        {
            Console.Write("Program.Sum->\t");           
            Console.WriteLine("Sum={0}", a+b);
            return a + b;
        }
        public static int Difference(int a, int b)
        {
            Console.Write("Program.Difference->\t");
            Console.WriteLine("Difference={0}", a - b);
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            Console.Write("Program.Multiply->\t");
            Console.WriteLine("Multiplication={0}", a * b);            
            return a * b;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("***Testing a Multicast Delegate***");
            MultiDel md = new MultiDel(Sum);
            md += Difference;
            md += Multiply;
            int c = md(10, 5);
            Console.WriteLine("Analyzing the value of c");
            Console.WriteLine("c={0}", c);
            //md(200, 3);//ok
            Console.ReadKey();
        }
    }
}
