using System;

namespace NonGenericEx
{
    class NonGenericEx
    {
        public int ShowInteger(int i)
        {
            return i;
        }
        public string ShowString(string s1)
        {
            return s1;
        }
        //public double ShowDouble(double d)
        //{
        //    return d;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A non-generic program example***");
            NonGenericEx nonGenericOb = new NonGenericEx();
            Console.WriteLine("ShowInteger returns :{0}", nonGenericOb.ShowInteger(25));
            Console.WriteLine("ShowString returns :{0}", nonGenericOb.ShowString("Non Generic method called"));
            //Console.WriteLine("ShowDouble returns :{0}", nonGenericOb.ShowDouble(25.5));//error without method definition in the class
            Console.ReadKey();
        }
    }
}
