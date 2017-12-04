using System;

namespace StructsEx1
{
    struct MyStructure
        {
            public int i;
            public MyStructure(int i)
            {
                this.i = i;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("***Different ways of using structures in C# ***");
                MyStructure myS1 = new MyStructure();//OK
                myS1.i = 1;
                Console.WriteLine(" myS1.i={0}", myS1.i);

                //Another way of using structure
                MyStructure myS2 = new MyStructure(10);//OK           
                Console.WriteLine(" myS2.i={0}", myS2.i);

                //Another way of using structure
                MyStructure myS3;
                myS3.i = 100;
                Console.WriteLine(" myS3.i={0}", myS3.i);
                Console.ReadKey();
            }
        }
    }
