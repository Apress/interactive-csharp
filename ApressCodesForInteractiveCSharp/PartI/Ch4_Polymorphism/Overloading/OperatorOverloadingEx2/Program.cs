using System;
/*
 * another good example apart from microsoft:http://www.sanfoundry.com/csharp-program-overloading-binary-operator/
*/
namespace OperatorOverloadingEx2
{
    class ComplexNumber
    {
        public double real,imaganinary;
        public ComplexNumber()
        {
            this.real = 0;
            this.imaganinary = 0;
        }
        public ComplexNumber(double real, double imaginary )
        {
            this.real = real;
            this.imaganinary = imaginary;
        }
        /*1.The operator function must be tagged with public and static.
          2.The keyword operator is followed by the operator symbol.*/

        //Overloading a binary operator +
        public static ComplexNumber operator +(ComplexNumber cnumber1, ComplexNumber cnumber2)
        {
            ComplexNumber temp = new ComplexNumber();
            temp.real = cnumber1.real + cnumber2.real;
            temp.imaganinary = cnumber1.imaganinary + cnumber2.imaganinary;
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Operator Overloading Demo 2:Overloading binary operator + operator***\n");
            ComplexNumber cNumber1 = new ComplexNumber(2.1, 3.2);
            Console.WriteLine("Complex Number1: {0}+{1}i", cNumber1.real,cNumber1.imaganinary); 
            ComplexNumber cNumber2 = new ComplexNumber(1.1, 2.1);
            Console.WriteLine("Complex Number2: {0}+{1}i", cNumber2.real, cNumber2.imaganinary);
            //Using the + operator on Complex numbers
            ComplexNumber cNumber3 = cNumber1 + cNumber2;
            Console.WriteLine("After applying + operator we have got: {0}+{1}i", cNumber3.real, cNumber3.imaganinary);
            Console.ReadKey();
        }
    }
}
