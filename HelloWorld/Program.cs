
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{

		
				Console.WriteLine("Enter a series of numbers separated by a comma:");
				var n = Console.ReadLine();
				var numberArray = n.Split(',');
				var max = 0;
				for (int i = 0; i < numberArray.Length; i++)
				{
					if (Convert.ToInt32(numberArray[i]) > max)
					{
						max = Convert.ToInt32(numberArray[i]);
					}
				}

				Console.WriteLine($"The biggest number is {max}");

		}

		
	}
}
