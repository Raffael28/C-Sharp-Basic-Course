
using System;
using System.Runtime.InteropServices;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 10;
			var b = a;
			b++;
			Console.WriteLine($"a: {a}, b: {b}");

			var array1 = new int[3] { 1, 2, 3 };
			var array2 = array1;
			array2[0] = 0;
			Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");


		}
	}
}
