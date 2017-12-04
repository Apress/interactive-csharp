using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerQuiz2
{
    interface IMyInterface
        {
            int this[int index] { get; set; }
        }
    class MyClass : IMyInterface
    {
        private int[] myIntegerArray = new int[4];
        //public int this[int index]
        //{
        //    get
        //    {
        //        return myIntegerArray[index];
        //    }
        //    set
        //    {
        //        myIntegerArray[index] = value;
        //    }
        //}
        //Explicit interface implementation
        int IMyInterface.this[int index]
        {
            get => myIntegerArray[index];
            set => myIntegerArray[index] = value;
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("***Quiz on Indexers with explicit interface technique***\n");
            MyClass obMyClass = new MyClass(); 
            IMyInterface interOb = (IMyInterface)obMyClass;
            //Initializing 0th, 1st and 3rd element using indexers
            interOb[0] = 20;
            interOb[1] = 21;
            interOb[3] = 23;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t obMyClass[{0}]={1}", i,interOb[i]);                
            }
            Console.ReadKey();
            }
        }
    }
