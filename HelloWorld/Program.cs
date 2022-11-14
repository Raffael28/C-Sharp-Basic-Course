


using System;
using System.Collections.Generic;
using HelloWorld;

namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var sentence =
				"This is going to be a really really really really really really really really really really long text";
			var summary = StringUtility.SummerizeText(sentence, 25);
			Console.WriteLine(summary);

		}

	

	}
}
