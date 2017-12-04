using System;


namespace StaticConstructorEx1
{
    class A
    {
        static int StaticCount=0,InstanceCount=0;
        //public static A()//Error:Access modifiers not allowed
         static A()
        {
            StaticCount++;
            Console.WriteLine("Static constructor.Count={0}",StaticCount);            
        }
        //Static constructor must be parameterless and a type can have only one static constructor.
        //static A(int A){ }//Error
        public A()
        {
            InstanceCount++;
            Console.WriteLine("Instance constructor.Count={0}", InstanceCount);            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring static constructors***\n");
            A obA1 = new A();//StaticCount=1,InstanceCount=1
            A obA2 = new A();//StaticCount=1,InstanceCount=2
            A obA3 = new A();//StaticCount=1,InstanceCount=3
            
            Console.ReadKey();
        }
    }
}
