using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class QuotientRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            Console.WriteLine("Enter Dividend:");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor:");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;

            Console.WriteLine("Dividend={0} Divisor={1}",Dividend,Divisor);
            Console.WriteLine("The Quotient is: " + Quotient);
            Console.WriteLine("The Remainder is: " + Remainder);
        }
    }
}
