using System;

namespace Test4_Property
{
    class MyClass
    {
        //private int myInt;
        public int MyInt
        {
           //automatic property declaration
            get;set;
        }
        //C# 6.0 onwards, we can use property initializers like below
        public int MyInt2
        {
            //automatic property declaration
            get; set;
        } = 25;//Automatic initialization
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Properties.Example-1***");
            MyClass ob = new MyClass();
            //ob.myInt = 1;//Error:myInt is inaccessible
            //Setting  a new value
            ob.MyInt = 106;//Ok.We'll get 106
            //Reading the value
            Console.WriteLine("\nValue of myInt is now:" + ob.MyInt);
            Console.WriteLine("\nValue of myInt is now:" + ob.MyInt2);//25
            Console.ReadKey();
        }
    }
}

