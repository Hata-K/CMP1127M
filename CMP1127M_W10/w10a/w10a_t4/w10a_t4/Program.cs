using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10a_t4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] colArr = new int[] { 1, 2, 3, 4, 5 };
            ArrayList resArr = new ArrayList();

            Console.Write("Pick a number associalted with the operation: \n" +
                "1. Square it \n" +
                "2. Double it \n" +
                "3. Tripple it \n");

            int caseSwitch = Convert.ToInt16(Console.ReadLine());

            if(caseSwitch == 1)
            {
                SquareIt(colArr, resArr);
            }else if (caseSwitch == 2)+
            {
                MultipArray(colArr, resArr, 2);
            }
            else if (caseSwitch == 3)
            {
                MultipArray(colArr, resArr, 3);
            }
            else
            {
                Console.WriteLine("Enter a number from the given selection...");
            }
        }

        private static void MultipArray(int[] colArr, ArrayList resArr, int v)
        {
            for (int i = 0; i < colArr.Length; i++)
            {
                int sqr = colArr[i] * v;
                resArr.Add(sqr);
            }


            foreach (var item in resArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        private static void SquareIt(int[] colArr, ArrayList resArr)
        {
            for (int i = 0; i < colArr.Length; i++)
            {
                int sqr = colArr[i] * colArr[i];
                resArr.Add(sqr);
            }


            foreach (var item in resArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
