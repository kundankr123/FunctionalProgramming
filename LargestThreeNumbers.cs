﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LargestThreeNumbers
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is greatest among three. ");
                }
                else
                {
                    Console.WriteLine("The 3rd number is greatest among three. ");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is greatest among three. ");
            }
            else
            {
                Console.WriteLine("The 3rd number is greatest among three. ");
            }
        }
    }
}
