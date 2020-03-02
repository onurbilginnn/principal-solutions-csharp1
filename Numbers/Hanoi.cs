using System;

namespace Hanoi
{
    public class TowersOfHanoi
    {
        private static void solveTowers(int n, char startPeg, char endPeg, char tempPeg)
        {
            if (n > 0)
            {
                solveTowers(n - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine("Move disk from " + startPeg + ' ' + endPeg);
                solveTowers(n - 1, tempPeg, endPeg, startPeg);

            }
        }

        public static void Main(String[] args)
        {
            char startPeg = 'A'; // start tower in output
            char endPeg = 'C'; // end tower in output
            char tempPeg = 'B'; // temporary tower in output
            int totalDisks = -1; // number of disks

            while(totalDisks <= 0)
            {
                Console.WriteLine("Enter a number");
                totalDisks = Int32.Parse(Console.ReadLine());
            }

            solveTowers(totalDisks, startPeg, endPeg, tempPeg);
        }

    }
}
