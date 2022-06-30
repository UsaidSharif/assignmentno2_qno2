using System;
using System.Linq;

namespace A2_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 0, large = 0, k = 0;
            Console.WriteLine("Write Number of elements to be entered in an array!");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] terms = new int[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Write elements to be entered in an array!");
                int value = Convert.ToInt32(Console.ReadLine());
                terms[i] = value;
            }

            Console.WriteLine("Array you made is\n ");

            for (int m = 0; m < Number; m++)
            {
                Console.Write(" " + terms[m]);
            }
            Console.WriteLine("\nArray after delting largest element is\n ");
            for (int j = 0; j < terms.Length; j++)
            {

                if (terms[j] >= largest)
                {
                    largest = terms[j];
                    k = j;

                }

            }

            terms = terms.Where(e => e != terms[k]).ToArray();
            Console.WriteLine(String.Join(",", terms));




            for (int l = 0; l < terms.Length; l++)
            {

                if (terms[l] >= large)
                {
                    large = terms[l];

                }

            }



            Console.WriteLine("\nlargest number of array is\n " + largest);
            Console.WriteLine("\n2nd largest number of array is\n " + large);

        }
    }
}
