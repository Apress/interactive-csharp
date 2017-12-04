using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Experiment with casting***\n");
            //int a = 120;
            ////Implicit casting
            //double b = a;
            ////Explicit casting
            ////int c = b;//Error
            //int c = (int)b;//Ok
            ////int d = ( int)"hello";//error

            //#region Boxing and Unboxing
            //int i = 10;
            //object o = i;//Boxing
            ////int j = o;//error
            //int j = (int)o;//Unboxing
            //#endregion

            #region invalid casting
            long myLong = 4000000000;
            int myInt = int.MaxValue;
            Console.WriteLine(" Maximum value of int is {0}", myInt);
            //Invalid cast:Greater than maximum value of an integer
            myInt = (int) myLong;
            Console.WriteLine(" Myint now={0}", myInt);
            
            #endregion

            Console.ReadKey();
        }
    }
}
