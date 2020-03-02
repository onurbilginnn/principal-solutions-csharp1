using System;

namespace PerfectNumbers
{
    class PerfectNumber
    {
        public static void CheckPerfect(int z)
        {
            int sum = 0, counter = 1;
            for (int i = (z - 1); i >= 1; i--)
            {
                if (z % i == 0)
                {
                    sum += i;
                    Console.Write(counter + ".divisor = {0}\n", i);
                    counter++;
                } //end if
            } //end for
            if (sum == z)
                Console.WriteLine("Sum of the divisors = " + sum + "\t = " + z + " is a perfect number.");
            else
                Console.WriteLine("Sum of the divisors = " + sum + "\t = " + z + " is not a perfect number!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;

            while (a <= 0) {
                Console.WriteLine("Enter a number = ");
                a = Convert.ToInt32(Console.ReadLine());
            }

            PerfectNumber.CheckPerfect(a);
        }
    }
}
