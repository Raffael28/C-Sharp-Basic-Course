using System;
using System.IO;


namespace CSharpFundamentals
{
	class Program
	{
		static void Main()
		{
			var path = @"c:\somefile.jpg";

			File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
			File.Delete(path);
			if (File.Exists(path))
			{
				//	
			}

			var fileInfo = new FileInfo(path);
			fileInfo.CopyTo("...");
			fileInfo.Delete();
			if (fileInfo.Exists)
			{
				//
			}
		}

	

	}
}
