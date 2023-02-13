using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class EvenOdd
    {
        public static void FindEvenAndOdd()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The Number is Even.");
            }
            else
            {
                Console.WriteLine("The Number is Odd.");
            }
        }
    }
}
