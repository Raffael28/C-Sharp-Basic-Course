
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
				case Seasons.Summer:
					Console.WriteLine("We've got a promotion");
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
