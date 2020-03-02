using System;

namespace FindPrimeNumbes
{
    class Prime
    {
        private bool[] prime = new bool[1000];
        private const int ARRAY_SIZE = 100;
        public void AssignTrue()
        {
            for (int i = 0; i < ARRAY_SIZE; i++)
                prime[i] = true;
        }
        public void PrimeCheck()
        {

            for (int i = 3; i < ARRAY_SIZE; i++)
            {
                for (int j = 2; j < ARRAY_SIZE; j++)
                {
                    if (i % j == 0 && j < i)
                    {
                        prime[i] = false;
                        break;
                    }


                }
            }
        }
        public void DisplayPrime()
        {
            AssignTrue();
            PrimeCheck();
            for (int i = 2; i < ARRAY_SIZE; i++)
            {
                if (prime[i] == false)
                    Console.WriteLine("{0} is not a prime number.", i);
                else
                    Console.WriteLine("{0} is a prime number.", i);
            }
        }
    }//end class
    class Test
    {
        public static void Main(string[] args)
        {
            Prime a = new Prime();
            a.DisplayPrime();

        }


    }
}
