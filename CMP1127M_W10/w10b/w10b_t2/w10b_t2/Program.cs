using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10b_t2
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialising stack that holds char
            Stack<char> charStack = new Stack<char>();

            //getting user input as char array
            Console.Write("Enter sequences of characters: ");
            char[] userCInput = Console.ReadLine().ToString().ToArray();

            
            for (int i = 0; i < userCInput.Length; i++)
            {
                if (userCInput[i] == '{')
                {
                    while (userCInput[i] != '}')
                    {
                        charStack.Push(userCInput[i]);
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
