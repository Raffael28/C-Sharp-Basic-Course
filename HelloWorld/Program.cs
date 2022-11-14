


using System;

namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var dateTime = new DateTime(2022, 11, 14);
			var now = DateTime.Now;
			var today = DateTime.Today;

			Console.WriteLine("Hour: "+ now.Hour);
			Console.WriteLine("Minute: "+ now.Minute);

			var tomorrow = today.AddDays(1);
			var yesterday = today.AddDays(-1);
			Console.WriteLine(now.ToLongTimeString());
			Console.WriteLine(now.ToShortTimeString());
			Console.WriteLine(now.ToLongDateString());
			Console.WriteLine(now.ToShortDateString());
			Console.WriteLine(now.ToString("dd/MM/yyyy"));

		}


	}
}
