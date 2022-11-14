
using System;
using System.Collections.Generic;
using System.Xml.Schema;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var numbers = new List<int>();
			int prevNumber = 0;
			int newNumber = 0;

			for (int i = 0; i < 5; i++)
			{
				prevNumber = newNumber;
				while (newNumber == prevNumber)
				{
					Console.WriteLine("Enter a number:");
					newNumber = Convert.ToInt32(Console.ReadLine());
					if (newNumber == prevNumber)
					{
						Console.WriteLine("You need to enter a different number.");
					}
				}
				
				numbers.Add(newNumber);
			}
			numbers.Sort();
			foreach (var n in numbers)
			{
				Console.WriteLine(n);
			}
		}


	}
}
