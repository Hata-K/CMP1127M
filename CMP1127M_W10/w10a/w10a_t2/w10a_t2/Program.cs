using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10a_t2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dobArray = new double[] { 0.2, 0.3, 0.8, 1.2, 3.4 };

            Console.Write("Enter the number of elements you want in the string array : ");
            int userArrNoInput = Convert.ToInt32(Console.ReadLine());

            string[] stringArr = new string[userArrNoInput];

            ArrayList comArr = new ArrayList();

            for (int i = 0; i < stringArr.Length; i++)
            {
                Console.Write("Enter string to input into the array : ");
                string userStringInput = Console.ReadLine();
                stringArr[i] = userStringInput;
            }

            comArr.AddRange(dobArray);
            comArr.AddRange(stringArr);

            //comArr.Sort(0, 4, null);
            //comArr.sort(5, userArrNoInput, null);

            comArr.Sort(0, (dobArray.Length - 1), null);
            comArr.Sort(dobArray.Length, stringArr.Length, null);

            foreach (var item in comArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
