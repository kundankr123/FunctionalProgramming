using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LeapYear
    {
        public static void slnleapyear()
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 1000)
            {
                Console.WriteLine("Year has less than 4 digits.");
            }
            else
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year.", year);
                }
            }
        }
    }
}
