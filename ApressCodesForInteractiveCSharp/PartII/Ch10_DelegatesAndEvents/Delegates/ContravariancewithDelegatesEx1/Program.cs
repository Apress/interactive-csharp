using System;

namespace ContravariancewithDelegatesEx1
{
    class Vehicle
    {
        public void ShowVehicle(Vehicle myV)
        {
            //Vehicle myVehicle = new Vehicle();
            Console.WriteLine("Vehicle.ShowVehicle");
            //return myVehicle;
        }
    }
    class Bus : Vehicle
    {
        public void ShowBus(Bus myB)
        {
            //Bus myBus = new Bus();
            Console.WriteLine("Bus.ShowBus");
            //return myBus;
        }
    }

    class Program
    {
        public delegate void TakingDerivedTypeParameterDelegate(Bus v);
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();//ok
            Bus bus1 = new Bus();//ok
            Console.WriteLine("***Exploring Contravariance with C# delegates***");
            //General case
            TakingDerivedTypeParameterDelegate del1 = bus1.ShowBus;
            del1(bus1);
            //Special case:
            //Contravariance:
            //Note that the delegate expected a method that accepts a bus(derived) object parameter
            //but still it can point to the method that accepts vehicle(base) object parameter
            TakingDerivedTypeParameterDelegate del2 = vehicle1.ShowVehicle;
            del2(bus1);
            //Additional note:you cannot pass vehicle object here
            //del2(vehicle1);//error
            Console.ReadKey();
        }
    }
}
