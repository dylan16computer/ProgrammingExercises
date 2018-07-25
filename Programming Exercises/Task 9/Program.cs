using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = { "Eli", "Joshua", "Johan", "Troy", "Campbell" };
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
			Console.ReadLine();
		}
	}
}
