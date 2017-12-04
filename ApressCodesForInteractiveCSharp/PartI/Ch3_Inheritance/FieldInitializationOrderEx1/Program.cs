using System;

namespace FieldInitializationOrderEx1
{

    /* Test:A field initializer cannot reference the nonstatic field, method, or property 'field' */
    class A
    {
        public int x = 10,y;
        //int y = x + 2;//Compilation Error
        public A()
        {
            y = x + 2;//ok
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Analyzing C#'s field initialization order ***");
            int x = 10;
            int y = x + 4;//ok
            Console.WriteLine("x={0}", x);//10
            Console.WriteLine("y={0}", y);//14
            Console.WriteLine("x in A ={0}", (new A()).x);//10
            Console.WriteLine("y in A= {0}",(new A()).y);//12
            Console.ReadKey();
        }
    }
}
