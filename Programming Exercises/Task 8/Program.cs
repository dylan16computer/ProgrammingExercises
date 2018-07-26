using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
	public class ProgramQ8
	{
		public static void Main()
		{
			Console.WriteLine("Enter your final course mark (%): ");
			decimal finalMark = Convert.ToDecimal(Console.ReadLine());
			if (finalMark >= 50)
			{
				Console.WriteLine("Congratulations, you passed!");
			}
			else
			{
				Console.WriteLine("Sorry, you failed.");
			}
		}
	}
}
