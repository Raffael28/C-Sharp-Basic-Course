


using System;

namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var fullName = "Rafael Oliveira ";
			Console.WriteLine($"Trim: {fullName.Trim()}");
			Console.WriteLine($"ToUpper: {fullName.ToUpper()}");

			var index = fullName.IndexOf(" ");
			var firstName = fullName.Substring(0, index);
			var lastName = fullName.Substring(index + 1);
			Console.WriteLine($"firstName: {firstName}");
			Console.WriteLine($"lastName: {lastName}");

			var names = fullName.Split(' ');
			Console.WriteLine($"firstName: {names[0]}");
			Console.WriteLine($"lastName: {names[1]}");

			Console.WriteLine(fullName.Replace("Oliveira", "Rodrigues"));

			if (String.IsNullOrWhiteSpace(" "))
				Console.WriteLine("Invalid");

			var str = "25";
			var age = Convert.ToByte(str);
			Console.WriteLine(age);

			float price = 19.95f;
			Console.WriteLine(price.ToString("C0"));


		}


	}
}
