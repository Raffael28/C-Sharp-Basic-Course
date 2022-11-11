
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			
			while (true)
			{
				Console.WriteLine("Write your name:");
				var name = Console.ReadLine();
				if (!String.IsNullOrWhiteSpace(name))
				{
					Console.WriteLine("@Echo:"+ name);
					break;
				}
				continue;
			}
			

		}

		
	}
}
