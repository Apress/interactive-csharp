using System;
namespace BaseRefToChildObjectEx1
{
    class Vehicle
    {
        public void ShowMe()
        {
            Console.WriteLine("Inside Vehicle.ShowMe");
        }
    }
    class Bus : Vehicle
    {
        public void ShowMe()
        {
            Console.WriteLine("Inside Bus.ShowMe");
        }
        public void BusSpecificMethod()
        {
            Console.WriteLine("Inside Bus.ShowMe");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Base Class reference to Child Class Object Demo***\n\n");
            Vehicle obVehicle = new Bus();
            obVehicle.ShowMe();//Inside Vehicle.ShowMe
            // obVehicle.BusSpecificMethod();//Error
            ((Bus)obVehicle).BusSpecificMethod();//ok
            //Bus obBus = new Vehicle();//Error
            //Bus obBus = (Bus)new Vehicle();//Error
            Console.ReadKey();
        }
    }
}

