using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09t5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArr = new int[,] { { 2, 3}, { 2, 5}, { 7, 1}, { 4, 5 }};

            DisplayElements(intArr);
        }

        private static void DisplayElements(int[,] Arr)
        {
            Console.WriteLine("2D int array...");
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i,j]+ " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
