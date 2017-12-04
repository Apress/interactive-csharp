using System;

namespace MulticastDelegateEx1
{
    public delegate void MultiDel();

    class Program
    {
        public static void show1() { Console.WriteLine("Program.Show1()"); }
        public static void show2() { Console.WriteLine("Program.Show2()"); }
        public static void show3() { Console.WriteLine("Program.Show3()"); }
        static void Main(string[] args)
        {
            Console.WriteLine("***Example of a Multicast Delegate***");
            MultiDel md = new MultiDel(show1);
            md += show2;
            md += show3;
            md();
            Console.ReadKey();
        }
    }
}
