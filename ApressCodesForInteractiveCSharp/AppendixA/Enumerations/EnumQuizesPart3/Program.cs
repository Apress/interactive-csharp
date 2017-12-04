using System;
//To examine the outputs -Uncomment each of the region blocks and then test
namespace EnumQuizesPart3
{
    #region  Quiz on Enum-1
    //Quiz on Enum
    //class Program
    //{
    //    enum Values { val1, val2 = 100, val3 = 50, val4, val5 };
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("** Quiz on enum ***");
    //        foreach (Values v in Enum.GetValues(typeof(Values)))
    //        {
    //            Console.WriteLine("{0} is storing {1} ", v, (int)v);
    //        }
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region  Quiz on Enum-2
    //class Program
    //{
    //    enum TrafficLight : byte
    //    {
    //        red, green, yellow
    //    };
    //    enum Values { val1 = 12, val2 = (int)TrafficLight.green, val3, val4 = 200 };
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("** A simple use of enum ***");
    //        foreach (Values v in Enum.GetValues(typeof(Values)))
    //        {
    //            Console.WriteLine("{0} is storing {1} ", v, (int)v);
    //        }
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    //Quiz on Enum 
    #region  Quiz on Enum-3 (Compilation Error)
    //class Program
    //{
    //    enum TrafficLight : byte
    //    {
    //        red, green = (int)Values.val3, yellow
    //    };
    //    enum Values { val1 = 12, val2 = (int)TrafficLight.green, val3, val4 = 200 };
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("** A simple use of enum ***");
    //        foreach (Values v in Enum.GetValues(typeof(Values)))
    //        {
    //            Console.WriteLine("{0} is storing {1} ", v, (int)v);
    //        }
    //    }
    //}
    #endregion
    #region  Quiz on Enum-4 (Compilation Error)
    class Program
    {
        enum TrafficLight : byte
        {
            red, green = (int)Values.val3, yellow
        };
        enum Values { val1 = 12, val2 = (int)TrafficLight.red, val3, val4 = 200 };
        static void Main(string[] args)
        {
            Console.WriteLine("** A simple use of enum ***");
            foreach (Values v in Enum.GetValues(typeof(Values)))
            {
                Console.WriteLine("{0} is storing {1} ", v, (int)v);
            }
        }
    }
    #endregion



}
