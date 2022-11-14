
using System;
using System.Collections.Generic;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var numbers = new List<int>();
			var newNumber = "0";
			while (newNumber != "Quit")
			{
				Console.WriteLine("Enter a number, or type Quit to exit:");
				newNumber = Console.ReadLine();
				if (newNumber == "Quit")
					break;
				numbers.Add(Convert.ToInt32(newNumber));
			}

			if (numbers.Count == 1)
			{
				Console.WriteLine(numbers[0]);
			}
			else if(numbers.Count!= 0)
			{
				var prevNumbers = new List<int>();
				var isDuplicated = false;
				foreach (var number in numbers)
				{
					foreach (var prevNumber in prevNumbers)
					{
						if (number == prevNumber)
							isDuplicated = true;
					}
					if (!isDuplicated)
					{
						Console.WriteLine(number);
					}
					prevNumbers.Add(number);
					isDuplicated = false;
				}
			}
		}


	}
}
