using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class HarmonicNumber
    {
        public static void nthharmonic()
        {
            Console.WriteLine("enter the value of n to find harmonic number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double num = 1;
            if (n == 1)
            {
                Console.WriteLine("Harmonic number is :" + num);
            }
            else if (n >= 2)
            {
                for (double i = 2; i <= n; i++)
                {
                    num = num + (1 / i);
                }
                Console.WriteLine("Harmonic number is :" + num);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
