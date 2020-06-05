using System;

namespace Test1_FuncVsActionVsPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Testing Func vs Action vs Predicate***");
            //Func
            Console.WriteLine("<---Using Func--->");
            Func<string, int, string> student = new Func<string, int, string>(ShowStudent);
            Console.WriteLine(student("Amit", 1));
            Console.WriteLine(student("Sumit", 2));
            //Action
            Console.WriteLine("<---Using Action--->");
            Action<int, int, int> sum = new Action<int, int, int>(SumOfThreeNumbers);
            sum(10, 3, 7);
            sum(5, 10, 15);

            //Predicate
            Console.WriteLine("<---Using Predicate--->");
            Predicate<int> isGreater = new Predicate<int>(GreaterThan100);
            Console.WriteLine("125 is greater than 100? {0}", isGreater(125));
            Console.WriteLine("60 is greater than 100? {0}", isGreater(60));

            Console.ReadKey();
        }
        private static string ShowStudent(string name, int rollNo)
        {
            return string.Format("Student Name is :{0} and  Roll Number is :{1}", name, rollNo);
        }
        private static void SumOfThreeNumbers(int i1, int i2, int i3)
        {
            int sum = i1 + i2 + i3;
            Console.WriteLine("Sum of {0},{1} and {2} is: {3}", i1, i2, i3, sum);
        }
        private static bool GreaterThan100(int myInt)
        {
            return myInt > 100 ? true : false;
        }
    }
}
