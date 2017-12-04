using System;

namespace asOperatorDemo
{
    class Program
    {
        class Shape
        {
            public void ShowMe()
            {
                Console.WriteLine("Shape.ShowMe");
            }
        }
        class Circle : Shape
        {
            public void Area()
            {
                Console.WriteLine("Circle.Area");
            }
        }
        class Rectangle : Shape
        {
            public void Area()
            {
                Console.WriteLine("Rectangle.Area");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***as operator demo***\n");
            Shape shapeOb = new Shape();            
            Circle circleOb = new Circle();
            Rectangle rectOb = new Rectangle();
            circleOb = shapeOb as Circle;//no exception
            if( circleOb!=null)
            {
                circleOb.ShowMe();
            }
            else
            {
                Console.WriteLine("'shapeOb as Circle' is prodcuing null ");
            }
            shapeOb = rectOb as Shape;
            if (shapeOb != null)
            {
                Console.WriteLine("'rectOb as Shape' is NOT prodcuing null ");
                shapeOb.ShowMe();
            }
            else
            {
                Console.WriteLine(" shapeOb as Circle is prodcuing null ");
            }

            Console.ReadKey();
        }
    }
}
