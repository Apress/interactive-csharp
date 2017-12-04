using System;

namespace QuizOnSealedEx1
{
    class QuizOnSealed
    {
        public virtual void TestMe()
        {
            Console.WriteLine("I am in Class-1");
        }

    }
    class Class1: QuizOnSealed
    {
        sealed public override void TestMe()
        {
            Console.WriteLine("I am in Class-1");
        }
    }
    class Class2: QuizOnSealed
    {
        public override void TestMe()
        {
            Console.WriteLine("I am in Classs-2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Quiz on sealed keyword usage***\n");
            Class2 obClass2 = new Class2();
            obClass2.TestMe();
            Console.ReadKey();
        }
    }
}
