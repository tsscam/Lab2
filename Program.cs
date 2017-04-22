using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           do
            {
                Console.WriteLine("Type a number 1 to 100 (press Enter) ");
                int num1 = Int32.Parse(Console.ReadLine());
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("The number you entered is Even");
                    Console.WriteLine("Do you want to continue?");
                    
                }
                else
                {
                    Console.WriteLine("The number you entered is Odd");
                    

                    if ((num1 % 2 == 0) && (num1 >= 2) && (num1 <= 25))
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if ((num1 % 2 != 0) && (num1 > 60))

                        Console.WriteLine("Number {0} is Odd", num1);
                }
            } while (Continue());
    }

                
       public static bool Continue()
        {
            bool run = true;
            Console.WriteLine("***************************");
            Console.WriteLine("Would you like to continue? (y/n) : ");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                run = false;
                Console.WriteLine("\n See you next time :) ");
            }
            else
            {
                Console.WriteLine("Please select y/n :  ");
                Continue();
                
            }

                return run;

        }
    }
}