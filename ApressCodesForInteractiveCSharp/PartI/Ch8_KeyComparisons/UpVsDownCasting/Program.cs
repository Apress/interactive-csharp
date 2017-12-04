using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UpVsDownCastingEx1
{
    class Shape
    {
        public void ShowMe()
        {
            Console.WriteLine("Shape.ShowMe");
        }
    }
    class Circle:Shape
    {
        public void Area()
        {
            Console.WriteLine("Circle.Area");
        }
    }
    class Rectangle:Shape
    {
        public void Area()
        {
            Console.WriteLine("Rectangle.Area");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Upcasting Example***\n");
            Circle circleOb = new Circle();
            //Shape shapeOb = new Circle();//upcasting
            Shape shapeOb = circleOb;//Upcasting
            shapeOb.ShowMe();
            //shapeOb.Area();//Error
            circleOb.Area();//ok

            Circle circleOb2 = (Circle)shapeOb;//Downcast
            circleOb2.Area();//ok
           
            Console.ReadKey();
        }
    }
}
