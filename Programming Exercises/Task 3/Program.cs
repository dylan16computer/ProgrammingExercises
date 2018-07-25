using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number: ");
			string num1 = Console.ReadLine();
			int number1 = Convert.ToInt32(num1);
			Console.WriteLine("Please enter another number: ");
			string num2 = Console.ReadLine();
			int number2 = Convert.ToInt32(num2);
			Console.WriteLine(num1 + " * " + num2 + " = " + number1 * number2);
			Console.ReadLine();
		}
	}
}
