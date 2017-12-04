using System;

namespace DefaultConstructorCaseStudy
{
    
    class DefConsDemo
    {
        public int myInt;
        public float myFloat;
        public double myDouble;
        /*To initialize with your specified choice, otherwise , it will take from the default value of the default table*/
        //https://msdn.microsoft.com/en-us/library/83fhsxwc.aspx
        public DefConsDemo()
        {
            Console.WriteLine("I am initializing with my own choice");
            myInt = 10;
            myFloat = 0.123456F;
            myDouble = 9.8765432;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Comparison between user-defined and  C# provided default constructors***\n");
            DefConsDemo ObDef = new DefConsDemo();
            Console.WriteLine("myInt={0}", ObDef.myInt);
            Console.WriteLine("myFloat={0}", ObDef.myFloat.ToString("0.0####"));
            Console.WriteLine("myDouble={0}", ObDef.myDouble);
            Console.Read();
        }
    }
}


