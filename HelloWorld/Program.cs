using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld;

namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var builder = new StringBuilder("Hello world");
			builder
				.Append('-', 10)
				.AppendLine()
				.Append("Header")
				.AppendLine()
				.Append('-', 10)
				.Replace('-', '+')
				.Remove(0, 10)
				.Insert(0, new string('-', 10));

			Console.WriteLine(builder);

			Console.WriteLine("First Char: " + builder[0]);


		}

	

	}
}
