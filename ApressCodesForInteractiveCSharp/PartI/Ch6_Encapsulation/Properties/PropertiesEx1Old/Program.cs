using System;

namespace PropertiesEx1Old
{
    class MyClass
    {
        private int myInt; // also called as private "backing" field
        //public int MyInt //The public property
        //{
        //    get
        //    {
        //        return myInt;
        //    }
        //    set
        //    {
        //        myInt = value;
        //    }
        //}
        //C#7.0 onwards
        public int MyInt
        {
            get => myInt;
            set => myInt = value;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Properties.Example-1***");
            MyClass ob = new MyClass();
            //ob.myInt = 10;//Error:myInt is inaccessible
            //Setting  a new value
            ob.MyInt = 10;//Ok.We'll get 10
            //Reading the value
            Console.WriteLine("\nValue of myInt is now:{0}", ob.MyInt);
            //Setting another value to myInt through MyInt
            ob.MyInt = 100;
            Console.WriteLine("Now myInt value is:{0}", ob.MyInt);//100
            Console.ReadKey();
        }
    }
}

