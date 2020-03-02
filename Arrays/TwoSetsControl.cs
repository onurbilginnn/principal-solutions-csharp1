using System;

namespace SetCheck
{
    class Sets
    {
        private bool[] set1 = new bool[100];
        private bool[] set2 = new bool[100];
        private int ARRAY_SIZE = 100;

        public Sets(bool[] a = null, bool[] b = null)
        {
            set1 = a;
            set2 = b;
        }

        public bool[] Intersection()
        {
            bool[] Intersection = new bool[100];
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                if (set1[i] == true && set2[i] == true)
                    Intersection[i] = true;
                else
                    Intersection[i] = false;
            }
            return Intersection;
        }

        public bool[] Union()
        {
            bool[] Union = new bool[100];
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                if (set1[i] == false && set2[i] == false)
                    Union[i] = false;
                else
                    Union[i] = true;
            }
            return Union;
        }

        public bool IsEqual()
        {
            int count = 0;
            for (int i = 0; i < ARRAY_SIZE; i++)
                if (set1[i] == set2[i])
                {
                    count++;

                    continue;
                }
                else
                    break;
            if (count == ARRAY_SIZE)
                return true;
            else
                return false;

        }

        public void InsertElement(bool[] x, int k)
        {
            x[k] = true;
        }

        public void DeleteElement(bool[] x, int k)
        {
            x[k] = false;
        }

        public string ToString(bool[] set)
        {

            if (set == null)
                return "Set = '---'";


            else
            {

                for (int i = 0; i < ARRAY_SIZE; i++)
                    if (set[i] == true)
                    {
                        Console.Write(string.Format("{0} ", i));

                    }



            }
            return "\n";

        }


    }

    class SetsTest
    {
        static void Main(string[] args)
        {
            bool[] set1 = new bool[100];
            bool[] set2 = new bool[100];
            bool[] union = new bool[100];
            bool[] interSec = new bool[100];
            Sets a = new Sets(set1, set2);

            a.InsertElement(set1, 49);
            a.InsertElement(set2, 49);

            a.InsertElement(set1, 9);
            a.InsertElement(set2, 45);

            a.InsertElement(set1, 3);
            a.InsertElement(set2, 6);

            a.InsertElement(set1, 69);
            a.InsertElement(set2, 19); 



            union = a.Union();
            interSec = a.Intersection();

            Console.WriteLine("Set 1 : ");
            Console.WriteLine("{0}", a.ToString(set1));

            Console.WriteLine("Set 2 : ");
            Console.WriteLine("{0}", a.ToString(set2));

            Console.WriteLine("Union : ");
            Console.WriteLine("{0}", a.ToString(union));

            Console.WriteLine("Intersection : ");
            Console.WriteLine("{0}", a.ToString(interSec));

            Console.WriteLine(a.IsEqual() == true ? "2 sets are equal." : "2 sets are not equal.");



        }
    }
}
