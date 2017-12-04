using System;

namespace GenericEx1
{
    class MyGenericClass<T>
    {
        public T Show(T value)
        {
            return value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Introduction to Generics***");
            MyGenericClass<int> myGenericClassIntOb = new MyGenericClass<int>();
            Console.WriteLine("Show returns :{0}", myGenericClassIntOb.Show(100));
            MyGenericClass<string> myGenericClassStringOb = new MyGenericClass<string>();
            Console.WriteLine("Show returns :{0}", myGenericClassStringOb.Show("Generic method called"));
            MyGenericClass<double> myGenericClassDoubleOb = new MyGenericClass<double>();
            Console.WriteLine("Show returns :{0}", myGenericClassDoubleOb.Show(100.5));

            Console.ReadKey();
        }
    }

}
