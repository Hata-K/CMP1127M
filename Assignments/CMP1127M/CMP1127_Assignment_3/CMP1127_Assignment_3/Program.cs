using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Collections;

namespace CMP1127_Assignment_3
{
    class Program
    {

        public static Hashtable sourceHT { get; set; }
        public class MultiDimDictList<K, T> : Dictionary<K, List<T>> { }

        static void Main(string[] args)
        {
            var myDicList = new MultiDimDictList<int, string>();
            //Accesing the source file.
            DirectoryInfo currentDir = new DirectoryInfo(".");
            DirectoryInfo sourceDir = new DirectoryInfo("../../../../list_of_prime_ministers_of_uk.csv");

            //List is initiated so that it can be populated with each line.
            List<string> li10 = new List<string>();
            List<string> lineList = new List<string>();

            //Global hashtable that takes int as key and a list as a value in
            sourceHT = new Hashtable();

            //Each line of the csv file is inputted into a list
            foreach (string lines in File.ReadAllLines(sourceDir.ToString()))
            {
                li10.Add(lines);
            }
            Console.WriteLine(li10.Count);

            //implementing elements into the global hashtable by calling an external method
            for (int i = 1; i < li10.Count; i++)
            {
                string[] eachRes = li10[i].Split(',');

                for (int j = 0; j < eachRes.Length; j++)
                {
                    lineList.Add(eachRes[j]);
                    
                }
                int keyD = Convert.ToInt32(eachRes[0]);
                myDicList.Add(i, lineList);
                //method call
                //AddToHT(keyD, lineList);
                //myDicList.Add(keyD, lineList);
            }
            Console.WriteLine(myDicList.Count());
            int count1 = 0;
            int count2 = 0;
            for (int i = 1; i <= myDicList.Count; i++)
            {
                count1 += 1;
                //Console.WriteLine(myDicList[i]);
                foreach (var VARIABLE in myDicList[i])
                {
                    //Console.Write(VARIABLE + "\t");
                    count2 += 1;
                }
                //Console.WriteLine("\n");
            }
            Console.WriteLine(count1);
            Console.WriteLine(count2);
            /*foreach (var item in myDicList)
            {
                Console.WriteLine(item);
            }
            
            foreach (var item in lineList)
            {
                //Console.WriteLine(item);
            }
            //DisplayHT(sourceHT);
            for (int i = 1; i <= myDicList.Count; i++)
            {
                //Console.WriteLine(myDicList[i]);
                foreach (var VARIABLE in myDicList[i])
                {
                    Console.Write(VARIABLE + "\t");
                }
                Console.WriteLine("\n");
            }

            string[] myR = myDicList[1].ToArray();
            Console.WriteLine(myR[2]);
            */
        }
        /*

        private static void DisplayHT(Hashtable sourceHT)
        {
            List<int> keyList = new List<int>();

            foreach (DictionaryEntry i in sourceHT)
            {
                keyList.Add(Convert.ToInt32((i.Key).ToString()));
            }

            for (int i = 0; i < keyList.Count(); i++)
            {
                foreach (var s in ((List<string>)sourceHT[keyList[i]]))
                {
                    Console.WriteLine(s);
                }
                for (int j = 0; j < 5; j++)
                {
                    //sourceHT[keyList[i]]);
                }
            }
        }
        private static void AddToHT(int dKey, List<string> dValue)
        {
            //sourceHT.Add(dKey, dValue);
        }
        */
    }
}
