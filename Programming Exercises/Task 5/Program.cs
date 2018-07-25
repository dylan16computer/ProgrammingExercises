using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
	public class ProgramQ5
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number between 1 and 12: ");
			int number = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i <= 11; i++)
			{
				Console.WriteLine(number + " * " + (i + 1) + " = " + (number * (i + 1)));
			}
		}
	}
}
