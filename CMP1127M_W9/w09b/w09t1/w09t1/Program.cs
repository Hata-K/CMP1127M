using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace w09t1
{
    class Program
    {
        static void Main(string[] args)
        {
            string results = "Manchester-United 1: Chelsea 0:, Arsenal 1: Manchester-United 1:, Manchester-United 3: Fulham 1:, Liverpool 2: Manchester-United 1:, Swansea 2: Manchester-United 4:";
            
            results = results.Replace(" ", "");
            Console.WriteLine(results);
            string[] eachRes = results.Split(':', ',');
            for (int i = 0; i < eachRes.Length; i++)
            {
                Console.WriteLine(eachRes[i]);
            }

            Console.WriteLine(eachRes[1]+ "\n");
            Console.WriteLine("---------------------------------------------------");

            string digitPatt = "([0-9]+)";
            /*
            string[] subStrings = Regex.Split(eachRes[0], digitPatt);
            Console.WriteLine(subStrings[0]+"\n");
            
            foreach (string item in subString)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < subString.Length; i++)
            {

            }
            */

            for (int i = 0; i < eachRes.Length; i++)
            {
                string[] subString = Regex.Split(eachRes[i], digitPatt);
                //Console.WriteLine(subString[0]);
                foreach (string item in subString)
                {
                    Console.WriteLine(item);
                }
            }
            

        }
    }
}
