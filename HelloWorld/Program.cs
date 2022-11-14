
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = 0;
			for (var i = 1; i <= 100; i++)
			{
				if (i%3 == 0) n++;

			}

			Console.WriteLine($"There are {n} numbers divisible by 3 between 1 and 100.");
		}

		
	}
}
