using System;

namespace StaticClassEx1
{
    static class Rectangle
    {
        public static double Area(double len, double bre)
        {
            return len * bre;
        }       
    }
    //Error:cannot derive from static class 'Rectangle'
    //class ChildRectangle:Rectangle
    //{ }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring class variables.Example-1***\n");
            double length = 25;
            double breadth = 10;
            //Rectangle rect = new Rectangle();//Error
            Console.WriteLine("Area of Rectangle={0} sq. unit", Rectangle.Area(length, breadth));
            Console.ReadKey();            
        }
    }
}
