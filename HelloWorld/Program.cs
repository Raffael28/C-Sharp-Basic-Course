
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
				Console.WriteLine("Please, enter a number 1:");

				number1 = (Convert.ToInt32(Console.ReadLine()));
				Console.WriteLine("Please, enter a number 2:");

				number2 = (Convert.ToInt32(Console.ReadLine()));
				if (number1 > number2)
				{
					Console.WriteLine($"{number1} is bigger than {number2}");
				}
				else if (number1 == number2)
				{
					Console.WriteLine($"{number1} is equal {number2}");
				}
				else
				{
					Console.WriteLine($"{number2} is bigger than {number1}");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You need to insert a valid number!");
				
			}

			

		}

		
	}
}
