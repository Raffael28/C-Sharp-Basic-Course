
using System;
using System.Runtime.InteropServices;


namespace CSharpFundamentals
{
	public class Person
	{
		public int Age;
	}
	class Program
	{
		static void Main(string[] args)
		{
			var number = 1;
			Increment(number);
			Console.WriteLine(number);
			var person1 = new Person();
			person1.Age = 20;
			MadeOlder(person1);
			Console.WriteLine(person1.Age);

		}

		public static void Increment(int number)
		{
			number += 10;
		}

		public static void MadeOlder(Person person)
		{
			person.Age += 10;
		}
	}
}
