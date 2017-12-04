using System;

namespace OverridingEx4
{
    class ParentClass
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("Inside Parent.ShowMe");
        }
    }
    class ChildClass1 : ParentClass
    {
        public override void ShowMe()
        {
            Console.WriteLine("Inside Child.ShowMe");
        }
    }
    class ChildClass2 : ParentClass
    {
        public new void ShowMe()
        {
            Console.WriteLine("Inside Child.ShowMe");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Use of 'new' in the context of method Overriding.Example-2 ***\n");
            ParentClass parentOb;
            parentOb= new ParentClass();
            parentOb.ShowMe();   
            parentOb = new ChildClass1();
            parentOb.ShowMe();//Inside Child.ShowMe
            parentOb = new ChildClass2();
            parentOb.ShowMe();//Inside Parent.ShowMe  

            Console.ReadKey();
        }
    }
}
