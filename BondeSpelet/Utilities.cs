using System;
using System.Collections.Generic;
using System.Text;

namespace BondeSpelet
{
    internal class Utilities
    {
        public static int GetUserNumber(int min = 0, int max = 10000000)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < min || input > max)
            {
                Console.WriteLine($"You must enter a number between {min}-{max}");
            }
            return input;
        }
    }
}
