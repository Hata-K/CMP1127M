using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array you want to create: ");
            int arrLength = Convert.ToInt32(Console.ReadLine());

            int[] intArr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Input {0} element in the array: ", (i + 1));
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            DisplayElementsI(intArr);
        }

        private static void DisplayElementsI(int[] intArr)
        {
            Console.WriteLine("Displaying elements...");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine("Element - {0} : {1}", i, intArr[i]);
            }
        }
    }
}
