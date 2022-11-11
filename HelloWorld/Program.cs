
using System;
using System.Runtime.InteropServices;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var season = Seasons.Autumn;

			switch (season)
			{
				case Seasons.Autumn:
					Console.WriteLine("It's antumn and a beautiful season.");
					break;
				case Seasons.Summer:
					Console.WriteLine("It's perfect to go to the beach.");
					break;
				case Seasons.Spring:
					Console.WriteLine("It's spring.");
					break;
				default:
					Console.WriteLine("It's time to make a hot chocolate");
					break;
			}

		}

		
	}
}
