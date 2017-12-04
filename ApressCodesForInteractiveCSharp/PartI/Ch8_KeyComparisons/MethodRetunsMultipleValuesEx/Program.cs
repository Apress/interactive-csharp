using System;

namespace MethodRetunsMultipleValuesEx
{
    class Program
    {        
            static void RetunMultipleValues(int x, out double area, out double perimeter)
            {
                area = 3.14 * x * x;
                perimeter = 2 * 3.14 * x;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("***A method returning multiple values***");
                int myVariable3 = 3;
                double area = 0.0, perimeter = 0.0;
                RetunMultipleValues(myVariable3, out area, out perimeter);
                Console.WriteLine("Area of the circle is  {0} sq. unit", area);
                Console.WriteLine("Peremeter  of the Cicle is  {0} unit", perimeter);
                Console.ReadKey();
            }
        }    
}
