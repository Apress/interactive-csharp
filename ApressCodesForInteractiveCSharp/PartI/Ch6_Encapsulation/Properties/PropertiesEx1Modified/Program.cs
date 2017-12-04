using System;

namespace PropertiesEx1
{
    class MyClass
    {
        private int myInt;// also called as private "backing" field
        public int MyInt //The public property
        {
            get
            {
                return myInt;
            }
            set
            {
                //myInt = value;
                /*Imposing a condition:
                  value should be in between 10 and 25. 
                  Otherwise, you’ll retain the old value*/
                if ((value >= 10) && (value <= 25))
                {
                    myInt = value;
                }
                else
                {                    
                    Console.WriteLine(" The new value {0} cannot be set", value);
                    Console.WriteLine(" Please choose a value between 10 and 25");
                }
            }
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
            Console.WriteLine("\nValue of myInt is now: {0}",ob.MyInt);
            //Setting another value to myInt through MyInt
            ob.MyInt = 100;
            Console.WriteLine("Now myInt value is:{0}",ob.MyInt);
            Console.ReadKey();
        }
    }
}
