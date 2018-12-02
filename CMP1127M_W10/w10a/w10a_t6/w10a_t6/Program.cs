using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10a_t6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> li01 = new List<char>() { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
            List<char> li02 = new List<char>() { 'D', 'G'};
            List<char> li03 = new List<char>() { 'B', 'C', 'M', 'P'};
            List<char> li04 = new List<char>() { 'F', 'H', 'V', 'W', 'Y'};
            List<char> li05 = new List<char>() { 'K'};
            List<char> li08 = new List<char>() { 'J', 'X'};
            List<char> li10 = new List<char>() { 'Q', 'Z'};

            Hashtable ht = new Hashtable();

            ht.Add(1, li01);
            ht.Add(2, li02);
            ht.Add(3, li03);
            ht.Add(4, li04);
            ht.Add(5, li05);
            ht.Add(8, li08);
            ht.Add(10, li10);

            List<int> keyList = new List<int>();
            
            Console.Write("Enter a world: ");
            string userInput = Console.ReadLine();
            char[] strChar = userInput.ToUpper().ToArray();

            
            foreach (DictionaryEntry i in ht)
            {
                keyList.Add(Convert.ToInt32((i.Key).ToString()));
            }

            int x = FindSum(ht,keyList, strChar);
            Console.WriteLine(x);
        }

        private static int FindSum(Hashtable ht, List<int> keyList, char[] strChar)
        {
            int sum = 0;
            
            for (int i = 0; i < keyList.Count(); i++)
            {
                foreach (char s in ((List<char>)ht[keyList[i]]))
                {
                    foreach (var k in strChar)
                    {
                        if (k == s)
                        {
                            sum += keyList[i];
                        }
                    }
                }
            }
            return(sum);
        }
    }
}
/*
             foreach (char strChars in strChar)
            {
                Console.Write(strChars +  " ");
            }
            
            Console.WriteLine("\n");
            
            foreach (char s in ((List<char>)ht[1]))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
             
             
            Console.WriteLine("\n");
            foreach (var v in keyList)
            {
                Console.WriteLine(v);
                foreach (char s in ((List<char>)ht[v]))
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("_____");

            }

             
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine("{0}, {1}", i.Key, i.Value);
                
            }
            
            
            
            foreach (var item in li01)
            {
                Console.Write(item + " ");
            }
            
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine("{0}, {1}", i.Key, i.Value);
                
            }
            string variable1 = "key1";
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, new List<string>());

            ((List<string>)hashTable[1]).Add("text1");
            ((List<string>)hashTable[1]).Add("text2");

            foreach (string s in ((List<string>)hashTable[1]))
            {
                Console.WriteLine(s);
            }
            ICollection keys = ht.Keys;
            foreach (var k in keys)
            {
                //Console.WriteLine(ht[k]);
                foreach (var x in ht[k])
                {
                    Console.WriteLine(x);
                }
            }

            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine(ht[i].ToString().Key);
            }

            
            int sum = 0;

            foreach (var x in userInput)
            {
                foreach (var i in ht)
                {
                    string mKey = ht[i].ToString();
                    Console.WriteLine(mKey);
                }
            }

            for (int i = 0; i < length; i++)
            {

            }
*/