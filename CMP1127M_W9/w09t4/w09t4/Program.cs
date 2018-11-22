using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] stuScore = new int[30];

            for (int i = 0; i < stuScore.Length; i++)
            {
                int rndScore = rnd.Next(1, 101);
                stuScore[i] = rndScore;
            }

            outputAvg(stuScore);
        }

        private static void outputAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum / (arr.Length);
            Console.WriteLine("Average of the scores are: {0}", avg);
        }
    }
}
