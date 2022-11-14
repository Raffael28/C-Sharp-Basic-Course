
using System;
using System.Collections.Generic;
using System.Xml.Schema;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Enter your name:");
			var name = Console.ReadLine();
			var nameArray = new char[name.Length];
			for (var i =0; i<name.Length; i++)
			{
				nameArray[i] = name[i];
			}
			Array.Reverse(nameArray);
			foreach (var letter in nameArray)
			{
				Console.WriteLine(letter);
			}
		}


	}
}
