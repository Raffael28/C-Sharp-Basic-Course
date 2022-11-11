
using System;
using System.Runtime.InteropServices;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1;
			int number2;
			try
			{
				Console.WriteLine("Please, enter the width of the image:");

				number1 = (Convert.ToInt32(Console.ReadLine()));

				Console.WriteLine("Please, the height of the image:");

				number2 = (Convert.ToInt32(Console.ReadLine()));
				if (number1 > number2)
				{
					Console.WriteLine("The image is a landscape");
				}
				else if (number1 == number2)
				{
					Console.WriteLine("The image is a square");
				}
				else
				{
					Console.WriteLine("The image is a portrait");

				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You need to insert a valid number!");
				
			}

			

		}

		
	}
}
