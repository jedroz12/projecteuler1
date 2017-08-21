using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler1
{
    class Program
    {
        /*
        Problem 1 of ProjectEuler.net
        https://projecteuler.net/problem=1
        "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        Find the sum of all the multiples of 3 or 5 below 1000."
        */

        static void Main()
        {
            Console.WriteLine(FindSum().ToString());
            Console.Read();
        }

        static double FindSum()
        {
            double total = 0;
            for (double i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
