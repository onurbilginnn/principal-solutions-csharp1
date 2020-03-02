using System;

namespace DiceRolling
{
    class DiceRolling
    {
        private Random a = new Random();

        public int RollDice1()
        {
            int roll1;
            roll1 = 1 + a.Next(6);
            return roll1;
        }
        public int RollDice2()
        {
            int roll2;
            roll2 = 1 + a.Next(6);
            return roll2;
        }
        public int[] CreateSum()
        {
            int[] freq = new int[11];
            for (int i = 0; i < 100; i++)
            {
                switch (RollDice1() + RollDice2())
                {
                    case 2:
                        ++freq[0];
                        break;
                    case 3:
                        ++freq[1];
                        break;
                    case 4:
                        ++freq[2];
                        break;
                    case 5:
                        ++freq[3];
                        break;
                    case 6:
                        ++freq[4];
                        break;
                    case 7:
                        ++freq[5];
                        break;
                    case 8:
                        ++freq[6];
                        break;
                    case 9:
                        ++freq[7];
                        break;
                    case 10:
                        ++freq[8];
                        break;
                    case 11:
                        ++freq[9];
                        break;
                    case 12:
                        ++freq[10];
                        break;
                } //end switch
            } //end for
            return freq;
        } //end CreateSum method

    }

    class DiceRollingTest
    {
        static void Main(string[] args)
        {
            DiceRolling a = new DiceRolling();
            int[] freq = new int[11];
            int count = -1;
            int count1 = 0;
            freq = a.CreateSum();
            Console.Write(" ");
            for (int i = 0; i < 6; i++)
                Console.Write(" {0}\t", i + 1);
            Console.WriteLine();
            Console.Write("1 ");
            while (count1 < 11)
            {
                ++count;

                Console.Write(freq[count1] + "\t");
                count1++;
                if (count == 5)
                {

                    count1 = count1 - count;
                    if (count1 == 6)
                        break;
                    Console.WriteLine();
                    Console.Write("{0} ", count1 + 1);

                    count = -1;

                }


            }
            Console.WriteLine();
            Console.WriteLine();
            int diceSum = 2;
            for (int i = 0; i < 11; i++)
                Console.WriteLine("Sum {0} has been repeated {1} times.", diceSum++, freq[i]);
            Console.WriteLine();

        }
    }
}
