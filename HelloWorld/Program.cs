
using System;
using HelloWorld.Math;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var rafael = new Person();
		
			rafael.firstName = "Rafael";
			rafael.lastName = "Oliveira";
			rafael.Introduce();
			Calculator calculator = new Calculator();
			var result = calculator.Add(1, 2);
			Console.WriteLine(result);

		}
	}
}
