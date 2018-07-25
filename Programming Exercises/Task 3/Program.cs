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
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter another number: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
			Console.ReadLine();
		}
	}
}
