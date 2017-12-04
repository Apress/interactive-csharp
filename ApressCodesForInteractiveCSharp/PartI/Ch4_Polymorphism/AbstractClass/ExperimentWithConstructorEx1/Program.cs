using System;


namespace ExperimentWithConstructorEx1
{
    class MyTestClass
    {
        //Constructors cannot be abstract or sealed
        //abstract MyTestClass()//error
        //{
        //    Console.WriteLine("abstract constructor");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Quiz : Experiment with a constructor***\n");
           //MyTestClass ob = new MyTestClass();
            Console.ReadKey();
        }
    }
}
