using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the first array: ");
            int arrLengthOne = Convert.ToInt32(Console.ReadLine());

            int[] intArr1 = new int[arrLengthOne];

            for (int i = 0; i < arrLengthOne; i++)
            {
                Console.Write("Element - {0} : ", i);
                intArr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Console.Write("Input the number of elements to be stored in the second array: ");
            int arrLengthTwo = Convert.ToInt32(Console.ReadLine());

            int[] intArr2 = new int[arrLengthTwo];

            for (int j = 0; j < arrLengthTwo; j++)
            {
                Console.Write("Element - {0} : ", j);
                intArr2[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            int[] finalArr = new int[intArr1.Length + intArr2.Length];

            Array.Copy(intArr1, 0, finalArr, 0, intArr1.Length);
            Array.Copy(intArr2, 0, finalArr, intArr1.Length, intArr2.Length);

            Array.Sort(finalArr);

            DisplayElementsI(finalArr);
        }

        private static void DisplayElementsI(int[] intArr)
        {
            Console.WriteLine("Expected Output: \nThe merged array in asending order is: ");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("{0} ", intArr[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
