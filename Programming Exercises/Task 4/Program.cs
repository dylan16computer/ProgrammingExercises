﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
	public class ProgramQ4
	{
		public static void Main()
		{
			Console.WriteLine("What is your first name?");
			string firstName = Console.ReadLine();
			Console.WriteLine("What is your last name?");
			string lastName = Console.ReadLine();
			Console.WriteLine("Hello, " + firstName + " " + lastName + ".");
			Console.ReadLine();
		}
	}
}
