using System;

namespace PassReferenceTypeUsingValueEx2
{
    class Program
    {
        static void CheckMe(int[] arr)
        {
            arr[0] = 15;
            arr[1] = 25;
            arr = new int[3] { 100, 200,300};
            Console.WriteLine("********");
            Console.WriteLine("Inside CheckMe(),arr[0]={0}", arr[0]);//100
            Console.WriteLine("Inside CheckMe(),arr[1]={0}", arr[1]);//200 
            Console.WriteLine("Inside CheckMe(),arr[2]={0}", arr[2]);//300    
            Console.WriteLine("********");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Passing reference Type by value.Ex-2***");
            int[] myArray= { 1, 2, 3 };
            Console.WriteLine("At the beginning,myArray[0]={0}", myArray[0]);//1
            Console.WriteLine("At the beginning,myArray[1]={0}", myArray[1]);//2
            Console.WriteLine("At the beginning,myArray[2]={0}", myArray[2]);//3
            CheckMe(myArray);
            Console.WriteLine("At the end,myArray[0]={0}", myArray[0]);//15
            Console.WriteLine("At the end,myArray[1]={0}", myArray[1]);//25
            Console.WriteLine("At the end,myArray[2]={0}", myArray[2]);//3
            Console.ReadKey();
        }
    }
}
