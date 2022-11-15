using System;
using System.IO;
using System.Xml;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			Directory.CreateDirectory(@"C:\Windows\Temp\NewFolder" );
			var files =Directory.GetFiles(@"C:\Windows\Temp");
			foreach (var file in files)
			{
				Console.WriteLine(file);
			}

			Console.WriteLine();
			var directories = Directory.GetDirectories(@"C:\Windows\Temp");
			foreach (var directory in directories)
			{
				Console.WriteLine(directory);
			}

			Directory.Exists("...");

			var directoryInfo = new DirectoryInfo(@"C:\Windows\Temp");
			directoryInfo.GetFiles();
			directoryInfo.GetDirectories();

		}



	}
}
