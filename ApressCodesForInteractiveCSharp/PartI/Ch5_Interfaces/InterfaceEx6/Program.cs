using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx6
{
    interface Interface6
    {
        void ShowInterface6();
    }
    class MyClass6 : Interface6
    {
        void Interface6.ShowInterface6()
        {
            Console.WriteLine("ShowInterface6() is completed.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass6 myClassOb = new MyClass6();
            //myClassOb.ShowInterface6();//Error
            ((Interface6)myClassOb).ShowInterface6();//Ok

            /*You can see that we have implemented the interface explicitly.And as per the language specification, to access the 
             explicit interface member we need to use the interface type.So, to overcome the error, you can use following lines of codes*/
            Interface6 ob6 = myClassOb;
            ob6.ShowInterface6();
            Console.ReadKey();
        }
    }
}
