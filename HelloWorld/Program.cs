﻿
using System;

	
namespace CSharpFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			for (var i = 0; i <= 10; i++)
			{
				if (i % 2 == 0)
					Console.WriteLine(i);
			}

			for (var i = 10; i > 1; i--)
			{
				if(i%2==0) 
					Console.WriteLine(i);
			}
			

		}

		
	}
}
