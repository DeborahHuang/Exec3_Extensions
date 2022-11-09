using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 5;
			bool result = IsOdd(number);
			Console.WriteLine(result);

			number = 6;
			result = IsEven(number);
			Console.WriteLine(result);
		}
		static bool IsOdd(int source)
		{
			if (source % 2 != 0)
				return true;
			else return false;
		}

		static bool IsEven(int source)
		{
			if (source % 2 == 0)
				return true;
			else return false;
		}
	}
}
