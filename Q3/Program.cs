using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "123456";
			int result = value.ToInt(0);
			Console.WriteLine(result);

			value = "AAA";
			result = value.ToInt(0);
			Console.WriteLine(result);
		}
	}
	public static class Extensions
	{
		public static int ToInt(this string value,int defaultValue)
		{
			int result = 0;
			bool canConvert2Int = int.TryParse(value,out defaultValue);
			if (canConvert2Int==true) return result;
			else return defaultValue;
		}
	}
}
