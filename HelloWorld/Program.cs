
using System;
using System.Runtime.InteropServices;


namespace CSharpFundamentals
{

	class Program
	{
		static void Main(string[] args)
		{
			int hour = 18;
			if (hour > 0 && hour < 12)
			{

				Console.WriteLine("It's Morning.");
			}
			else if (hour >= 12 && hour < 18)
				Console.WriteLine("It's afternoon.");
			else
				Console.WriteLine("It's evening.");

		}

		
	}
}
