using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Swap
    {
        public static void SwapingNumbers()
        {
            Console.WriteLine("Enter two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Values Before swap: a=" + a +" b=" +b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Values After swap: a=" + a + " b=" + b);
        }
    }
}
