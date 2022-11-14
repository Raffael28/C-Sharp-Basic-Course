
using System;
using System.Collections.Generic;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var names = new List<string>();
			var name = "insert";
			while (name != "")
			{
				Console.WriteLine("Enter the friend name:");
				name = Console.ReadLine();
				if (name!="")
					names.Add(name);
			}
			if (names.Count==1)
				Console.WriteLine($"{names[0]} liked your post.");
			else if(names.Count==2) 
				Console.WriteLine($"{names[0]} and {names[1]} liked your post.");
			else if (names.Count>2) 
				Console.WriteLine($"{names[0]}, {names[1]} and {names.Count-2} more people liked your post.");
		}


	}
}
