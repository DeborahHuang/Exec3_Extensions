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
			bool result =number.IsOdd();
			Console.WriteLine(result);

			number = 6;
			result = number.IsEven();
			Console.WriteLine(result);
		}
		
	}

	public static class IntExtensions
	{
		public static bool IsOdd(this int source)
		{
			if (source % 2 != 0)
				return true;
			else return false;
		}

		public static bool IsEven(this int source)
		{
			if (source % 2 == 0)
				return true;
			else return false;
		}

	}
}
