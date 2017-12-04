using System;

namespace ClassEx1
{
    class ClassEx1
    {
        //Field initialization is optional.
        //public int MyInt = 25;
        public int MyInt;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            Console.WriteLine("*** A class demo with 2 objects ***");
            ClassEx1 obA = new ClassEx1();
            obA.MyInt = 25;//setting 25 into MyInt of obA
            ClassEx1 obB = new ClassEx1();
            obB.MyInt = 30;//setting 30 into MyInt of obB
            Console.WriteLine("obA.i ={0}", obA.MyInt);
            Console.WriteLine("obB.i ={0}", obB.MyInt);
            Console.ReadKey();
        }
    }
}
