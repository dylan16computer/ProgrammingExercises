using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
	public class ProgramQ6
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number: ");
			string num1 = Console.ReadLine();
			Console.WriteLine("Enter another number: ");
			string num2 = Console.ReadLine();
			Console.WriteLine("num1: " + num1);
			Console.WriteLine("num2: " + num2);
            string tempVar = num1;
            num1 = num2;
            num2 = tempVar;
			Console.WriteLine("Numbers Swapped:\nnum1: " + num1);
			Console.WriteLine("num2: " + num2);
		}
	}
}
