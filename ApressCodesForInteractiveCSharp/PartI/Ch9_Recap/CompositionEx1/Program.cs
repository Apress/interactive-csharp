using System;

namespace CompositionEx1
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("I am in Parent");
        }
    }
    class Child1 : Parent
    {
        public override void Show()
        {
            Console.WriteLine("I am in Child-1");
        }
    }
    class Child2 : Parent
    {
        public override void Show()
        {
            Console.WriteLine("I am in Child-2");
        }
    }
    //class GrandChild : Child1, Child2//Error: Diamond Effect
    //{
    //}
    class GrandChild
    {
        Child1 ch1 = new Child1();
        Child2 ch2 = new Child2();
        public void ShowFromChild1()
        {
            ch1.Show();
        }
        public void ShowFromChild2()
        {
            ch2.Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Composition to handle the Diamond Problem***\n");
            GrandChild gChild = new GrandChild();
            gChild.ShowFromChild1();
            gChild.ShowFromChild2();
            Console.ReadKey();
        }
    }
}
