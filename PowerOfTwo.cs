using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class PowerOfTwo
    {
        public static void slnpoweroftwo()
        {
            Console.WriteLine("Enter the power value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N <= 31)
            {
                Console.WriteLine("the  powers of two are: ");
                for (int i = 0; i <= N; i++)
                {
                    double num = Math.Pow(2, i);
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("You have entered out of range power value.");
            }
        }
    }
}
