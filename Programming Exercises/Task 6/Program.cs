using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number: ");
			string num1 = Console.ReadLine();
			Console.WriteLine("Enter another number: ");
			string num2 = Console.ReadLine();
			Console.WriteLine("num1: " + num1);
			Console.WriteLine("num2: " + num2);
			string num1Swap = num2;
			string num2Swap = num1;
			Console.WriteLine("Numbers Swapped:\nnum1: " + num1Swap);
			Console.WriteLine("num2: " + num2Swap);
			Console.ReadLine();
		}
	}
}
