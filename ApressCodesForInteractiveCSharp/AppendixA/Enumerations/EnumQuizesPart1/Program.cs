using System;

namespace EnumQuizes
{
    class Program
    {
        //enum Values { val1 = 37, val2 = 69, val3 = 175 };//ok
        //static void Main(string[] args)
        //{
        //Console.WriteLine("** Quiz on enum ***");
        //Console.ReadKey();
        //}
        //int a = 20;//error
        //static int a = 20;//error
        const int MYCONST = 50;//ok
        //static readonly int MYCONST = 50;//error
        enum Values { val1, val2 = MYCONST, val3, val4=21, val5 };
        static void Main(string[] args)
        {
            Console.WriteLine("** Quiz on enum ***");
            int x1 = (int)Values.val1;//0
            int x2 = (int)Values.val2;//50
            int x3 = (int)Values.val3;//12
            int x4 = (int)Values.val4;//13
            int x5 = (int)Values.val5;//14
            Console.WriteLine("x1={0}", x1);
            Console.WriteLine("x2={0}", x2);
            Console.WriteLine("x3={0}", x3);
            Console.WriteLine("x4={0}", x4);
            Console.WriteLine("x5={0}", x5);
            Console.ReadKey();
        }
    }
}
