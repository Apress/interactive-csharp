using System;

namespace SealedClassVsA_ClassWithPrivateCons
{
    class A1
    {
      public int x;
      private A1() { }
      public A1(int x) { this.x = x; }
    }
    sealed class A2
    {
        //some code..
    }
    class B1 : A1
    {
       public  int y;
        public B1(int x,int y):base(x)
        {
            this.y = y;
        }
    }
    //class B2 : A2 { }//Cannot derive from sealed type 'A2'

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Case study: sealed class vs private constructor***\n");
            B1 obB1 = new B1(2, 3);
            Console.WriteLine("\t x={0}",obB1.x);
            Console.WriteLine("\t y={0}",obB1.y);            
            Console.Read();
        }
    }
}
