using System;

namespace CovarianceWithDelegatesEx1
{    
    class Vehicle
    {
        public Vehicle ShowVehicle()
        {
            Vehicle myVehicle = new Vehicle();
            Console.WriteLine(" A Vehicle created");
            return myVehicle;
        }
    }
    class Bus:Vehicle
    {
        public Bus ShowBus()
        {
            Bus myBus = new Bus();
            Console.WriteLine(" A Bus created");
            return myBus;
        }
    }
    
    class Program
    {
        public delegate Vehicle ShowVehicleTypeDelegate();
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();//ok
            Bus bus1 = new Bus();//ok
            //Vehicle vehicle2 = new Bus();//ok
            //Bus bus2 = new Vehicle();//Error
            //#region Covariance in arrays
            //Console.WriteLine("***Covariance in arrays(C#1.0 onwards)***");
            ////ok, but not type safe
            //object[] myObjArray = new string[5];
            ////myObjArray[0] = 10;//runtime error
            //#endregion
            Console.WriteLine("***Covariance in delegates(C# 2.0 onwards)***");
            ShowVehicleTypeDelegate del1 = vehicle1.ShowVehicle;
            del1();
            //Note that it is expecting a Vehicle(i.e. a basetype) but received a Bus(subtype)
            //Still this is allowed through Covariance
            ShowVehicleTypeDelegate del2 = bus1.ShowBus;
            del2();            
            Console.ReadKey();
        }
    }
}
