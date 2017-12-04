using System;

namespace QuizOnProperty
{
    class MyClass
    {
        private double radius = 10;
        //public double Radius
        //{
        //    get { return radius; }

        //}
        //Expression bodied properties(C#6.0 onwards)
        public double Radius => radius;
        public double Area => 3.14 * radius * radius;        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Quiz on Properties***");
            MyClass ob = new MyClass();
            //Console.WriteLine("Radius of the circle {0} unit", ob.Radius);
            Console.WriteLine("Area of the circle is {0} sq. unit", ob.Area);
            Console.ReadKey();
        }
    }
}