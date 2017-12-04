using System;

namespace OverridingEx3
{
    class ParentClass
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("Inside Parent.ShowMe");
        }        
    }
    class ChildClass : ParentClass
    {
        public new void ShowMe()
        //public void ShowMe()
        {
            Console.WriteLine("Inside Child.ShowMe");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Use of 'new' in the context of method Overriding ***\n");
            ParentClass parentOb = new ParentClass();
            parentOb.ShowMe();//Calling Parent version     
            ChildClass childOb = new ChildClass();
            childOb.ShowMe();//Calling Child version            
            Console.ReadKey();
        }
    }
}
