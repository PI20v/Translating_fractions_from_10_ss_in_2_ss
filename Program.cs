using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BinaryTranslate
{
	/// <summary>
	/// This class demonstrates how to work with the API of a fractional number translator from decimal to binary.
	/// </summary>
	class DemoApi
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine(new Translate("10.6735.33765.376").CovertToBinary());
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			Console.ReadLine();
		}
	}
}
