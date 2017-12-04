using System;

namespace InheritanceWithPrivateMemberTest
{
    class A
    {
        private int a;
    }
    class B : A { }

    class Program
    {
        static void Main(string[] args)
        {
            B obB = new B();
            A obA = new A();
            //This is a proof that a is also inherited. See the error message.
            //Console.WriteLine(obB.a);//A.a is inaccessible due to its protection level
            //Console.WriteLine(obB.b);//'B' does not contain a definition for 'b' and no extension ......
            //Console.WriteLine(obA.b);//'A' does not contain a definition for 'b' and no extension ......
        }
    }
}
