using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace GarbageCollectionEx4
{
    class MyClass
    {
        private int myInt;
        private int myInt2;
        private double myDouble;
        
        public MyClass()
        {
            myInt = 25;
            myInt2 = 100;
            myDouble = 100.5;         
        }
        public void ShowMe()
        {
            Console.WriteLine("MyClass.ShowMe()");
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Dispose() is called");
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
        }
        ~MyClass()
        {
            Console.WriteLine("Destructor is Called..");
            Console.WriteLine(" After this destruction, total Memory:" + GC.GetTotalMemory(false));
            //To catch the output at end,we are putting some sleep
            System.Threading.Thread.Sleep(60000);
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Exploring Garbage Collections.Example-4***");
            try
            {
                Console.WriteLine("Maximum Generations of GC:" + GC.MaxGeneration);
                Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
                MyClass myOb = new MyClass();
                Console.WriteLine("myOb is in Generation : {0}", GC.GetGeneration(myOb));
                Console.WriteLine("Now Total Memory is:{0}" , GC.GetTotalMemory(false));
                Console.WriteLine("Collection occured in 0th Generation:{0}", GC.CollectionCount(0));
                Console.WriteLine("Collection occured in 1th Generation:{0}", GC.CollectionCount(1));
                Console.WriteLine("Collection occured in 2th Generation:{0}", GC.CollectionCount(2));

                //myOb.Dispose();

                GC.Collect(0);//will call generation 0
                Console.WriteLine("\n After GC.Collect(0)");

                Console.WriteLine("Collection occured in 0th Generation:{0}", GC.CollectionCount(0));//1
                Console.WriteLine("Collection occured in 1th Generation:{0}", GC.CollectionCount(1));//0
                Console.WriteLine("Collection occured in 2th Generation:{0}", GC.CollectionCount(2));//0
                Console.WriteLine("myOb is in Generation : {0}", GC.GetGeneration(myOb));
                Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

                GC.Collect(1);//will call generation 1 with 0
                Console.WriteLine("\n After GC.Collect(1)");

                Console.WriteLine("Collection occured in 0th Generation:{0}", GC.CollectionCount(0));//2
                Console.WriteLine("Collection occured in 1th Generation:{0}", GC.CollectionCount(1));//1
                Console.WriteLine("Collection occured in 2th Generation:{0}", GC.CollectionCount(2));//0   
                Console.WriteLine("myOb is in Generation : {0}", GC.GetGeneration(myOb));
                Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

                GC.Collect(2);//will call generation 2 with 1 and 0
                Console.WriteLine("\n After GC.Collect(2)");

                Console.WriteLine("Collection occured in 0th Generation:{0}", GC.CollectionCount(0));//3
                Console.WriteLine("Collection occured in 1th Generation:{0}", GC.CollectionCount(1));//2
                Console.WriteLine("Collection occured in 2th Generation:{0}", GC.CollectionCount(2));//1 
                Console.WriteLine("myOb is in Generation : {0}", GC.GetGeneration(myOb));
                Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.ReadKey();
        }
    }
}


