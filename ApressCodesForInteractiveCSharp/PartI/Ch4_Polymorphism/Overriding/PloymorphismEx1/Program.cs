using System;

namespace PloymorphismEx1
{
    class Vehicle
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("Inside Vehicle.ShowMe");
        }
    }
    class Bus : Vehicle
    {
        //int aVar = 25;
        public override void ShowMe()
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
            Console.WriteLine("***Polymorphism Example-1 ***\n\n");
            Vehicle obVehicle = new Bus();
            obVehicle.ShowMe();//Inside Bus.ShowMe            
            // obVehicle.BusSpecificMethod();//Error
            //Bus obBus = new Vehicle();//error
            //Console.WriteLine(obVehicle.aVar);//Error
            Console.ReadKey();
        }
    }
}
