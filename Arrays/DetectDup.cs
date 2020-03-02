using System;

namespace DetectDuplicate
{
    class Duplicate
    {
        private int[] numbers = new int[5];

        public Duplicate(int[] array)
        {
            numbers = array;
        }

        public void NumberEntry()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number = ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] < 10 || numbers[i] > 100)
                {
                    Console.WriteLine("Enter a number between 10 - 100!!");
                    i--;
                }
                else
                {

                    Console.WriteLine("Last entry = " + numbers[i]);
                    if (Control(numbers) == 0)
                    {
                        i--;

                        continue;

                    }
                }

            }

        }//entry method

        public void displayNumbers(int[] x)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}.element = {1} ", i + 1, numbers[i]);
            }
            Console.WriteLine();
        }
        public int Control(int[] control)
        {
            for (int i = 0; i < control.Length; i++)
            {
                for (int j = 0; j < control.Length; j++)
                {

                    if (control[j] == 0)
                        continue;

                    else if (control[i] == control[j] && j != i)
                    {
                        Console.WriteLine("Duplicate values are not acceptable. Please try again.!!");

                        return 0;
                    }


                }

            }
            return 1;


        }

    }
    class DuplicateTest
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            Duplicate b = new Duplicate(a);
            b.NumberEntry();
            b.displayNumbers(a);
        }
    }
}
