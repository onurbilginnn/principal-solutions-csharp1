using System;

namespace Rational
{
    public class RationalMethods
    {
        public int[] findRational(int num, int denom)
        {
            int[] numDenom = new Int32[2];            

            int[] divArr = findCommonDivisors(num, denom);

            for(int i = divArr.Length-1; i >= 0 ; i--)
            {
                if (divArr[i] != 0 && num % divArr[i] == 0 && denom % divArr[i] == 0)
                {
                    num /= divArr[i];
                    denom /= divArr[i];
                }              
            }
            numDenom[0] = num;
            numDenom[1] = denom;

            return numDenom;
        }   

    // ***** General Use Methods *****

        private int[] findCommonDivisors(int num, int denom)
        {
        int loopLimit;
        int counter = 0;

        if(num >= denom)
            {
                loopLimit = denom;
            }
        else
            {
                loopLimit = num;
            }

        int[] divisors = new Int32[loopLimit];

        for (int i = 2; i <= loopLimit; i++)
            {
                if (num % i == 0 && denom % i == 0)
                {
                   divisors[counter] = i;
                   counter++;
                }
            }
        return divisors;         
        }

        public void writeRat(int num, int denom)
        {
            if (num % denom == 0)
            {
                Console.Write(num/denom);                
            }
            else {
                Console.Write(num + "/" + denom);
            }
        }

        // ***** General Use Methods *****
    }


    class RationalTest
    {
        static void Main(string[] args)
        {
            RationalMethods r = new RationalMethods();
            int[] simplifiedRat1 = new int[2];
           
            Console.WriteLine("Enter first numerator:");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter first denominator:");
            int denom1 = Int32.Parse(Console.ReadLine());

            simplifiedRat1 = r.findRational(num1, denom1);

            Console.Write(num1 + "/" + denom1 + " = ");
            r.writeRat(simplifiedRat1[0], simplifiedRat1[1]);
            Console.WriteLine();

        }
    }
}
