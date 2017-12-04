using System;

namespace IsOperatorDemo
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
    class Triangle : Shape
    {
        public void Area()
        {
            Console.WriteLine("Triangle.Area");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***is operator demo***\n");
            //Initialization-all counts are 0 at this point
            int noOfCircle = 0, noOfRect = 0, noOfTriangle = 0;

            //Creating 2 different circle object
            Circle circleOb1 = new Circle();
            Circle circleOb2 = new Circle();
            //Creating 3 different rectangle object
            Rectangle rectOb1 = new Rectangle();
            Rectangle rectOb2 = new Rectangle();
            Rectangle rectOb3 = new Rectangle();
            //Creating 1 Triangle object
            Triangle triOb1 = new Triangle();
            Shape[] shapes = { circleOb1, rectOb1,circleOb2, rectOb2,triOb1,rectOb3 };            
            for(int i=0;i<shapes.Length;i++)
            {
                if( shapes[i] is Circle)
                {
                   noOfCircle++;
                }
                else if (shapes[i] is Rectangle)
                {
                    noOfRect++;
                }
                else
                {
                    noOfTriangle++;
                }
            }
            Console.WriteLine("No of Circles in shapes array is {0}", noOfCircle);
            Console.WriteLine("No of Rectangles in shapes array is {0}", noOfRect);
            Console.WriteLine("No of Triangle in shapes array is {0}", noOfTriangle);

         //#region Simple facts
         //   /*So always you can test the simple fact that 
         //    * All Circles are Shapes but the reverse is not true with the following line of codes:
         //    */
         //   Console.WriteLine("*****");
         //   Shape s = new Shape();
         //   Circle c = new Circle();
         //   Console.WriteLine("Any Circle is a Shape?{0}", c is Shape);//True
         //   Console.WriteLine("Any Shape is a Circle? {0}", (s is Circle));//False
         //#endregion

            Console.ReadKey();
        }
    }
}
