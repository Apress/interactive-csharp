using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OverridingEx1
{
    class ParentClass
    {
        public virtual void ShowMe()            
        {
            Console.WriteLine("Inside Parent.ShowMe");
        }
        public void DoNotChangeMe()
        {
            Console.WriteLine("Inside Parent.DoNotChangeMe");
        }
    }
    class ChildClass :ParentClass
    {
        public override void ShowMe()  //Error   
        //protected override void ShowMe()  //Error         
        {
            Console.WriteLine("Inside Child.ShowMe");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Method Overriding Demo***\n\n");
            ChildClass childOb = new ChildClass();
            childOb.ShowMe();//Calling Child version
            childOb.DoNotChangeMe();
            Console.ReadKey();
        }
    }
}
