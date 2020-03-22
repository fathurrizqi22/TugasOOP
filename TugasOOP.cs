using System;
namespace TugasOOP
{
	 public class Taxi
	 {
		public string DriverName {get; set;}
		public bool OnDuty {get; set;}
		public float NumPassenger {get; set;}
		
		public void TaxiInfo()
		{
			Console.WriteLine("Nama: {0}", DriverName);
			if(OnDuty == true)
			{
				Console.WriteLine("OnDuty : Yes:");
			}
			else
			{
				Console.WriteLine("OnDuty : No");
			}
			Console.WriteLine("Jumlah Penumpang: {0}\n", NumPassenger);
		}
		
		public void PickUpPassenger()
		{
			Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
		}
		
		public void DropOfPassenger()
		{
			Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
		}
	 }
	
}

















