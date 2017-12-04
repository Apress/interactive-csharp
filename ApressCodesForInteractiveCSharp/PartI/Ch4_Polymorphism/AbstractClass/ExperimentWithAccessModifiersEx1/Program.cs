using System;

//Author:To see the error messages, uncomment the lines shown in the book
namespace ExperimentWithAccessModifiersEx1
{
    abstract class IncompleteClass
    {
        public abstract  void ShowMe();        
    }
    class CompleteClass : IncompleteClass
    {
        //protected override void ShowMe()//Error
           public override void ShowMe()
        {
                Console.WriteLine("I am complete.");
                Console.WriteLine("I supplied the method body for showMe().");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Quiz : Experiment with access specifiers***\n");
            IncompleteClass myRef = new CompleteClass();
            myRef.ShowMe();//error -if you use protected instead of public in the above class's ShowMe()

            Console.ReadKey();
        }
    }
}
