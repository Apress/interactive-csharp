using System;

namespace InterfaceEx2
{
    interface IMyInterface
    {
        void Show1();
        void Show2();
    }
    //MyClass becomes abstract. It has not implemented Show2() of  IMyInterface
  abstract class MyClass2 : IMyInterface
    {
        public void Show1()
        {
            Console.WriteLine("MyClass.Show1() is implemented.");
        }
        public abstract void Show2();
    }
    class ChildClass : MyClass2
    {
        public override void Show2()
        {
            Console.WriteLine("Child is completing -Show2() .");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Interfaces.Example-2***\n");
            //MyClass myClassOb = new MyClass();//MyClass is abstract now
            //myClassOb.Show();
            MyClass2 myOb = new ChildClass();
            myOb.Show1();
            myOb.Show2();
            Console.ReadKey();
        }
    }
}
