using System;

namespace StaticMethodsEx2
{
    class NonStaticClass
    {
        static int myStaticVariable = 25;//static variable
        int myInstanceVariable = 50;//instance variable
        //a static method
        public static void StaticMethod()
        {
            Console.WriteLine("NonStaticClass.StaticMethod");
            Console.WriteLine("myStaticVariable = {0}", myStaticVariable);//25
           //Console.WriteLine("StaticMethod->instance variable = {0}", myInstanceVariable);//error
        }
        //a non-static method
        public void NonStaticMethod()
        {
            Console.WriteLine("NonStaticClass.NonStaticMethod");
            Console.WriteLine("NonStaticMethod->static variable = {0}", myStaticVariable);//25 Ok
            //Console.WriteLine("myStaticVariable = {0}", this.myStaticVariable);//Error
            Console.WriteLine("myInstanceVariable = {0}", myInstanceVariable);//50
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring static methods.Example-2***\n");
            NonStaticClass anObject = new NonStaticClass();
            anObject.NonStaticMethod();//Ok
            //anObject.StaticMethod();//Error
            NonStaticClass.StaticMethod();
            Console.ReadKey();
        }
    }
}
