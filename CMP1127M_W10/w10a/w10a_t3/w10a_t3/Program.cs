using System;
using System.Collections.Generic;

namespace w10a_t3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            List<int> intListRes = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                intList.Add(i);
            }

            for (int i = 0; i < intList.Count; i++)
            {
                if ((intList[i] % 3 == 0) || (intList[i] % 5 == 0))
                {
                    continue;
                }
                else
                {
                    intListRes.Add(intList[i]);
                }
            }
            
            foreach (int x in intListRes)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
