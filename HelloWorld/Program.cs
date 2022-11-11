
using System;


namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var firstName = "Rafael";
			var lastName = "Oliveira";
			var fn = firstName +" "+ lastName;
			Console.WriteLine(fn);

			var fullName = string.Format("My name is {0} {1}", firstName, lastName);
			Console.WriteLine(fullName);

			var names = new string[3] { "Rafael", "Rander", "David" };
			var formattedNames = string.Join(",", names);
			Console.WriteLine(formattedNames);



		}
	}
}
