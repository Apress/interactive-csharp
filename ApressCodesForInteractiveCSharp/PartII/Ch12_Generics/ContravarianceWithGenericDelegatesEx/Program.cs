using System;

namespace ContravarianceWithGenericDelegatesEx
{
    //A generic delegate
    delegate void aDelegateMethod<in T>(T t);
    class Vehicle
    {
        public virtual void ShowMe()
        {
            Console.WriteLine(" Vehicle.ShowMe()");
        }
    }
    class Bus: Vehicle
    {
        public override void ShowMe()
        {
            Console.WriteLine(" Bus.ShowMe()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Contra-variance with Generic Delegates example ***");
            Vehicle obVehicle = new Vehicle();
            Bus obBus = new Bus();
            aDelegateMethod<Vehicle> delVehicle = ShowVehicleType;
            delVehicle(obVehicle); // I am from Parent
                                 //Contravariance with Delegate
                                 //Using less derived type to more derived type
            aDelegateMethod<Bus> delChild = ShowVehicleType;
            delChild(obBus);// I am from Child            
            Console.ReadKey();
        }

        private static void ShowVehicleType(Vehicle p)
        {
            p.ShowMe();
        }
    }

}
