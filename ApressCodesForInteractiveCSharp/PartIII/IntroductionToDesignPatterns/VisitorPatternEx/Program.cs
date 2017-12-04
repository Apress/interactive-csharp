using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace VisitorPatternEx
{
    interface IOriginalInterface
    {
        void accept(IVisitor visitor);
    }
    class MyClass : IOriginalInterface
    {
        private int myInt = 5;//Initial or default value

        public int MyInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }
        public void accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer:{0}", myInt);
            visitor.visit(this);
            Console.WriteLine("\nValue of the integer now:{0}", myInt);
        }
    }

    interface IVisitor
    {
        void visit(MyClass myClassElement);
    }
    class Visitor : IVisitor
    {
        public void visit(MyClass myClassElement)
        {
            Console.WriteLine("Visitor is trying to change the integer value");
            myClassElement.MyInt = 100;
            Console.WriteLine("Exiting from Visitor- visit");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern Demo***\n");
            IVisitor v = new Visitor();
            MyClass myClass = new MyClass();
            myClass.accept(v);
            Console.ReadLine();
        }
    }

}
