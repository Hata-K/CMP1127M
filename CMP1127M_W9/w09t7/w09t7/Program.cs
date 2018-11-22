using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09t7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mInstru = new string[] { "cello", "guitar", "violin", "double base"};

            for (int i = 0; i < mInstru.Length; i++)
            {
                string vowels = "aeiou";
                string name = mInstru[i];
                name = new string(name.Where(c => !vowels.Contains(c)).ToArray());
                Console.WriteLine(name);
            }

            /*
             * this is a linq query that selects all the characters from a string where the 
             * character is not contained in the vowels string (that is the Where part) - the ToArray() 
             * is putting all these characters in an array and is necessary since one of the string 
             * constructor overloads takes a character array as input (but doesn't work with an enumeration) 
             */
        }
    }
}
