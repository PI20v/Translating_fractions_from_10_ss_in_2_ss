using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTranslate
{
	/// <summary>
	/// This class demonstrates how to work with the API of a fractional number translator from decimal to binary.
	/// </summary>
	class DemoApi
	{
		static void Main(string[] args)
		{
			Console.WriteLine(new Translate("10.64").CovertToBinary());
		}
	}
}
