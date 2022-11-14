
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new [] { 1, 8, 7, 22, 32, 9 };

			//Length
			Console.WriteLine($"length: {numbers.Length}");

			//IndexOf()
			Console.WriteLine($"Index of 9: {Array.IndexOf(numbers, 22)}");

			//Clear()
			Array.Clear(numbers, 0,3);
			Console.WriteLine("Effect of Clear()");
			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}

			//Copy()

			var newNumbers = new int[4];
			Array.Copy(numbers, newNumbers, 4);
			Console.WriteLine("Effect of Copy()");
			foreach (var number in newNumbers)
			{
				Console.WriteLine(number);
			}

			//Sort()
			Array.Sort(numbers);
			Console.WriteLine("Effect of Sort()");

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}

			//Reverse()

			Array.Reverse(numbers);
			Console.WriteLine("Effect of Reverse()");

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
		}


	}
}
