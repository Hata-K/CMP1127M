using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08t2
{
	class Calculator
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("Enter two integers to add...");
			int number1 = Convert.ToInt32(Console.ReadLine());
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Answer: {0} \n", Calculator.add(number1, number2));
			
			Console.WriteLine("Enter two doubles to add...");
			double number3 = Convert.ToDouble(Console.ReadLine());
			double number4 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Answer: {0}", Calculator.add(number3, number4));
			Console.ReadLine();

		}

		private static int add(int a, int b)
		{
			return (a + b);
		}
		private static double add(double a, double b)
		{
			return (a + b);
		}
	}
}
