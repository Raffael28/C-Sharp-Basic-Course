
using System;
using System.Net;
using System.Runtime.InteropServices;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			int speedLimit;
			int carSpeed;
			try
			{
				Console.WriteLine("Please, enter the speed limit (km/h):");

				speedLimit = (Convert.ToInt32(Console.ReadLine()));

				Console.WriteLine("Please, the car speed (km/h):");

				carSpeed = (Convert.ToInt32(Console.ReadLine()));
				var demeritPoints = (carSpeed - speedLimit) / 5;
				if (speedLimit >= carSpeed)
				{
					Console.WriteLine("OK");
				}
				else if (carSpeed > speedLimit && demeritPoints<=12)
				{
					Console.WriteLine($"The car speed is above the limit, you take {demeritPoints} demerit points");
				}
				else
				{
					Console.WriteLine("License Suspended");

				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You need to insert a valid number!");
				
			}

			

		}

		
	}
}
