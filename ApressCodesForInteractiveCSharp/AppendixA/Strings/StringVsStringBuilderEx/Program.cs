using System;
using System.Runtime.Serialization;//for ObjectIDGenerator
using System.Text;//for StringBuilder


namespace StringVsStringBuilderEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***String vs String builder***\n");
            ObjectIDGenerator idGenerator = new ObjectIDGenerator();
            bool firstTime = new bool();

            string myString = "Hello World";
            Console.WriteLine("{0} Instance Id now : {1}", myString, idGenerator.GetId(myString, out firstTime));
            //creates new instance ID
            myString = myString + ",programmer";
            Console.WriteLine("{0} Instance Id now : {1}", myString, idGenerator.GetId(myString, out firstTime));

            StringBuilder myStringBuilder = new StringBuilder("Hello , Mr  StringBuilder");
            Console.WriteLine("{0} Instance Id : {1}", myStringBuilder, idGenerator.GetId(myStringBuilder, out firstTime));
            //Do not create a new instance ID
            myStringBuilder = myStringBuilder.Replace("Hello", "Welcome");
            Console.WriteLine("{0} Instance Id : {1}", myStringBuilder, idGenerator.GetId(myStringBuilder, out firstTime));
            Console.ReadKey();
        }
    }
}
