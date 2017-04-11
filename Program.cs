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
        Start:
            Console.WriteLine("Type a number 1 to 100 (press Enter) ");
            int num1 = Int32.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("The number you entered is Even");
            }
            else
            {
                Console.WriteLine("The number you entered is Odd");
            }
            Console.ReadLine();

            if ((num1 % 2 == 0) && (num1 >= 2) && (num1 <= 25))
            {
                Console.WriteLine("Even and less than 25");
            }
            else
            {
                if ((num1 % 2 == 0) && (num1 >= 26) && (num1 <= 60))
                {
                    Console.WriteLine("Even");
                    Console.ReadLine();
                }
                else
                {
                    if ((num1 % 2 == 0) && (num1 > 60))
                    {
                        Console.WriteLine("Number {0} is Even", num1);
                        Console.ReadLine();
                    }
                    else
                    {
                        if ((num1 % 2 != 0) && (num1 > 60))
                        {
                            Console.WriteLine("Number {0} is Odd", num1);
                        }
                        Console.ReadLine();

                        goto Start;
                    }
                }
            }
        }
    }
}
       