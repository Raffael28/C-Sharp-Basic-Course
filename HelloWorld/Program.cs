
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			var r = random.Next(1, 10);
			var n = "0";
			var i = 0;
			while (Convert.ToInt32(n) != r && i<4 )
			{
				Console.WriteLine("Guess the number between 1 and 10:");
				n = Console.ReadLine();
				i++;
			}

			if (Convert.ToInt32(n) != r)
			{
				Console.WriteLine("You Lost");
				Console.WriteLine(r);

			}
			else
			{
				Console.WriteLine("You Won!");
			}
		}

		
	}
}
