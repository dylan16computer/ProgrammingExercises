﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter 3 numbers: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			int num2 = Convert.ToInt32(Console.ReadLine());
			int num3 = Convert.ToInt32(Console.ReadLine());
			if (num1 > num2 && num1 > num3)
			{
				Console.WriteLine("Largest number is " + num1);
			}
			else if (num2 > num1 && num2 > num3)
			{
				Console.WriteLine("Largest number is " + num2);
			}
			else
			{
				Console.WriteLine("Largest number is " + num3);
			}
			Console.ReadLine();
		}
	}
}
