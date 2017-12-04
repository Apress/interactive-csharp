using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OverloadingEx1
{
    class OverloadEx1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        public string Add(String s1, String s2)
        {
            return string.Concat(s1, s2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Concept of method Overloading***\n\n");
            OverloadEx1 ob = new OverloadEx1();
            Console.WriteLine("2+3={0}", ob.Add(2, 3));
            Console.WriteLine("20.5+30.7={0}", ob.Add(20.5, 30.7));
            Console.WriteLine("Amit + Bose ={0}", ob.Add("Amit","Bose"));
            Console.ReadKey();
        }
    }
}
