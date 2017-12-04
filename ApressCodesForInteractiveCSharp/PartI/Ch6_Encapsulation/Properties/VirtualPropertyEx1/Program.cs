using System;

namespace VirtualPropertyEx1
{
  class Shape
    {
        public virtual double Area
        {
            get
            {
                return 0;
            }
        }
    }
    class Circle : Shape
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;

        }
        public int Radius
        {
            get
            {
                return radius;
            }
        }
        public override double Area
        {
            get
            {
                return 3.14 * radius * radius;                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Case study with a virtual Property***");
            Circle myCircle = new Circle(10);           
            Console.WriteLine("\nRadius of the Cricle is {0} Unit", myCircle.Radius);
            Console.WriteLine("Area of the Circle is {0} sq. Unit",myCircle.Area);
            Console.ReadKey();
        }
    }
}
