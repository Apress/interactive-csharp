using System;

namespace StaticMethodsEx1
{
    class NonStaticClass
    {
        //a static method
        public static void StaticMethod()
        {
            Console.WriteLine("NonStaticClass.StaticMethod");
        }
        //a non-static method
        public void NonStaticMethod()
        {
            Console.WriteLine("NonStaticClass.NonStaticMethod");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring static methods.Example-1***\n");
            NonStaticClass anObject = new NonStaticClass();
            anObject.NonStaticMethod();//Ok
            //anObject.StaticMethod();//Error
            NonStaticClass.StaticMethod();
            Console.ReadKey();
        }
    }
}
