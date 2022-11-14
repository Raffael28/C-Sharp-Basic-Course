
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a positive integer number:");
			var n = Console.ReadLine();
			var f = 1;
			for (var  i = Convert.ToInt32(n); i>0; i--)
			{
				f = f * i;
			}

			Console.WriteLine($"The factorial of the number is {f}");
		}

		
	}
}
