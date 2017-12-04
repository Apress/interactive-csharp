using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationEx1
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
        Child1 ch1;
        Child2 ch2;
        public GrandChild(Child1 ch1, Child2 ch2)
        {
            this.ch1 = ch1;
            this.ch2 = ch2;
        }
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
            Console.WriteLine("***Aggregation to handle the Diamond Problem***\n");
            Child1 child1 = new Child1();
            Child2 child2 = new Child2();
            GrandChild gChild = new GrandChild(child1,child2);
            gChild.ShowFromChild1();
            gChild.ShowFromChild2();
            Console.ReadKey();
        }
    }
}
