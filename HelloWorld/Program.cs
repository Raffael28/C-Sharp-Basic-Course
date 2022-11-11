
using System;
using System.Runtime.InteropServices;


namespace CSharpFundamentals
{
	public enum ShippingMethod
	{
		RegularAirMail=1,
		RegisteredAirMail=2,
		Express=3
	}
	class Program
	{
		static void Main(string[] args)
		{
			var method = ShippingMethod.Express;
			Console.WriteLine(method);
			Console.WriteLine((int)method);
			Console.WriteLine(method.ToString());
			var newMethod = 3;
			Console.WriteLine((ShippingMethod)newMethod);

			var methodName = "RegularAirMail";
			var shippingMethod=(ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
			Console.WriteLine(shippingMethod);



		}
	}
}
