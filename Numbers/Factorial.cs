using System;

namespace Factorial
{
    public class Factorials
    {
        public static long MultiplicationFactorial(long x)
        {
            if (x <= 1)
                return 1;
            else
                return x * MultiplicationFactorial(x - 1);
        }
        public static long SumFactorial(long y)
        {
            if (y <= 1)
                return 1;
            else
                return y + SumFactorial(y - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {          
            int a = -1;

            while (a < 0)
            {
                Console.WriteLine("Enter a number = ");
                a = Convert.ToInt32(Console.ReadLine());
            }
          
                Console.WriteLine("Factorial: " + Factorials.MultiplicationFactorial(a)
                + "\nCumulative sum = " + Factorials.SumFactorial(a));
            
           
        }
    }
}
