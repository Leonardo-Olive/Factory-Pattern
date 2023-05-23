using System;
namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)

        {
            int wheelcount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");

                input = int.TryParse(Console.ReadLine(), out wheelcount);
            } while (!input);
            var vehicle = VehicleFactory.GetVehicle(wheelcount);
            vehicle.Drive();
        }
    }
}
