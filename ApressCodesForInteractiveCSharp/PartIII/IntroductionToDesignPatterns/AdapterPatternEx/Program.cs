using System;

namespace AdapterPattern
{
    class Rect
    {
        public double l;
        public double w;
    }
    class Calculator
    {
        public double getArea(Rect r)
        {
            return r.l * r.w;
        }
    }
    //Calculate the area of triangle using Calculator and Rect type as input.Whether we have Triangle.
    class Triangle
    {
        public double b;//base
        public double h;//height
        public Triangle(int b, int h)
        {
            this.b = b;
            this.h = h;
        }
    }
    class CalculatorAdapter
    {

        public double getArea(Triangle t)
        {
            Calculator c = new Calculator();
            Rect r = new Rect();
            //Area of Triangle=0.5*base*height
            r.l = t.b;
            r.w = 0.5 * t.h;
            return c.getArea(r);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Demo***\n");
            CalculatorAdapter cal = new CalculatorAdapter();
            Triangle t = new Triangle(20, 10);
            Console.WriteLine("Area of Triangle is " + cal.getArea(t) + " Square unit");
            Console.ReadKey();
        }
    }
}
