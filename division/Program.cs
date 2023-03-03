using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"{"Please enter a numberber"}");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{"The count of divisors of"} {number} {"is:"} {countDivisors(number)} ");
            Console.WriteLine($"{"The divisors of"} {number} {"are:"}");
            divisors(number);
            Console.ReadLine();

        }

        static int countDivisors(int n)
        {
            int divisorcounter = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (n / i == i)
                        divisorcounter++;

                    else
                        divisorcounter = divisorcounter + 2;
                }
            }
            return divisorcounter;
        }
        public static void divisors(int number)
        {
            for (int x = 1; x <= number; x++)
            {
                if (number % x == 0)
                {
                    Console.WriteLine(x);
                }
            }

        }
    }
}