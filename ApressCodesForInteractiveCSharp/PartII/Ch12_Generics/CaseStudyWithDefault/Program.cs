using System;

namespace CaseStudyWithDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Case study- default keyword***");
            Console.WriteLine("default(int) is {0}", default(int));//0
            bool b1 = (default(int) == null);//False
            Console.WriteLine("default(int) is null ?Answer: {0}", b1);
            Console.WriteLine("default(string) is {0}", default(string));//null
            bool b2 = (default(string) == null);//True
            Console.WriteLine("default(string) is  null ? Answer:{0}", b2);
            Console.ReadKey();
        }
    }

}
