﻿


using System;

namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
		// Creating
		var timeSpan = new TimeSpan(1, 2, 3);

		var timeSpan2 = new TimeSpan(1, 0, 0);
		var timeSpan3 = TimeSpan.FromHours(1);

		var start = DateTime.Now;
		var end = DateTime.Now.AddMinutes(2);
		var duration = end - start;
		Console.WriteLine("Duration: "+duration);

		//Properties
		Console.WriteLine("Minutes: " + timeSpan.Minutes);
		Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

		//Add
		Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); 
		Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

		//ToString
		Console.WriteLine("ToString: " + timeSpan.ToString());

		//Parse
		Console.WriteLine("Parse: " +TimeSpan.Parse("01:02:20"));

		}


	}
}
