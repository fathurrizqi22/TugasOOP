using System;
namespace TugasOOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Taxi taxi = new Taxi();
			
			taxi.DriverName = "Rizqi";
			taxi.OnDuty = true;
			taxi.NumPassenger = 10;
			
			taxi.TaxiInfo();
			taxi.PickUpPassenger();
			taxi.DropOfPassenger();
			
			Console.ReadKey();
		}
	}
}