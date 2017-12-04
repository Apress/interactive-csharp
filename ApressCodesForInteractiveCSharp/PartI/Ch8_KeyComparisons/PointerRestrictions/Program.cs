using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerRestrictions
{
    class A
    {
    }
    class Program
    {
        static unsafe void Main(string[] args)
        {
            A obA = new A();
            //int* b, c;//ok
            //int *b,*c;//error

            //Error:Cannot take the address of, get the size of, or declare a pointer to a managed type ('A')
            //A* obB = obA;

            /*Later we’ll learn about garbage collections which basically operates on references. 
             * The garbage collector can collect the object references during the cleanup process 
             * even if some pointer points to that. This is why , A pointer cannot point to a reference
             * ( or any structure which contains a reference)*/
            //int* p;
            //p = obA;//error

        }
}
}
