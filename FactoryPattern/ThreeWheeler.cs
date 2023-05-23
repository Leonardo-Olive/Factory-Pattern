using System;
namespace FactoryPattern
{
	public class ThreeWheeler: IVehicle
	{
		public ThreeWheeler()
		{
		}
		public void Drive()
		{
			Console.WriteLine("You got your Three-Wheeler");
		}
	}
}

