using System;

//To examine the outputs -Uncomment each of the region blocks and then test
namespace QuizOnStructures
{
    //#region Quiz1
    //struct MyStructure1
    //{
    //}
    //struct MyStructure2 : MyStructure1//error
    //{
    //}
    //#endregion
    //#region Quiz2
    //class A
    //{
    //}
    //struct MyStructure2 : A//error
    //{
    //}
    //#endregion
    //#region Quiz3And4
    //struct MyStructure
    //{
    //    int i = 25;//error
    //    MyStructure() { }//error
    //}
    //#endregion
    #region Quiz5and6
    //struct MyStructure
    //{
    //    //protected int i;//error
    //    int i;//ok
    //}
    #endregion
    //#region Quiz5
    //struct MyStructure3
    //{
    //    private int myInt;
    //    public int MyInt
    //    {
    //        get
    //        {
    //            return myInt;
    //        }
    //        set
    //        {
    //            myInt = value;
    //        }
    //    }
    //}
    //#endregion
    #region Quizes-finishing parts
    //struct OuterStruct
    //{
    //    public void Show()
    //    {
    //        Console.WriteLine("OuterStruct.Show()");
    //    }
    //    internal struct InnerStruct
    //    {
    //        public void Show()
    //        {
    //            Console.WriteLine("InnerStruct.Show()");
    //        }
    //    }

    struct OuterStruct
    {
        public void show()
        {
            Console.WriteLine("I am in OuterStruct");
        }
        internal struct InnerStruct
        //protected struct InnerStruct//error
        {
            public void show()
            {
                Console.WriteLine("I am in InnerStruct");
            }
        }

    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Quiz on structs***");
            OuterStruct.InnerStruct obS = new OuterStruct.InnerStruct();
            //InnerStruct obS = new InnerStruct();//error
            // obS.Show();
            Console.ReadKey();
        }
    }
}





