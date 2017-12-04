using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Demonstration13
{
    /* We can have either ChangeMe(out myVariable3) or
        ChangeMe(ref myVariable3) with ChangeMe( myVariable3).Both of them are not allowed together.*/
    class Program
    {
        static void ChangeMe(int x)
        {
            x = 5;
            Console.WriteLine("Inside Change() the value is {0}", x);
        }
        static void ChangeMe(out int x)
        {
            //out parameter must be assigned before it leaves the function
            x = 5;
            Console.WriteLine("Inside ChangeMe() the value is {0}", x);
        }
        //static void ChangeMe(ref int x)
        //{
        //    x = 5;
        //    Console.WriteLine("Inside ChangeMe() the value is {0}", x);
        //}
        static void Main(string[] args)
            {
                Console.WriteLine("***ref and out Comparison-Demo***");
                //for ref, the variable need to be initialized
                int myVariable3 = 25;
                Console.WriteLine("Inside Main(),before call, the value is {0}", myVariable3);
                ChangeMe(myVariable3);
                //ChangeMe(ref myVariable3);
                ChangeMe(out myVariable3);
                Console.WriteLine("Inside Main(),after call, the value is {0}", myVariable3);
            }
        }
    }

