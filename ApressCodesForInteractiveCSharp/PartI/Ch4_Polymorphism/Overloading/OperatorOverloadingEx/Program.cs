using System;
namespace OperatorOverloadingEx
{
    class Rectangle
    {
        public double length, breadth;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double AreaOfRectangle()
        {
            return length * breadth;
        }
        /*1.The operator function must be tagged with public and static.
          2.The keyword operator is followed by the operator symbol.*/
        public static Rectangle operator ++ (Rectangle rect)
        {
            rect.length ++;
            rect.breadth++;
            return rect;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Operator Overloading Demo:Overloading ++ operator***\n");
            Rectangle rect = new Rectangle(5, 7);
            Console.WriteLine("Length={0} Unit Breadth={1} Unit", rect.length,rect.breadth);
            Console.WriteLine("Area of Rectangle={0} Sq. Unit",rect.AreaOfRectangle());
            //rect = rect++;
            rect++;
            Console.WriteLine("Modified Length={0} Unit Breadth={1} Unit", rect.length, rect.breadth);
            Console.WriteLine("Area of new Rectangle={0} Sq. Unit", rect.AreaOfRectangle());            
            Console.ReadKey();            
        }
    }
}
