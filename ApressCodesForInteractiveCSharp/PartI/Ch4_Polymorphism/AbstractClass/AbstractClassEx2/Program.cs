using System;


namespace AbstractClassEx2
{
    abstract class MyAbstractClass
    {
        protected int myInt = 25;
        public abstract void ShowMe();
        public virtual void CompleteMethod1()
        {
            Console.WriteLine("MyAbstractClass.CompleteMethod1()");
        }
        public void CompleteMethod2()
        {
            Console.WriteLine("MyAbstractClass.CompleteMethod2()");
        }

    }
    class MyConcreteClass : MyAbstractClass
    {
        public override void ShowMe()
        {
            Console.WriteLine("I am from a concrete class.");
            Console.WriteLine("My ShowMe() method body is complete.");
            Console.WriteLine("value of myInt is {0}",myInt);
        }
        public override void CompleteMethod1()
        {
            Console.WriteLine("MyConcreteClass.CompleteMethod1()");            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Abstract class Example-2 ***\n");
            //Error:Cannot create an instance of the abstract class
            // MyAbstractClass abstractOb=new MyAbstractClass();
            MyConcreteClass concreteOb = new MyConcreteClass();
            concreteOb.ShowMe();
            concreteOb.CompleteMethod1();
            concreteOb.CompleteMethod2();
            Console.WriteLine("\n\n*** Invoking methods through parent class reference now ***\n");
            MyAbstractClass absRef = concreteOb;
            absRef.ShowMe();
            absRef.CompleteMethod1();
            absRef.CompleteMethod2();            
            Console.ReadKey();
        }
    }
}
