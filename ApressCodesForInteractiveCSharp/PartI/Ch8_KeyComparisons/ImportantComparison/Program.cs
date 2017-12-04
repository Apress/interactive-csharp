using System;

namespace ImportantComparison
{
    struct MyStruct
    {
        public int i;
    }
    class MyClass
    {
        public int i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Test-valueTypes vs Reference Types***\n");
            MyStruct struct1, struct2;
            struct1=new MyStruct();
            struct1.i = 1;
            struct2 = struct1;
            MyClass class1, class2;
            class1= new MyClass();
            class1.i = 2;
            class2 = class1;


            Console.WriteLine("struct1.i={0}", struct1.i);//1
            Console.WriteLine("struct2.i={0}", struct2.i);//1
            Console.WriteLine("class1.i={0}", class1.i);//2
            Console.WriteLine("class2.i={0}", class2.i);//2

            Console.WriteLine("***Making changes to strcut1.i(10) and class1.i (20)***");
            struct1.i = 10;
            class1.i = 20;

            Console.WriteLine("***After the changes, values are :***");
            Console.WriteLine("struct1.i={0}", struct1.i);//10
            Console.WriteLine("struct2.i={0}", struct2.i);//1
            Console.WriteLine("class1.i={0}", class1.i);//20
            Console.WriteLine("class2.i={0}", class2.i);//20


            Console.ReadKey();
        }
    }
}
