
using System;
using System.Runtime.InteropServices;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please, enter a number between 1 to 10:");
			var number = 0;
			try
			{
				 number = (Convert.ToInt32(Console.ReadLine()));
				 if (number > 1 && number < 10)
					 Console.WriteLine("Valid");
				 else
				 {
					 Console.WriteLine("Invalid");
				 }
			}
			catch (Exception e)
			{
				Console.WriteLine("Invalid");
				
			}

			

		}

		
	}
}
