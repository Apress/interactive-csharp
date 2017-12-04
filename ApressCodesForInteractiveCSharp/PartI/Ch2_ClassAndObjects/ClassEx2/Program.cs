using System;

namespace ClassEx2
{
    class ClassA
    {
        public int i;
        public ClassA(int i)
        {
            this.i = i;          
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			Console.WriteLine("*** A class demo with 2 objects ***");
            ClassA obA = new ClassA(10);
            ClassA obB = new ClassA(20);
            Console.WriteLine("obA.i =" + obA.i);
            Console.WriteLine("obB.i =" + obB.i);
            Console.ReadKey();
        }
    }
}

