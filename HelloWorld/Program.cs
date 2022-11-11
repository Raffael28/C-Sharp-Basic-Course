
using System;
using System.Runtime.InteropServices;


namespace CSharpFundamentals
{

	class Program
	{
		static void Main(string[] args)
		{
			bool isGoldCustomer = true;

			float price = isGoldCustomer ? 19.95f : 29.95f;

			Console.WriteLine(price);

		}

		
	}
}
