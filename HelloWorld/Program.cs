
using System;
using System.Collections.Generic;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			bool listIsInvalid = true;
			var numbers = "";
			while (listIsInvalid)
			{
				{
					Console.WriteLine("Enter a list of numbers separated by a comma with 5 numbers or more:");
				}
				numbers = Console.ReadLine();
				var numberArray = new string[numbers.Length];
				numberArray = numbers.Split(',');

				if (numberArray.Length < 5)
				{
					Console.WriteLine("Invalid List");
					continue;
				}
				listIsInvalid = false;
				var smallNumbers = new List<int>();
				foreach (var number in numberArray)
				{
					smallNumbers.Add(Convert.ToInt32(number));
				}
				smallNumbers.Sort();
				for (int i = 0; i < 3; i++)
				{
					Console.WriteLine(smallNumbers[i]);
					;
				}

			}


			


			
			
		}


	}
}
