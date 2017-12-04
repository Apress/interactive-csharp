using System;

namespace PolymorphismEx3
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
        public override void ShowMe()
        {
            Console.WriteLine("Inside Bus.ShowMe");
        }        
    }
    class Taxi : Vehicle
    {
        public override void ShowMe()
        {
            Console.WriteLine("Inside Taxi.ShowMe");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Polymorphism Example-3 ***\n");
            Vehicle obVehicle;
            int count = 0;
            Random r = new Random();
            while( count <5)
            {
                int tick = r.Next(0, 10);
                if(tick%2==0)
                {
                    obVehicle = new Bus();

                }
                else
                {
                    obVehicle = new Taxi();
                }
                obVehicle.ShowMe();//Output will be determined during runtime
                count++;
            }          
             
            Console.ReadKey();
        }
    }
}
