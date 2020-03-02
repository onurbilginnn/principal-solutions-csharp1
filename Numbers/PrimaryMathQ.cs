using System;

namespace RandomMathQuestions
{
    class PrimarySchool
    {

        public static void DisplayGood()
        {
            Random c = new Random();
            switch (c.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("Very good!");
                    break;
                case 2:
                    Console.WriteLine("Excellent!");
                    break;
                case 3:
                    Console.WriteLine("Nice work!");
                    break;
                case 4:
                    Console.WriteLine("Keep up the good work!");
                    break;
                default:
                    break;
            }
        } //end DisplayGood()
        public static void DisplayBad()
        {
            Random c = new Random();
            switch (c.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("No. Please try again.");
                    break;
                case 2:
                    Console.WriteLine("Wrong. Try once more.");
                    break;
                case 3:
                    Console.WriteLine("Don't give up!");
                    break;
                case 4:
                    Console.WriteLine("No. Keep trying.");
                    break;
                default:
                    break;
            }
        } //end DisplayBad()
        public static void Transaction()
        {
            Random b = new Random();
            Random p = new Random();
            int result, no1, no2;

            no1 = p.Next(1, 10);
            no2 = p.Next(1, 10);
            switch (b.Next(1, 4))
            {
                case 1:
                    result = no1 + no2;
                    Console.WriteLine(no1 + "+" + no2 + "= ?");
                    if (Convert.ToInt32(Console.ReadLine()) == result)
                        DisplayGood();
                    else
                        DisplayBad();
                    break;
                case 2:
                    result = no1 - no2;
                    Console.WriteLine(no1 + "-" + no2 + "= ?");
                    if (Convert.ToInt32(Console.ReadLine()) == result)
                        DisplayGood();
                    else
                        DisplayBad();
                    break;
                case 3:
                    result = no1 * no2;
                    Console.WriteLine(no1 + "x" + no2 + "= ?");
                    if (Convert.ToInt32(Console.ReadLine()) == result)
                        DisplayGood();
                    else
                        DisplayBad();
                    break;
                case 4:
                    result = no1 / no2;
                    Console.WriteLine(no1 + "/" + no2 + "= ?");
                    if (Convert.ToInt32(Console.ReadLine()) == result)
                        DisplayGood();
                    else
                        DisplayBad();
                    break;
                default:
                    break;

            }
        }
        static void Main(string[] args)
        {
            int i = 1;
            while (i != -1)
            {
                Transaction();
                Console.WriteLine("Type -1 to exit!!Enter a number to continue.");
                i = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
