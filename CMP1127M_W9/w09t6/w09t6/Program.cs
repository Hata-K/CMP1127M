using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09t6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArr1 = new int[,] { { 2, 3 }, { 2, 5 }, { 7, 1 }, { 4, 5 } };
            int[,] intArr2= new int[,] { { 5, 9 }, { 1, 3 }, { 1, 1 }, { 7, 3 } };
            if (intArr1.GetLength(0) == intArr2.GetLength(0) && intArr1.GetLength(1) == intArr2.GetLength(1))
            {
                DisplayElements(intArr1, intArr2);
            }
            else
            {
                Console.WriteLine("Oops! Matrices don't match...");
            }
            
        }

        private static void DisplayElements(int[,] Arr1, int[,] Arr2)
        {
            Console.WriteLine("2D int array...");

            for (int i = 0; i < Arr1.GetLength(0); i++)
            {
                for (int j = 0; j < Arr1.GetLength(1); j++)
                {
                    Console.Write("[{0}], [{1}] :\t",i,j);
                    Console.WriteLine(Arr1[i, j] + Arr2[i, j] + " \n");
                }
            }
        }
    }
}
