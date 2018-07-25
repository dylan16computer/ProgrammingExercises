using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your final course mark (%): ");
			int finalMark = Convert.ToInt32(Console.ReadLine());
			if (finalMark >= 50)
			{
				Console.WriteLine("Congratulations, you passed!");
			}
			else
			{
				Console.WriteLine("Sorry, you failed.");
			}
			Console.ReadLine();
		}
	}
}
