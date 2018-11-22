using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09t1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[] { 2, 5, 7, 1, 4 };
            double[] doubleArr = new double[] { 22.3, 43.4, 5.5, 23.1, 334 };
            string[] stringArr = new string[] { "One", "Two", "Three", "Four", "Five" };

            DisplayElements(intArr);
            DisplayElements(doubleArr);
            DisplayElements(stringArr);
        }

        private static void DisplayElements(int[] Arr)
        {
            Console.WriteLine("int...");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }


        private static void DisplayElements(double[] Arr)
        {
            Console.WriteLine("double...");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }

        }


        private static void DisplayElements(string[] Arr)
        {
            Console.WriteLine("string...");
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
