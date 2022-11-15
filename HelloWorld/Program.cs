using System;
using System.IO;
using System.Xml;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var path = @"C:\Users\rafae\source\repos\HelloWorld\HelloWorld\bin\Debug\HelloWorld.exe";

			Console.WriteLine($"Extension: {Path.GetExtension(path)}");
			Console.WriteLine($"File Name: {Path.GetFileName(path)}");
			Console.WriteLine($"File Name without Extension: {Path.GetFileNameWithoutExtension(path)}");
			Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path)}");


		}



	}
}
