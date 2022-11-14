
using System;
using System.Collections.Generic;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new List<int>(){1,2,3,4};
			numbers.Add(1);
			numbers.AddRange(new int[3] {3,1,7});
			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
			Console.WriteLine();
			Console.WriteLine($"Index of first 1: {numbers.IndexOf(1)}");
			Console.WriteLine($"Index of last 1: {numbers.LastIndexOf(1)}");

			Console.WriteLine($"Count {numbers.Count}");

			for (var i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == 1)
				{
					numbers.Remove(numbers[i]);
				}
			}

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}


		}


	}
}
