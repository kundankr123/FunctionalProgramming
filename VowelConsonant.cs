﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class VowelConsonant
    {
        public static void CheckTheCharacter()
        {
            char ch;

            Console.WriteLine("Enter any character:");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Entered character is Vowel.");
            }
            else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Entered character is Consonant.");
            }
            else 
            {
                Console.WriteLine("Entered character is neither Vowel Nor Consonant");
            }
        }
    }
}
