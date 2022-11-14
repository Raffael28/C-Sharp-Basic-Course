
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = "0";
			var sum = 0;

			while (n != "ok")
			{
				Console.WriteLine("Enter a number to sum, or ok to exit: ");
				n = Console.ReadLine();
				if (n == "ok")
				{
					break;
				}
				sum += Convert.ToInt32(n);
			}

			Console.WriteLine($"The sum of the numbers are {sum}");
		}

		
	}
}
