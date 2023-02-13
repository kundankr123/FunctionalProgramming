﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Factors
    {
        public static void primefactorization()
        {
            Console.WriteLine("Enter the value of n :");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n = n / 2;
            }
            for (int i = 3; i * i <= n; i = i + 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }
            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
