using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;
using Task_2;
using Task_3;
using Task_4;
using Task_5;
using Task_6;
using Task_7;
using Task_8;
using Task_9;

namespace Main_Menu
{
    public class Program
    {
        public static void Main()
        {
            string repeat = "y";
            while (repeat == "y")
            {
                Console.WriteLine("*** Main Menu ***\n\nEnter a number between 1 and 9 to select a program: ");
                int input = Convert.ToInt32(Console.ReadLine());
                
                if (input > 0 && input < 10)
                {
                    switch (input)
                    {
                        case 1:
                            ProgramQ1.Main();
                            break;
                        case 2:
                            ProgramQ2.Main();
                            break;
                        case 3:
                            ProgramQ3.Main();
                            break;
                        case 4:
                            ProgramQ4.Main();
                            break;
                        case 5:
                            ProgramQ5.Main();
                            break;
                        case 6:
                            ProgramQ6.Main();
                            break;
                        case 7:
                            ProgramQ7.Main();
                            break;
                        case 8:
                            ProgramQ8.Main();
                            break;
                        case 9:
                            ProgramQ9.Main();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Number input is not within range. Please try again.");
                }
                Console.WriteLine("Type y to continue OR any key to stop program");
                repeat = Console.ReadLine();
            }
        }
    }
}
